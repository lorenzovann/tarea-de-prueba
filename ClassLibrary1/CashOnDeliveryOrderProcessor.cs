using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace order.common 
{
    public class CashOnDeliveryOrderProcessor : IBaseOrderProcessor
    {
        public readonly IOrderProcessor _orderProcessor;

        public CashOnDeliveryOrderProcessor(IOrderProcessor orderProcessor) 
        { 
            
            _orderProcessor = orderProcessor;

        }


        void validateshippingaddress(IOrderProcessor orderProcessor) 
        {
            orderProcessor.validateshippingaddress();
        
        }





        public void processororder()
        {
            throw new NotImplementedException();
        }
    }
}
