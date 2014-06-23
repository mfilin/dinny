using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using dinny.Core.Data;

namespace dinny.Domain {
    
    
    public class DishMap : ClassMap<Dish> {

        public DishMap()
        {
            Table("\"ctl_Dish\"");
			LazyLoad();
            Id(x => x.id).GeneratedBy.Sequence("public.\"ctl_dish_id_seq\"");
			Map(x => x.name).Column("name");
			Map(x => x.sname).Column("sname");
            Map(x => x.recipe).Column("recipe");
            Map(x => x.outdish).Column("outdish");
            Map(x => x.tprocess).Column("tprocess");
            References(x => x.unit).Column("rf_idunit").Not.LazyLoad();
            
            HasMany(x => x.DishNmks).KeyColumn("rf_iddish").Not.LazyLoad().Inverse().Cascade.AllDeleteOrphan();
        }
    }

    public partial class DishManager : DomainObject<int, Dish> { }
}
