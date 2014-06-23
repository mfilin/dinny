using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using dinny.Core.Data;

namespace dinny.Domain {
    
    
    public class UnitMap : ClassMap<Unit> {
        
        public UnitMap()
        {
            Table("\"ctl_Unit\"");
			LazyLoad();
            Id(x => x.id).GeneratedBy.Sequence("public.\"ctl_unit_id_seq\"");
			Map(x => x.name).Column("name");
			Map(x => x.sname).Column("sname");
            Map(x => x.idOKEI).Column("idOKEI");
        }
    }

    public partial class UnitManager : DomainObject<int, Unit> { }
}
