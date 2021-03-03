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
            builder.BuildBasement();
            builder.BuildWalls();
            builder.BuildRoof();
        }
    }

    abstract class Builder
    {
        public abstract void BuildBasement();
        public abstract void BuildWalls();
        public abstract void BuildRoof();
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
        public override void BuildBasement()
        {
            castle.Add("basement");
        }
        public override void BuildWalls()
        {
            castle.Add("walls");
        }
        public override void BuildRoof()
        {
            castle.Add("roof");
        }
        public override Castle GetResult()
        {
            return castle;
        }
    }
}
