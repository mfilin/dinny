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

        [DisplayName("���")]
        public virtual int id { get; set; }

        [DisplayName("������������")]
        public virtual string name { get; set; }

        [DisplayName("������� ������������")]
        public virtual string sname { get; set; }

        [DisplayName("���������")]
        public virtual string recipe { get; set; }

        [DisplayName("�����")]
        public virtual int outdish { get; set; }

        [DisplayName("�������")]
        public virtual Unit unit { get; set; }

        [DisplayName("����������")]
        public virtual string tprocess { get; set; }

        public virtual IList<DishNmk> DishNmks { get; set; }
    }
}
