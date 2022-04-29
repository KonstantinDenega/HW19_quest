using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW19_quest.Business
{
    class UnknownCreature : ICreature
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

        public UnknownCreature()
        {
            this.Name = "Not Determined";
            this.SkinCovers = "Not Determined";
            this.Skeleton = "Not Determined";
            this.MuscularSystem = "Not Determined";
            this.RespiratorySystem = "Not Determined";
            this.BloodSystem = "Not Determined";
            this.NervousSystem = "Not Determined";
        }

        public override string ToString()
        {
            return $"{this.Name} {this.SkinCovers} {this.Skeleton} {this.MuscularSystem} {this.RespiratorySystem} {this.BloodSystem} {this.NervousSystem}";
        }
    }
}
