using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;

namespace dinny.Domain {
    
    public class Setting {
        public Setting()
        {
        }

        [DisplayName("���")]
        public virtual int id { get; set; }

        [DisplayName("������������")]
        public virtual string name { get; set; }

        [DisplayName("��������")]
        public virtual string value { get; set; }        
    }
}
