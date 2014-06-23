using System.Collections.Generic; 
using System.Text; 
using System;
using dinny.Core.Data;

namespace dinny.Domain
{    
    public class DishNmk
    {
        public DishNmk() { }

        public virtual long id { get; set; }
        public virtual int loss { get; set; }
        public virtual double netto { get; set; }
        public virtual double brutto { get; set; }
        public virtual double result { get{return netto / loss; } }

        public virtual Nmk nmk { get; set; }
        public virtual Dish dish { get; set; }
    }
}
