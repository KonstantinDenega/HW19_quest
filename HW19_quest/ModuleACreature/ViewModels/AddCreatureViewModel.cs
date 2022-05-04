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

namespace HW19_quest.ModuleACreature.ViewModels
{
    class AddCreatureViewModel : BindableBase
    {
        public DelegateCommand BtnSaveAdd { get; private set; }

        private readonly IRegionManager _regionManager;
        protected readonly IEventAggregator _eventAggregator;

        public AddCreatureViewModel(IRegionManager regionManager, IEventAggregator eventAggregator)
        {
            _regionManager = regionManager;
            _eventAggregator = eventAggregator;

            BtnSaveAdd = new DelegateCommand(MetBtnSaveAdd);
        }

        /// <summary>
        /// Метод обработки кнопки BtnSaveAdd окна AddCreature
        /// </summary>
        private void MetBtnSaveAdd()
        {
            MessageBox.Show($"{TypeCreatureAdd} / {NameAdd} / {SkinCoversAdd} / {SkeletonAdd} / {MuscularSystemAdd} / {RespiratorySystemAdd} / {NervousSystemAdd}");
            MetClearTextBox();
        }

        #region Метод очистки строк ввода
        /// <summary>
        /// Метод очистки строк ввода
        /// </summary>
        private void MetClearTextBox()
        {
            TypeCreatureAdd = String.Empty;
            NameAdd = String.Empty;
            SkinCoversAdd = String.Empty;
            SkeletonAdd = String.Empty;
            MuscularSystemAdd = String.Empty;
            RespiratorySystemAdd = String.Empty;
            NervousSystemAdd = String.Empty;
        }
        #endregion

        #region Свойства полей окна AddCreature

        private bool _checkBoxDefaultAdd;
        public bool CheckBoxDefaultAdd
        {
            get { return _checkBoxDefaultAdd; }
            set { SetProperty(ref _checkBoxDefaultAdd, value); }
        }

        private string _typeCreatureAdd;
        public string TypeCreatureAdd
        {
            get { return _typeCreatureAdd; }
            set { SetProperty(ref _typeCreatureAdd, value); }
        }

        private string _nameAdd;
        public string NameAdd
        {
            get { return _nameAdd; }
            set { SetProperty(ref _nameAdd, value); }
        }

        private string _skinCoversAdd;
        public string SkinCoversAdd
        {
            get { return _skinCoversAdd; }
            set { SetProperty(ref _skinCoversAdd, value); }
        }

        private string _skeletonAdd;
        public string SkeletonAdd
        {
            get { return _skeletonAdd; }
            set { SetProperty(ref _skeletonAdd, value); }
        }

        private string _muscularSystemAdd;
        public string MuscularSystemAdd
        {
            get { return _muscularSystemAdd; }
            set { SetProperty(ref _muscularSystemAdd, value); }
        }

        private string _respiratorySystemAdd;
        public string RespiratorySystemAdd
        {
            get { return _respiratorySystemAdd; }
            set { SetProperty(ref _respiratorySystemAdd, value); }
        }

        private string _nervousSystemAdd;
        public string NervousSystemAdd
        {
            get { return _nervousSystemAdd; }
            set { SetProperty(ref _nervousSystemAdd, value); }
        }

        #endregion

    }
}
