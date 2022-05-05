using System;
using System.Collections.Generic;

#nullable disable

namespace HW19_quest
{
    public partial class Creature
    {
        public long Id { get; set; }
        public string TypeCreature { get; set; }
        public string Name { get; set; }
        public string SkinCovers { get; set; }
        public string Skeleton { get; set; }
        public string MuscularSystem { get; set; }
        public string RespiratorySystem { get; set; }
        public string NervousSystem { get; set; }

        public Creature(
            string TypeCreature, 
            string Name, 
            string SkinCovers, 
            string Skeleton, 
            string MuscularSystem,
            string RespiratorySystem, 
            string NervousSystem)
        {
            this.TypeCreature = TypeCreature;
            this.Name = Name;
            this.SkinCovers = SkinCovers;
            this.Skeleton = Skeleton;
            this.MuscularSystem = MuscularSystem;
            this.RespiratorySystem = RespiratorySystem;
            this.NervousSystem = NervousSystem;
        }

        public override string ToString()
        {
            return $"{this.Id}  {this.TypeCreature} {this.Name} {this.SkinCovers} {this.Skeleton} {this.MuscularSystem} {this.RespiratorySystem} {this.NervousSystem}";
        }
    }
}
