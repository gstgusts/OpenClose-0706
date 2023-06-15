namespace OpenClose_0706
{
    public class RecurringInvoice : IInvoice
    {
        public double GetInvoiceDiscount(double amount)
        {
            return amount - 30;
        }
    }
}
