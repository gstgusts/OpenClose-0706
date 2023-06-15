namespace OpenClose_0706
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Invoice Amount: 10000");

            IInvoice FInvoice = new FinalInvoice();

            IInvoice PInvoice = new ProposedInvoice();

            IInvoice RInvoice = new RecurringInvoice();

            IInvoice TInvoice = new TestInvoice();

            var invoices = new List<IInvoice> { FInvoice, PInvoice, RInvoice, TInvoice };

            foreach (var invoice in invoices)
            {
                Console.WriteLine($"Invoice { invoice.GetType() } discount is: " + invoice.GetInvoiceDiscount(10000));
            }
        }
    }
}