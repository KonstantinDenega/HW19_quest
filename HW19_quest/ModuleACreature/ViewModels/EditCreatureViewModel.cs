using Prism.Commands;
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
    class EditCreatureViewModel : BindableBase
    {
        public DelegateCommand BtnSaveEdit { get; private set; }

        protected readonly IEventAggregator _eventAggregator;

        private ObservableCollection<Creature> _creatures;
        public ObservableCollection<Creature> Creatures
        {
            get { return _creatures; }
            set { SetProperty(ref _creatures, value); }
        }

        private Creature _selectedCreatures;
        public Creature SelectedCreatures
        {
            get { return _selectedCreatures; }
            set { SetProperty(ref _selectedCreatures, value); }
        }

        public EditCreatureViewModel( IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;

            _eventAggregator.GetEvent<EventCreatureCollection>().Subscribe(MetCreatures);
            _eventAggregator.GetEvent<EventSelectedCreatures>().Subscribe(MetSelectedCreatures);


            BtnSaveEdit = new DelegateCommand(MetBtnSaveEdit);
        }

        private void MetSelectedCreatures(Creature obj)
        {
            SelectedCreatures = obj;
            MetAddEditCreature();
        }

        private void MetCreatures(ObservableCollection<Creature> obj)
        {
            Creatures = obj;
        }

        private void MetBtnSaveEdit()
        {
            MessageBox.Show($"{TypeCreatureEdit} / {NameEdit} / {SkinCoversEdit} / {SkeletonEdit} / {MuscularSystemEdit} / {RespiratorySystemEdit} / {NervousSystemEdit}");
        }


        /// <summary>
        /// Метод добавления данных в форму 
        /// </summary>
        private void MetAddEditCreature()
        {
            TypeCreatureEdit = SelectedCreatures.TypeCreature;
            NameEdit = SelectedCreatures.Name;
            SkinCoversEdit = SelectedCreatures.SkinCovers;
            SkeletonEdit = SelectedCreatures.Skeleton;
            MuscularSystemEdit = SelectedCreatures.MuscularSystem;
            RespiratorySystemEdit = SelectedCreatures.RespiratorySystem;
            NervousSystemEdit = SelectedCreatures.NervousSystem;
        }


        #region Свойства полей окна EditCreature

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
