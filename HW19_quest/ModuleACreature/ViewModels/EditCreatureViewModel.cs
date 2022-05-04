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
    class EditCreatureViewModel : BindableBase
    {
        public DelegateCommand BtnSaveEdit { get; private set; }

        private readonly IRegionManager _regionManager;
        protected readonly IEventAggregator _eventAggregator;

        public EditCreatureViewModel(IRegionManager regionManager, IEventAggregator eventAggregator)
        {
            _regionManager = regionManager;
            _eventAggregator = eventAggregator;

            BtnSaveEdit = new DelegateCommand(MetBtnSaveEdit);
        }

        private void MetBtnSaveEdit()
        {
            MessageBox.Show($"{TypeCreatureEdit} / {NameEdit} / {SkinCoversEdit} / {SkeletonEdit} / {MuscularSystemEdit} / {RespiratorySystemEdit} / {NervousSystemEdit}");
        }

        #region Свойства полей окна EditCreature

        private bool _checkBoxDefaultEdit;
        public bool CheckBoxDefaultEdit
        {
            get { return _checkBoxDefaultEdit; }
            set { SetProperty(ref _checkBoxDefaultEdit, value); }
        }

        private string _typeCreatureEdit;
        public string TypeCreatureEdit
        {
            get { return _typeCreatureEdit; }
            set { SetProperty(ref _typeCreatureEdit, value); }
        }

        private string _nameEdit;
        public string NameEdit
        {
            get { return _nameEdit; }
            set { SetProperty(ref _nameEdit, value); }
        }

        private string _skinCoversEdit;
        public string SkinCoversEdit
        {
            get { return _skinCoversEdit; }
            set { SetProperty(ref _skinCoversEdit, value); }
        }

        private string _skeletonEdit;
        public string SkeletonEdit
        {
            get { return _skeletonEdit; }
            set { SetProperty(ref _skeletonEdit, value); }
        }

        private string _muscularSystemEdit;
        public string MuscularSystemEdit
        {
            get { return _muscularSystemEdit; }
            set { SetProperty(ref _muscularSystemEdit, value); }
        }

        private string _respiratorySystemEdit;
        public string RespiratorySystemEdit
        {
            get { return _respiratorySystemEdit; }
            set { SetProperty(ref _respiratorySystemEdit, value); }
        }

        private string _nervousSystemEdit;
        public string NervousSystemEdit
        {
            get { return _nervousSystemEdit; }
            set { SetProperty(ref _nervousSystemEdit, value); }
        }

        #endregion

    }
}
