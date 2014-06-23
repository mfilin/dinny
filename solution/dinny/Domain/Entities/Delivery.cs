using System.Collections.Generic; 
using System.Text; 
using System; 


namespace dinny.Domain {
    
    public class Delivery {
        public Delivery() {
			DeliveryCosts = new List<DeliveryCost>();
        }
        public virtual int id { get; set; }
        
        public virtual int docnumber { get; set; }
        public virtual System.DateTime docdate { get; set; }
        public virtual string department { get; set; }

        public virtual IList<DeliveryCost> DeliveryCosts { get; set; }
    }
}
