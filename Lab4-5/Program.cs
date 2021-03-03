using System;
using System.Collections.Generic;
using System.Linq;

namespace Game
{
  
    enum WarriorType
    {
        Elf, Ogre
    }
    class Program
    {
        static void Main()
        {
            //1
            WarriorFactory warriorFactory = new SwordFactory();
            List<IElf> elves = warriorFactory.CreateElf(4);

            //2
            elves.Add(WarELfLord.getInstance());
            Printer.PrintWarrior(elves);

            //3
            Builder builder = new ConcreteBuilder();
            Director director = new Director(builder);
            director.Construct();
            Castle castle = builder.GetResult();
            Console.WriteLine(castle.ToString());

            //4
            Archer archer = new OgreArcher(7);
            Archer archerClone = archer.Clone();
            Console.WriteLine(archer.Damage + " " + archerClone.Damage);

            archer = new ElfArcher(9);
            archerClone = archer.Clone();
            Console.WriteLine(archer.Damage + " " + archerClone.Damage);

            //1
            SwordElf swordElf = new SwordElf();
            ImprovedSwordElf improvedSwordElf = new Adapter(swordElf);
            improvedSwordElf.Function();
            Console.WriteLine(swordElf.HitPoints + " " + improvedSwordElf.HitPoints);
            //2
            BuildMaterial buildMaterial = new Wood();
            buildMaterial = new WithTiles(buildMaterial);
            Console.WriteLine(buildMaterial.Name + " price: " + buildMaterial.GetCost());

            buildMaterial = new Stone();
            Console.WriteLine(buildMaterial.Name + " price: " + buildMaterial.GetCost());
            buildMaterial = new WithCreepers(buildMaterial);
            Console.WriteLine(buildMaterial.Name + " price: " + buildMaterial.GetCost());

            //3
            Map map = new Map("Europe");
            Country country = new Country("Germany");
            Map subMap = new Map("Baltic");
            Country balticCountry = new Country("Lithuania");
            subMap.AddComponent(balticCountry);
            map.AddComponent(country);
            map.AddComponent(subMap);
            Console.WriteLine();
            var item = map.Find("Lithuania");
            if (item != null)
            {
                item.Draw();
            }
            else
            {
                Console.WriteLine("null");
            }
            Console.WriteLine();
            item = map.Find("Lidgdfg");
            if (item != null)
            {
                item.Draw();
            }
            else
            {
                Console.WriteLine("null");
            }
            Console.WriteLine();
            map.Draw();

            //1
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            JumpCommand jumpCommand = new JumpCommand(receiver);
            invoker.SetCommand(jumpCommand);
            invoker.Run();
            FireCommand fireCommand = new FireCommand(receiver);
            invoker.SetCommand(fireCommand);
            invoker.Run();
            //2
            
            var input = new Input(Console.ReadKey());
            var hero = new MyObject(new Jumping());
            hero.HandleRequest(input);
            hero.GetObjectStatus();
            
            //3
            var improvedSwordOgre = new ImprovedSwordOgre();
            var history = new GameHistory();
            improvedSwordOgre.Injure();
            Console.WriteLine(improvedSwordOgre.HitPoints + " " + improvedSwordOgre.Damage);
            var improvedSwordOgreMemento =
                new ImprovedSwordOgreMemento(improvedSwordOgre.HitPoints, improvedSwordOgre.Damage);
            history.History.Push(improvedSwordOgreMemento);
            improvedSwordOgre.Injure();
            Console.WriteLine(improvedSwordOgre.HitPoints + " " + improvedSwordOgre.Damage);
            //restoring
            improvedSwordOgre.HitPoints = improvedSwordOgreMemento.HitPoints;
            improvedSwordOgre.Damage = improvedSwordOgreMemento.Damage;
            Console.WriteLine(improvedSwordOgre.HitPoints + " " + improvedSwordOgre.Damage);
            
            //4
            Attack attack = new Attack();
            Defender defender1 = new Defender(22, attack);
            Defender defender2 = new Defender(27, attack);
            attack.AddObserver(defender1);
            attack.AddObserver(defender2);
            attack.UpdateStatus();

            //WarriorFactory guardFactory = new GuardsFactory();
            //List<IOgre> ogres = guardFactory.CreateOgre(2);
            var ogre = new GuardOgre();
            ogre.Execute();
            ogre.Damaged(30);
            ogre.Execute();
            ogre.Damaged(50);
            ogre.Execute();
            //ogres.FirstOrDefault().strategy = 

            //foreach(IOgre ogre in ogres)
            //{
            //    ogre.strategy.
            //}

            Console.ReadKey();
        }
    }
}
