using System;
using Iesi.Collections.Generic;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace dinny.Domain {
    
    public class Person
    {
        [DisplayName("���")]
        public virtual int id { get; set; }

        [DisplayName("������������")]
        public virtual string name { get; set; }

        [DisplayName("���")]
        public virtual string inn { get; set; }

        [DisplayName("���")]
        public virtual string kpp { get; set; }

        #region -------------- ����������� �������� --------------

        public virtual bool? parent { get; set; }
        public virtual int? parentid { get; set; }

        protected readonly ICollection<Person> _children;
        protected Person()
        {
            _children = new Collection<Person>();
        }

        public Person(string name)
            : this()
        {
            this.name = name;
        }

        public Person(string name, Person parent)
            : this(name)
        {
            if (parent == null) throw new ArgumentNullException("parent");
            parent.AddChild(this);
        }

        public virtual int? Id { get; protected set; }
        public virtual string Name { get; set; }

        public virtual IEnumerable<Person> Children
        {
            get { return _children; }
        }

        public virtual void AddChild(Person child)
        {
            if (this.Parent != null) this.parent = true; // ������ ������� �� ��������
            child.Parent = this;
            _children.Add(child);
        }

        public virtual int ChildCount()
        {
            return (this.Children == null) ? 0 : this._children.Count;
        }

        public virtual Person Parent { get; protected set; }        
        #endregion
    }
}
