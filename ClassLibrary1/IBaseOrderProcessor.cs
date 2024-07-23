using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace order.common 
{
    public interface IBaseOrderProcessor
    {
        public void ProcessOrder();

        public void ValidateShippingAddress();
    }
}
