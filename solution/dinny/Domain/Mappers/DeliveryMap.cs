using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using dinny.Core.Data;

namespace dinny.Domain {
    
    
    public class DeliveryMap : ClassMap<Delivery> {
        
        public DeliveryMap() {
			Table("public.\"doc_Delivery\"");
			LazyLoad();
            Id(x => x.id).GeneratedBy.Sequence("public.\"doc_delivery_id_seq\"");
            Map(x => x.docnumber).Column("docnumber");
			Map(x => x.docdate).Column("docdate");
            Map(x => x.department).Column("department");
			
            HasMany(x => x.DeliveryCosts).KeyColumn("rf_iddelivery").Not.LazyLoad().Inverse().Cascade.AllDeleteOrphan();
        }
    }
    
    public partial class DeliveryManager : DomainObject<int, Delivery> { }
}
