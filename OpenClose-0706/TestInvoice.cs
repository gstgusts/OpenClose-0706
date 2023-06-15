using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose_0706
{
    internal class TestInvoice : IInvoice
    {
        public double GetInvoiceDiscount(double amount)
        {
            return amount - 100;
        }
    }
}
