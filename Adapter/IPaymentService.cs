using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public interface IPaymentService
    {
        void Pay(decimal amount);
        void Refund(decimal amount);
    }
}
