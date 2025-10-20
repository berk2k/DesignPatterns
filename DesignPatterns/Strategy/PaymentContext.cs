namespace DesignPatterns.Strategy
{
    public class PaymentContext
    {
        private IPaymentStrategy _paymentStrategy;

        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            _paymentStrategy = strategy;
        }

        public void ExecutePayment(decimal amount)
        {
            if (_paymentStrategy == null)
            {
                Console.WriteLine("No payment method selected!");
                return;
            }

            _paymentStrategy.Pay(amount);
        }
    }

}
