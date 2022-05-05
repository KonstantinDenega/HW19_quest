using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW19_quest.Business
{
    internal class Amphibia: ICreature
    {
        #region Свойства
        public string SkinCovers { get; set; }
        public string Skeleton { get; set; }
        public string MuscularSystem { get; set; }
        public string RespiratorySystem { get; set; }
        public string NervousSystem { get; set; }
        #endregion

        public Amphibia()
        {
            this.SkinCovers = "Amphibia_SkinCovers";
            this.Skeleton = "Amphibia_Skeleton";
            this.MuscularSystem = "Amphibia_MuscularSystem";
            this.RespiratorySystem = "Amphibia_RespiratorySystem";
            this.NervousSystem = "Amphibia_NervousSystem";
        }

        public override string ToString()
        {
            return $"{this.SkinCovers} {this.Skeleton} {this.MuscularSystem} {this.RespiratorySystem} {this.NervousSystem}";
        }
    }
}
