using HW19_quest.ModuleDStatus.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW19_quest.ModuleDStatus
{
    class ModuleStatus : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("StatusRegion", typeof(Status));

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}
