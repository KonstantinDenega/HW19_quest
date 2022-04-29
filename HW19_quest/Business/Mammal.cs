using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW19_quest.Business
{
    internal class Mammal: ICreature
    {
        #region Свойства
        public string Name { get; set; }
        public string SkinCovers { get; set; }
        public string Skeleton { get; set; }
        public string MuscularSystem { get; set; }
        public string RespiratorySystem { get; set; }
        public string BloodSystem { get; set; }
        public string NervousSystem { get; set; }
        #endregion

        public Mammal(string Name, string SkinCovers, string Skeleton, string MuscularSystem, string RespiratorySystem, string BloodSystem, string NervousSystem)
        {
            this.Name = Name;
            this.SkinCovers = SkinCovers;
            this.Skeleton = Skeleton;
            this.MuscularSystem = MuscularSystem;
            this.RespiratorySystem = RespiratorySystem;
            this.BloodSystem = BloodSystem;
            this.NervousSystem = NervousSystem;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.SkinCovers} {this.Skeleton} {this.MuscularSystem} {this.RespiratorySystem} {this.BloodSystem} {this.NervousSystem}";
        }
    }
}
