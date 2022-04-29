using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW19_quest.Business
{
    class CreatureFactory
    {
        public static ICreature GetWorker(TypeCreature type, string SkinCovers, string Skeleton, string MuscularSystem, string RespiratorySystem, string BloodSystem, string NervousSystem)
        {
            switch (type)
            {
                case TypeCreature.Mammal: return new Mammal(SkinCovers, Skeleton,  MuscularSystem, RespiratorySystem, BloodSystem, NervousSystem);
                case TypeCreature.Amphibia: return new Amphibia(SkinCovers, Skeleton, MuscularSystem, RespiratorySystem, BloodSystem, NervousSystem);
                case TypeCreature.Bird: return new Bird(SkinCovers, Skeleton, MuscularSystem, RespiratorySystem, BloodSystem, NervousSystem);

                default: return new UnknownCreature();
            }
        }

        public enum TypeCreature
        {
            Mammal,
            Amphibia,
            Bird
        }
    }

}
