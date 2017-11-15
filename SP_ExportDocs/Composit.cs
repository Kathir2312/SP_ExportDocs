using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_ExportDocs
{

    //Composite pattern for hierarchy object
    //GOF


    public abstract class Component
    {
        //protected string name;
        Guid Id;
        string Name;
        string Path;
        bool hasChild;
        int _wssid;
        public Component(Guid Id, string pName, string Path)
        {
            this.Id = Id;
            this.Name = pName;
            this.Path = Path;
        }
        public int wssid { get { return _wssid; } set { _wssid = value; } }

        public string PropName { get { return this.Name; } }
        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
        public abstract Component Traverse();
    }

    public class Composite : Component
    {
        public List<Component> CMChilds { get { return this._children; }}

        
        private List<Component> _children = new List<Component>();

        // Constructor
        public Composite(Guid Id, string Name, string Path)
          : base(Id, Name, Path)
        {
        }

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + PropName);

            // Recursively display child nodes
            foreach (Component component in _children)
            {
                component.Display(depth + 2);
            }
        }

        public override Component Traverse()
        {
            foreach (Component item in this._children)
            {
                item.Traverse();
            }
            return null;
        }
    }

    public class Leaf : Component
    {
        // Constructor
        public Leaf(Guid Id, string Name, string Path)
          : base(Id, Name, Path)
        {
        }

        public override void Add(Component c)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + PropName);
        }

        public override Component Traverse() {
            return this;
        }

    }
}
