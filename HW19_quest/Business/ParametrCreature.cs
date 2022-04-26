using System;
using System.Collections.Generic;

#nullable disable

namespace HW19_quest
{
    public partial class ParametrCreature
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
