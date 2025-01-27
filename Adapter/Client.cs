using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Client
    {
        private readonly IPaymentService _sender;

        public Client(IPaymentService sender)
        {
            _sender = sender;
        }
        public void DoWorkPay(decimal amount)
        {
            _sender.Pay(amount);
        }

        public void DoWorkRefund(decimal amount)
        {
            _sender.Refund(amount);
        }
    }
}
