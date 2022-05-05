using HW19_quest.ModuleACreature.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW19_quest.ModuleACreature
{
    class ModuleCreature : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("ModuleRegion", typeof(ShowTypeCreature));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<AddCreature>();
            containerRegistry.RegisterForNavigation<EditCreature>();  
        }
    }
}
