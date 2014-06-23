using System;
using Iesi.Collections.Generic;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace dinny.Domain {
    
    public class Nmk
    {
        [DisplayName("Код")]
        public virtual int id { get; set; }

        [DisplayName("Наименование")]
        public virtual string name { get; set; }       

        [DisplayName("Единицы измерения")]
        public virtual Unit unit { get; set; }

        #region -------------- организация иерархии --------------

        public virtual bool? parent { get; set; }
        public virtual int? parentid { get; set; }

        protected readonly ICollection<Nmk> _children;
        protected Nmk()
        {
            _children = new Collection<Nmk>();
        }

        public Nmk(string name)
            : this()
        {
            this.name = name;
        }

        public Nmk(string name, Nmk parent)
            : this(name)
        {
            if (parent == null) throw new ArgumentNullException("parent");
            parent.AddChild(this);
        }

        public virtual int? Id { get; protected set; }
        public virtual string Name { get; set; }

        public virtual IEnumerable<Nmk> Children
        {
            get { return _children; }
        }

        public virtual void AddChild(Nmk child)
        {
            if (this.Parent != null) this.parent = true; // ставим пометку на родителя
            child.Parent = this;
            _children.Add(child);
        }

        public virtual int ChildCount()
        {
            return (this.Children == null) ? 0 : this._children.Count;
        }

        public virtual Nmk Parent { get; protected set; }        
        #endregion
    }
}
