using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using dinny.Core.Data;

namespace dinny.Domain {    
    
    public class DishNmkMap : ClassMap<DishNmk> {
        
        public DishNmkMap() {
            Table("public.\"ctl_DishNmk\"");
			LazyLoad();
            Id(x => x.id).GeneratedBy.Sequence("public.\"ctl_dishnmk_id_seq\"");
			Map(x => x.loss).Column("loss");
			Map(x => x.netto).Column("netto");
			Map(x => x.brutto).Column("brutto");
            References(x => x.nmk).Column("rf_idnmk").Not.LazyLoad();
            References(x => x.dish).Column("rf_iddish").Not.LazyLoad();
        }
    }
    
    public partial class DishNmkManager : DomainObject<int, DishNmk> {
    }
}
