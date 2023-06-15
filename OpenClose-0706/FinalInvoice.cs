namespace OpenClose_0706
{
    public class FinalInvoice : IInvoice
    {
        public double GetInvoiceDiscount(double amount)
        {
            return amount - 50;
        }
    }
}
