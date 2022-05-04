using HW19_quest.Business;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static HW19_quest.Events.Event;

namespace HW19_quest.ModuleACreature.ViewModels
{
    class ParameterTypeCreatureViewModel : BindableBase
    {
        protected readonly IEventAggregator _eventAggregator;
        private readonly IRegionManager _regionManager;


        private ObservableCollection<ICreature> tempCreature;
        public ObservableCollection<ICreature> TempCreature
        {
            get { return tempCreature; }
            set { SetProperty(ref tempCreature, value); }
        }

        public ParameterTypeCreatureViewModel(IRegionManager regionManager, IEventAggregator eventAggregator)
        {
            _regionManager = regionManager;
            _eventAggregator = eventAggregator;

            _eventAggregator.GetEvent<EventTypeCreature>().Subscribe(MetSelectedTypeCreature);
        }

        private void MetSelectedTypeCreature(TypeCreature obj)
        {
            CreateCreature(obj.ToString());
        }

        private void CreateCreature(string temp)
        {
            TempCreature = new ObservableCollection<ICreature>();
            ICreatureFactory factory = new ConcreteCreatureFactory();
            ICreature tempMaman;
            switch (temp)
            {
                case "Mammal":
                    tempMaman = factory.GetCreature(temp, "Name_1", "SkinCovers_1", "Skeleton_1", "MuscularSystem_1", "RespiratorySystem_1", "BloodSystem_1", "NervousSystem_1");
                    TempCreature.Add(tempMaman);
                    break;

                case "Amphibia":
                    tempMaman = factory.GetCreature(temp, "Name_2", "SkinCovers_2", "Skeleton_2", "MuscularSystem_2", "RespiratorySystem_2", "BloodSystem_2", "NervousSystem_2");
                    TempCreature.Add(tempMaman);
                    break;

                case "Bird":
                    tempMaman = factory.GetCreature(temp, "Name_3", "SkinCovers_3", "Skeleton_3", "MuscularSystem_3", "RespiratorySystem_3", "BloodSystem_3", "NervousSystem_3");
                    TempCreature.Add(tempMaman);
                    break;
                case "Unknown":
                    tempMaman = factory.GetCreature(temp, "Name_3", "SkinCovers_3", "Skeleton_3", "MuscularSystem_3", "RespiratorySystem_3", "BloodSystem_3", "NervousSystem_3");
                    TempCreature.Add(tempMaman);
                    break;
            }
        }

    }
}
