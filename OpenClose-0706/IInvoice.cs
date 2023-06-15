using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose_0706
{
    public interface IInvoice
    {
        double GetInvoiceDiscount(double amount);
    }
}
