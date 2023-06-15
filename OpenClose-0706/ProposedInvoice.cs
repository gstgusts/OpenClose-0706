namespace OpenClose_0706
{
    public class ProposedInvoice : IInvoice
    {
        public double GetInvoiceDiscount(double amount)
        {
            return amount - 40;
        }
    }
}
