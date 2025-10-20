namespace DesignPatterns.Strategy
{
    public class BankTransferPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Payment Type: Bank Transfer. Amount: {amount}");
        }
    }
}
