using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dinny.Reports.dataview
{
    public class view_rptTCard
    {
        public view_rptTCard() { }

        public virtual int docnum { get; set; }
        public virtual string recipe { get; set; }
        public virtual string name { get; set; }
        public virtual string sname { get; set; }
        public virtual int outdish { get; set; }
        public virtual string tprocess { get; set; }
        public virtual string nmkname { get; set; }
        public virtual double brutto { get; set; }
        public virtual double netto { get; set; }
        public virtual int loss { get; set; }        
    }
}
