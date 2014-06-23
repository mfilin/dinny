using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;

namespace dinny.Domain {
    
    public class Dish
    {
        public Dish()
        {
            DishNmks = new List<DishNmk>();
        }

        [DisplayName("Код")]
        public virtual int id { get; set; }

        [DisplayName("Наименование")]
        public virtual string name { get; set; }

        [DisplayName("Краткое наименование")]
        public virtual string sname { get; set; }

        [DisplayName("Рецептура")]
        public virtual string recipe { get; set; }

        [DisplayName("Выход")]
        public virtual int outdish { get; set; }

        [DisplayName("Единицы")]
        public virtual Unit unit { get; set; }

        [DisplayName("Техпроцесс")]
        public virtual string tprocess { get; set; }

        public virtual IList<DishNmk> DishNmks { get; set; }
    }
}
