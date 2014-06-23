using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace dinny.Domain {
    
    
    public class VolumeMap : ClassMap<Volume> {
        
        public VolumeMap()
        {
			Table("\"ctl_Volume\"");
			LazyLoad();
			Id(x => x.id).GeneratedBy.Sequence("public.\"ctl_volume_id_seq\"");
			Map(x => x.name).Column("name");
			Map(x => x.sname).Column("sname");
        }
    }
}
