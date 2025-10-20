namespace DesignPatterns.Strategy
{
    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Payment type: Credit Card. Amount: {amount}");
        }
    }
}
