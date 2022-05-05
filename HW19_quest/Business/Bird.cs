using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW19_quest.Business
{
    internal class Bird : ICreature
    {
        #region Свойства
        public string SkinCovers { get; set; }
        public string Skeleton { get; set; }
        public string MuscularSystem { get; set; }
        public string RespiratorySystem { get; set; }
        public string NervousSystem { get; set; }
        #endregion

        public Bird()
        {
            this.SkinCovers = "Bird_SkinCovers";
            this.Skeleton = "Bird_Skeleton";
            this.MuscularSystem = "Bird_MuscularSystem";
            this.RespiratorySystem = "Bird_RespiratorySystem";
            this.NervousSystem = "Bird_NervousSystem";
        }

        public override string ToString()
        {
            return $"{this.SkinCovers} {this.Skeleton} {this.MuscularSystem} {this.RespiratorySystem} {this.NervousSystem}";
        }
    }
}
