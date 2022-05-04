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
        public DelegateCommand BtnExit { get; set; }

        public MenuMainViewModel()
        {
            BtnExit = new DelegateCommand(MetBtnExit);
        }

        private void MetBtnExit()
        {
            Application.Current.Shutdown();
        }

    }
}
