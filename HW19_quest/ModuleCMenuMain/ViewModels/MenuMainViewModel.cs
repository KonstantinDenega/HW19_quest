using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HW19_quest.ModuleCMenuMain.ViewModels
{
    class MenuMainViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;
        protected readonly IEventAggregator _eventAggregator;

        public DelegateCommand BtnExit { get; set; }
        public DelegateCommand BtnHistory { get; set; }


        public MenuMainViewModel(RegionManager regionManager, IEventAggregator eventAggregator)
        {
            _regionManager = regionManager;
            _eventAggregator = eventAggregator;

            BtnExit = new DelegateCommand(MetBtnExit);
            BtnHistory = new DelegateCommand(MetBtnHistory);
        }

        private void MetBtnHistory()
        {
            //_eventAggregator.GetEvent<EventText>().Publish("LogMan");
        }

        private void MetBtnExit()
        {
            Application.Current.Shutdown();
        }

    }
}
