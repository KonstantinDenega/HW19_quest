using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW19_quest.Business
{
    interface ICreatureFactory
    {
        ICreature GetCreature(string TypeCreature, string Name, string SkinCovers, string Skeleton, string MuscularSystem, string RespiratorySystem, string BloodSystem, string NervousSystem);
    }
}
