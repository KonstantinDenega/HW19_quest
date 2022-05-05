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
        public string SkinCovers { get; set; }
        public string Skeleton { get; set; }
        public string MuscularSystem { get; set; }
        public string RespiratorySystem { get; set; }
        public string NervousSystem { get; set; }
        #endregion

        public Mammal()
        {
            this.SkinCovers = "Mammal_SkinCovers";
            this.Skeleton = "Mammal_Skeleton";
            this.MuscularSystem = "Mammal_MuscularSystem";
            this.RespiratorySystem = "Mammal_RespiratorySystem";
            this.NervousSystem = "Mammal_NervousSystem";
        }

        public override string ToString()
        {
            return $"{this.SkinCovers} {this.Skeleton} {this.MuscularSystem} {this.RespiratorySystem} {this.NervousSystem}";
        }
    }
}
