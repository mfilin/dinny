using System.Collections.Generic; 
using System.Text; 
using System;
using System.ComponentModel; 

namespace dinny.Domain {
    
    public class DeliveryCost {
        public DeliveryCost() { }
        public virtual int id { get; set; }

        [DisplayName("Количество")]
        public virtual decimal quantity { get; set; }
        [DisplayName("Цена поставки")]
        public virtual decimal price { get; set; }
        [DisplayName("Цена продажи")]
        public virtual decimal pricep { get; set; }

        public virtual Unit Unit { get; set; }
        public virtual Nmk Nmk { get; set; }
        public virtual Delivery Delivery { get; set; }
    }
}
