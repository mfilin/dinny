using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;

namespace dinny.Domain {
    
    public class Unit {
        public Unit()
        {
        }

        [DisplayName("���")]
        public virtual int id { get; set; }

        [DisplayName("������������")]
        public virtual string name { get; set; }

        [DisplayName("������� ������������")]
        public virtual string sname { get; set; }

        [DisplayName("��� �� ����")]
        public virtual string idOKEI { get; set; }
    }
}
