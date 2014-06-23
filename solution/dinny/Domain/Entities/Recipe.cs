using System.Collections.Generic; 
using System.Text; 
using System; 

namespace dinny.Domain {
    
    public class Recipe
    {
        public Recipe()
        {
			RecipeCosts = new List<RecipeCost>();
        }
        public virtual long id { get; set; }        
        public virtual double sumcost { get; set; }
        public virtual double onecost { get; set; }
        public virtual double price { get; set; }
        public virtual double ppercent { get; set; }
        public virtual int quantity { get; set; }

        public virtual double docnumber { get; set; }
        public virtual DateTime docdate { get; set; }

        public virtual Dish Dish { get; set; }
        public virtual Person Org { get; set; }
        
        public virtual IList<RecipeCost> RecipeCosts { get; set; }
    }
}
