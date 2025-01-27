using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Adapter : IPaymentService
    {
        public readonly PaymentGateway _paymentGateway;
        public Adapter(PaymentGateway paymentGateway) 
        {
            _paymentGateway = paymentGateway;


        }

        public void Pay(decimal amount)
        {
            _paymentGateway.ProcessTransaction(amount, false);
        }

        public void Refund(decimal amount)
        {
            _paymentGateway.ProcessTransaction(amount, true);
        }

    }
}
