using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Director
    {
        Builder builder;
        public Director(Builder builder)
        { 
            this.builder = builder;
        }
        public void Construct()
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();
        }
    }

    abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract void BuildPartC();
        public abstract Castle GetResult();
    }

    class Castle
    {
        List<object> parts = new List<object>();
        public void Add(string part)
        {
            parts.Add(part);
        }
        public override string ToString()
        {
            string str = "";
            foreach (object obj in parts)
            {
                str += obj.ToString();
                str += " ";
            }
            return str;
        }
    }

    class ConcreteBuilder : Builder
    {
        Castle castle = new Castle();
        public override void BuildPartA()
        {
            castle.Add("basement");
        }
        public override void BuildPartB()
        {
            castle.Add("walls");
        }
        public override void BuildPartC()
        {
            castle.Add("roof");
        }
        public override Castle GetResult()
        {
            return castle;
        }
    }
}
