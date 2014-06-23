using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using dinny.Core.Data;

namespace dinny.Domain {    
    
    public class PersonMap : ClassMap<Person>
    {
        public PersonMap()
        {
			Table("\"ctl_Person\"");
			LazyLoad();
            Id(x => x.id).GeneratedBy.Sequence("public.\"ctl_person_id_seq\"");
            Map(x => x.name).Column("name").Not.Nullable();
            Map(x => x.parent).Column("parent");
            Map(x => x.parentid).Column("parentid").ReadOnly();
            Map(x => x.inn).Column("inn").Nullable();
            Map(x => x.kpp).Column("kpp").Nullable();

            HasMany(x => x.Children)
                .Cascade.AllDeleteOrphan()
                .Inverse() //if this is not inverse, then NHibernate inserts then updates
                .KeyColumn("ParentId").ForeignKeyConstraintName("fk_ctl_person_parent")
                .Access.ReadOnlyPropertyThroughCamelCaseField(Prefix.Underscore)
                .Fetch.Subselect()
                .Not.LazyLoad();

            References(x => x.Parent)
                .Column("ParentId").ForeignKey("fk_ctl_person_parent"); //Could be Not Null if referenced a different table
        }
    }

    public partial class PersonManager : DomainObject<int, Person> { }
}
