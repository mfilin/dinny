using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using dinny.Core.Data;

namespace dinny.Domain
{        
    public class RecipeCostMap : ClassMap<RecipeCost>
    {        
        public RecipeCostMap()
        {
			Table("\"doc_RecipeCost\"");
			LazyLoad();
			Id(x => x.id).GeneratedBy.Sequence("public.\"doc_recipecost_id_seq\"");
            Map(x => x.cost).Column("cost");
            Map(x => x.summa).Column("summa");
			References(x => x.DishNmk).Column("rf_iddishNmk").Not.LazyLoad();
            References(x => x.Recipe).Column("rf_idrecipe").Not.LazyLoad();
        }
    }
    
    public partial class RecipeCostManager : DomainObject<int, RecipeCost> { }
}
