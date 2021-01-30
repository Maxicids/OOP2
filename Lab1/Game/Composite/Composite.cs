using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game
{
    public interface IComponent
    {
        string Title { get; set; }
        void Draw();
        IComponent Find(string title);
    }

    public class Map : IComponent //Composite
    {
        private readonly List<IComponent> map = new List<IComponent>();
        public string Title { get; set; }
        public Map(string title)
        {
            this.Title = title;
        }
        public void AddComponent(IComponent component)
        {
            map.Add(component);
        }
        public void RemoveComponent(IComponent component)
        {
            map.Remove(component);
        }
        public IComponent Find(string title)
        {
            if (this.Title == title)
            {
                return this;
            }
            //if (this is Country)
            //{
            //    if (this.Title == title)
            //    {
            //        return this;
            //    }
            //}
            if (this is Map)
            {
                foreach (IComponent component in this.map)
                {
                    var result = component.Find(title);
                    if (result != null)
                    {
                        return result;
                    }
                }
            }
            
            return null;
            //return map.Where(x => x.Title == title).FirstOrDefault();
        }

        public virtual void Draw()
        {
            Console.WriteLine(this.Title);
            foreach (IComponent component in map)
            {
                component.Draw();
            }
            Console.WriteLine();
        }
    }

    class Country : Map
    {
        public Country(string title) : base(title)
        {
            
        }
        public override void Draw()
        {
            Console.WriteLine(this.Title);
        }
    }
}
