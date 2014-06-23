using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dinny.Reports.dataview
{
    public class view_rptDelivery
    {
        public view_rptDelivery() { }

        public virtual long id { get; set; }
        public virtual long docnumber { get; set; }
        public virtual DateTime docdate { get; set; }
        public virtual double quantity { get; set; }
        public virtual string department { get; set; }
        public virtual string nmkname { get; set; }
        public virtual double price { get; set; }
        public virtual double pricep { get; set; }
        public virtual double sumprice { get; set; }
        public virtual double sumpricep { get; set; }
        public virtual double percent { get; set; }
    }
}
