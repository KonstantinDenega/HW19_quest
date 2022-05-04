using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW19_quest.Business
{
    class ConcreteCreatureFactory: ICreatureFactory
    {


        public ICreature GetCreature(string TypeCreature, string Name, string SkinCovers, string Skeleton, string MuscularSystem, string RespiratorySystem, string BloodSystem, string NervousSystem)
        {
            switch (TypeCreature)
            {
                case "Mammal": return new Mammal(Name, SkinCovers, Skeleton, MuscularSystem, RespiratorySystem, BloodSystem, NervousSystem);
                case "Amphibia": return new Amphibia(Name, SkinCovers, Skeleton, MuscularSystem, RespiratorySystem, BloodSystem, NervousSystem);
                case "Bird": return new Bird(Name, SkinCovers, Skeleton, MuscularSystem, RespiratorySystem, BloodSystem, NervousSystem);

                default: return new UnknownCreature();
            }
        }

    }
}
