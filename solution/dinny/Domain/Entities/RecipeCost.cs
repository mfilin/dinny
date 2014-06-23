using System.Collections.Generic; 
using System.Text; 
using System;

namespace dinny.Domain {

    public class RecipeCost
    {
        public RecipeCost() { }
        public virtual long id { get; set; }
        public virtual double cost { get; set; }
        public virtual double summa { get; set; }

        public virtual DishNmk DishNmk { get; set; }
        public virtual Recipe Recipe { get; set; }
    }
}
