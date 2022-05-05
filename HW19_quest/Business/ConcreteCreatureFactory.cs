using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW19_quest.Business
{
    class ConcreteCreatureFactory: ICreatureFactory
    {
        public ICreature GetCreature(TypeCreature TypeCreature)
        {
            switch (TypeCreature)
            {
                case TypeCreature.Mammal: return new Mammal();
                case TypeCreature.Amphibia: return new Amphibia();
                case TypeCreature.Bird: return new Bird();
                case TypeCreature.Unknown: return new UnknownCreature();
                default: return new UnknownCreature();
            }
        }
    }
}
