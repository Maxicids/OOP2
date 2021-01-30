using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    abstract class BuildMaterial
    {
        public BuildMaterial(string name)
        {
            this.Name = name;
        }
        public string Name { get; protected set; }
        public abstract int GetCost();
    }

    class Wood : BuildMaterial
    {
        public Wood() : base("Wood")
        { }
        public override int GetCost()
        {
            return 2;
        }
    }
    class Stone : BuildMaterial
    {
        public Stone(): base("Stone")
        { }
        public override int GetCost()
        {
            return 4;
        }
    }

    abstract class BuildMaterialDecorator : BuildMaterial
    {
        protected BuildMaterial buildMaterial;
        public BuildMaterialDecorator(string name, BuildMaterial buildMaterial) : base(name)
        {
            this.buildMaterial = buildMaterial;
        }
    }

    class WithCreepers : BuildMaterialDecorator
    {
        public WithCreepers(BuildMaterial buildMaterial) : base(buildMaterial.Name + " with creepers", buildMaterial)
        { }

        public override int GetCost()
        {
            return buildMaterial.GetCost() + 2;
        }
    }

    class WithTiles : BuildMaterialDecorator
    {
        public WithTiles(BuildMaterial buildMaterial) : base(buildMaterial.Name + " with tiles", buildMaterial)
        { }

        public override int GetCost()
        {
            return buildMaterial.GetCost() + 5;
        }
    }
}
