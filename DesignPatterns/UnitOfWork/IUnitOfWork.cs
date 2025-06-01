

public interface IUnitOfWork : IDisposable
{
    IRepository<Product> Products { get; }
    IRepository<Category> Categories { get; }
    Task<int> CompleteAsync(); // SaveChanges
}

