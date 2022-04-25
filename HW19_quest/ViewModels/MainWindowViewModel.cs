using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW19_quest.ViewModels
{
    internal class MainWindowViewModel : BindableBase
    {
        //Переменная заголовка окна
        public string Title { get; set; } = "Задание 19";
    }
}
