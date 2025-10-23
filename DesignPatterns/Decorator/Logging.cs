public interface IService
{
    void Execute();
}
public class BusinessService : IService
{
    public void Execute()
    {
        Console.WriteLine("Business logic executed.");
    }
}

public abstract class ServiceDecorator : IService
{
    protected readonly IService _innerService;

    protected ServiceDecorator(IService innerService)
    {
        _innerService = innerService;
    }

    public virtual void Execute()
    {
        _innerService.Execute();
    }
}

public class LoggingDecorator : ServiceDecorator
{
    public LoggingDecorator(IService innerService) : base(innerService) { }

    public override void Execute()
    {
        Console.WriteLine("[LOG] Starting execution...");
        base.Execute();
        Console.WriteLine("[LOG] Execution finished.");
    }
}

public class AuthorizationDecorator : ServiceDecorator
{
    public AuthorizationDecorator(IService innerService) : base(innerService) { }

    public override void Execute()
    {
        Console.WriteLine("[AUTH] Checking permissions...");
        base.Execute();
    }
}

