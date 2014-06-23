using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dinny.Reports.dataview
{
    public class view_rptOP1
    {
        public view_rptOP1() {}

        public virtual string person {get; set;}
        public virtual string dish { get; set; }
        public virtual long id { get; set; }
        public virtual long docnum { get; set; }
        public virtual DateTime docdate { get; set; }
        public virtual int quantity { get; set; }
        public virtual double sumcost { get; set; }
        public virtual double onecost { get; set; }
        public virtual double price { get; set; }
        public virtual double pprice { get; set; }
        public virtual double ppercent { get; set; }
        public virtual string nmk { get; set; }
        public virtual int idnmk { get; set; }
        public virtual string nameunit { get; set; }
        public virtual string idokei { get; set; }
        public virtual double cost { get; set; }
        public virtual double brutto { get; set; }
        public virtual double netto { get; set; }
        public virtual double summa { get; set; }
        public virtual double outdish { get; set; }
        public virtual string nameunitdish { get; set; }
    }
}
