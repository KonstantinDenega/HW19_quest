using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW19_quest.Business
{
    public class CreateCreature: BindableBase
    {
        private ObservableCollection<ICreature> tempCreature;
        public ObservableCollection<ICreature> TempCreature
        {
            get { return tempCreature; }
            set { SetProperty(ref tempCreature, value); }
        }

        public CreateCreature()
        {
            TempCreature = new ObservableCollection<ICreature>();
            ICreatureFactory factory = new ConcreteCreatureFactory();
            ICreature tempMaman = factory.GetCreature("Mammal", "Name_1", "SkinCovers_1", "Skeleton_1", "MuscularSystem_1", "RespiratorySystem_1", "BloodSystem_1", "NervousSystem_1");
            TempCreature.Add(tempMaman);
        }
    }
}
