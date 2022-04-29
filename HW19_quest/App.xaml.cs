using HW19_quest.ModuleACreature;
using HW19_quest.ModuleCMenuMain;
using HW19_quest.ModuleDStatus;
using HW19_quest.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HW19_quest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.Register<ICustomerStore, DbCustomerStore>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ModuleMenuMain>();
            moduleCatalog.AddModule<ModuleCreature>();
            moduleCatalog.AddModule<ModuleStatus>();
        }
    }
}
