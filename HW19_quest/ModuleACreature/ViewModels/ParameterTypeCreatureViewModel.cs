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

        Dictionary<TypeCreature, string> DictionaryCreature;

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


            DictionaryCreature = new Dictionary<TypeCreature, string>()
            { 
                {TypeCreature.Mammal, "Млекопитающие" },
                {TypeCreature.Bird,"Птицы"},
                {TypeCreature.Amphibia,"Земноводные"}
            };

        }

        private void MetSelectedTypeCreature(TypeCreature obj)
        {
            CreateCreature(obj);
        }

        private void CreateCreature(TypeCreature temp)
        {
            
            TempCreature = new ObservableCollection<ICreature>();
            ICreatureFactory factory = new ConcreteCreatureFactory();
            ICreature tempMaman;
            switch (temp)
            {
                case TypeCreature.Mammal:
                    tempMaman = factory.GetCreature(temp);
                    TempCreature.Add(tempMaman);
                    break;

                case TypeCreature.Amphibia:
                    tempMaman = factory.GetCreature(temp);
                    TempCreature.Add(tempMaman);
                    break;

                case TypeCreature.Bird:
                    tempMaman = factory.GetCreature(temp);
                    TempCreature.Add(tempMaman);
                    break;

                default:
                    tempMaman = factory.GetCreature(temp);
                    TempCreature.Add(tempMaman);
                    break;
            }
        }

    }
}
