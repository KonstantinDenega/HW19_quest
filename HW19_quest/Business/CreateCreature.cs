using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW19_quest.Business
{
    public class CreateCreature
    {
        public ICreature Create(TypeCreature temp)
        {
            ICreatureFactory factory = new ConcreteCreatureFactory();
            ICreature tempCreatures;
            switch (temp)
            {
                case TypeCreature.Mammal:
                    tempCreatures = factory.GetCreature(temp);
                    return tempCreatures;
                    break;

                case TypeCreature.Amphibia:
                    tempCreatures = factory.GetCreature(temp);
                    return tempCreatures;
                    break;

                case TypeCreature.Bird:
                    tempCreatures = factory.GetCreature(temp);
                    return tempCreatures;
                    break;

                case TypeCreature.Unknown:
                    tempCreatures = factory.GetCreature(temp);
                    return tempCreatures;
                    break;

                default:
                    tempCreatures = factory.GetCreature(temp);
                    return tempCreatures;
            }
        }
    }
}
