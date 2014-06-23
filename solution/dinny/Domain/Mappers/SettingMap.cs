using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using dinny.Core.Data;

namespace dinny.Domain {
    
    
    public class SettingMap : ClassMap<Setting> {

        public SettingMap()
        {
            Table("\"ctl_Setting\"");
			LazyLoad();
            Id(x => x.id).GeneratedBy.Sequence("public.\"ctl_setting_id_seq\"");
			Map(x => x.name).Column("name");
            Map(x => x.value).Column("value");
        }
    }

    public partial class SettingManager : DomainObject<int, Setting> { }
}
