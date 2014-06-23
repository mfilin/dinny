using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using dinny.Core.Data;

namespace dinny.Domain {    
    
    public class NmkMap : ClassMap<Nmk>
    {
        public NmkMap()
        {
			Table("\"ctl_Nmk\"");
			LazyLoad();
            Id(x => x.id).GeneratedBy.Sequence("public.\"ctl_nmk_id_seq\"");
            Map(x => x.name).Column("name").Not.Nullable();
            Map(x => x.parent).Column("parent");
            Map(x => x.parentid).Column("parentid").ReadOnly();
            References(x => x.unit).Column("rf_idUnit").Not.LazyLoad();

            HasMany(x => x.Children)
                .Cascade.AllDeleteOrphan()
                .Inverse() //if this is not inverse, then NHibernate inserts then updates
                .KeyColumn("ParentId").ForeignKeyConstraintName("fk_ctl_nmk_parent")
                .Access.ReadOnlyPropertyThroughCamelCaseField(Prefix.Underscore)
                .Fetch.Subselect()
                .Not.LazyLoad();

            References(x => x.Parent)
                .Column("ParentId").ForeignKey("fk_ctl_nmk_parent"); //Could be Not Null if referenced a different table
        }
    }
    
    public partial class NmkManager : DomainObject<int, Nmk> { }
}
