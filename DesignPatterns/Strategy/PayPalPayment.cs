namespace DesignPatterns.Strategy
{
    public class PayPalPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Payment Type: PayPal. Amount: {amount}");
        }
    }
}
