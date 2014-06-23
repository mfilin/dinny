using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;

namespace dinny.Domain {
    
    public class Unit {
        public Unit()
        {
        }

        [DisplayName("Код")]
        public virtual int id { get; set; }

        [DisplayName("Наименование")]
        public virtual string name { get; set; }

        [DisplayName("Краткое наименование")]
        public virtual string sname { get; set; }

        [DisplayName("Код по ОКЕИ")]
        public virtual string idOKEI { get; set; }
    }
}
