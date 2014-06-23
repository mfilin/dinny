using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using dinny.Core.Data;

namespace dinny.Domain {
    
    
    public class DeliveryCostMap : ClassMap<DeliveryCost> {
        
        public DeliveryCostMap() {
			Table("\"doc_DeliveryCost\"");
			LazyLoad();
			Id(x => x.id).GeneratedBy.Sequence("public.\"doc_deliverycost_id_seq\"");
            Map(x => x.quantity).Column("quantity");
            Map(x => x.price).Column("price");
            Map(x => x.pricep).Column("pricep");			
			
            References(x => x.Nmk).Column("rf_nmkid").Not.LazyLoad();
            References(x => x.Unit).Column("rf_unitid").Not.LazyLoad();
            References(x => x.Delivery).Column("rf_iddelivery").Not.LazyLoad();
        }
    }
    
    public partial class DeliveryCostManager : DomainObject<int, DeliveryCost> { }
}
