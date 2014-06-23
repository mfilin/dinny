using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;

namespace dinny.Domain {
    
    public class Setting {
        public Setting()
        {
        }

        [DisplayName("Код")]
        public virtual int id { get; set; }

        [DisplayName("Наименование")]
        public virtual string name { get; set; }

        [DisplayName("Значение")]
        public virtual string value { get; set; }        
    }
}
