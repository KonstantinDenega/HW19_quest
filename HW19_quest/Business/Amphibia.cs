using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW19_quest.Business
{
    internal class Amphibia: ICreature
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long IdtypeCreature { get; set; }
        public string SkinCovers { get; set; }
        public string Skeleton { get; set; }
        public string MuscularSystem { get; set; }
        public string RespiratorySystem { get; set; }
        public string BloodSystem { get; set; }
        public string NervousSystem { get; set; }
    }
}
