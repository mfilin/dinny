using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using dinny.Core.Data;

namespace dinny.Domain {   
    
    public class RecipeMap : ClassMap<Recipe> {
        
        public RecipeMap()
        {			
            Table("\"doc_Recipe\"");
			LazyLoad();
            Id(x => x.id).GeneratedBy.Sequence("public.\"doc_recipe_id_seq\"");

			Map(x => x.sumcost).Column("sumcost");
			Map(x => x.onecost).Column("onecost");
            Map(x => x.price).Column("price");			
			Map(x => x.ppercent).Column("ppercent");
			Map(x => x.quantity).Column("quantity");
            Map(x => x.docnumber).Column("docnumber");
            Map(x => x.docdate).Column("docdate");
			
            References(x => x.Org).Column("rf_idorg").Not.LazyLoad();
            References(x => x.Dish).Column("rf_iddish").Not.LazyLoad();

            HasMany(x => x.RecipeCosts).KeyColumn("rf_idrecipe").Not.LazyLoad().Inverse().Cascade.AllDeleteOrphan();
        }
    }
    
    public partial class RecipeManager : DomainObject<int, Recipe> { }
}
