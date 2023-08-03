namespace GeekShopping.PaymentProcessor;

public class ProcessPayment : IProcessPayment
{
    public bool PaymentProcessor()
    {
        // apenas simula o consumo de um microservico real que realize o pagamento e devolva true
        return true;
    }
}