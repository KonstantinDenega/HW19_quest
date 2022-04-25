using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HW19_quest.ViewModels
{
    internal class LoginViewModel : BindableBase
    {
        //Переменная заголовка окна
        public string Title { get; set; } = "Задание 19";

        public DelegateCommand<object> BtnAuthentication { get; private set; }

        private readonly IRegionManager _regionManager;


        public LoginViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            BtnAuthentication = new DelegateCommand<object>(MetBtnAuthentication).ObservesCanExecute(() => IsEnabled);
        }

        /// <summary>
        /// Метод авторизации в программу
        /// </summary>
        /// <param name="obj"></param>
        private void MetBtnAuthentication(object obj)
        {
            Window window = obj as Window;

            if (comboBoxAuthentication == String.Empty)
            {
                MessageBox.Show("Не выбрана роль");
            }

            //if (comboBoxAuthentication == "Консультант")
            //{
            //    _regionManager.RequestNavigate("ModuleRegion", "ListConControl");
            //    _regionManager.RequestNavigate("MenuMainRegion", "MenuMainCon");
            //    window.DialogResult = true;
            //}

            if (comboBoxAuthentication == "Менеджер")
            {
                _regionManager.RequestNavigate("ModuleRegion", "Manager");
                _regionManager.RequestNavigate("MenuMainRegion", "MenuMainMan");
                window.DialogResult = true;
            }
        }

        #region Свойства полей ввода Авторизации

        private bool _isEnabled = true;
        /// <summary>
        /// Блокировка кнопки
        /// </summary>
        public bool IsEnabled
        {
            get { return _isEnabled; }
            set
            {
                SetProperty(ref _isEnabled, value);
                BtnAuthentication.RaiseCanExecuteChanged();
            }
        }

        private string comboBoxAuthentication;
        public string ComboBoxAuthentication
        {
            get { return comboBoxAuthentication; }
            set { SetProperty(ref comboBoxAuthentication, value); }
        }

        #endregion
    }
}
