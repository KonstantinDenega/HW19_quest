using HW19_quest.Business;
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
    class AddCreatureViewModel : BindableBase
    {
        CreateCreature createCreatures = new CreateCreature();

        public DelegateCommand BtnSaveAdd { get; private set; }

        private readonly IRegionManager _regionManager;
        protected readonly IEventAggregator _eventAggregator;

        private ObservableCollection<Creature> _creatures;
        public ObservableCollection<Creature> Creatures
        {
            get { return _creatures; }
            set { SetProperty(ref _creatures, value); }
        }

        public AddCreatureViewModel(IRegionManager regionManager, IEventAggregator eventAggregator)
        {
            _regionManager = regionManager;
            _eventAggregator = eventAggregator;

            _eventAggregator.GetEvent<EventCreatureCollection>().Subscribe(MetCreatureCollection);
            _eventAggregator.GetEvent<EventText>().Subscribe(MetCreatureCollection);

            BtnSaveAdd = new DelegateCommand(MetBtnSaveAdd);
        }

        private void MetCreatureCollection(string typeCreature)
        {
            switch (typeCreature)
            {
                case "Млекопитающие":
                    CreateMammal();
                    break;
                case "Птицы":
                    CreateBird();
                    break;
                case "Земноводные":
                    CreateAmphibia();
                    break;

                case "Неизвестный":
                    CreateUnknown();
                    break;
            }
        }

        private void MetCreatureCollection(ObservableCollection<Creature> obj)
        {
            Creatures = obj;
        }

        /// <summary>
        /// Метод обработки кнопки BtnSaveAdd окна AddCreature
        /// </summary>
        private void MetBtnSaveAdd()
        {
            CreateCollectionCreature();
            MetClearTextBox();
            MessageBox.Show("Данные успешно добавлены");
        }

        private void CreateMammal()
        {
            SkinCoversAdd = createCreatures.Create(TypeCreature.Mammal).SkinCovers;
            SkeletonAdd = createCreatures.Create(TypeCreature.Mammal).Skeleton;
            MuscularSystemAdd = createCreatures.Create(TypeCreature.Mammal).MuscularSystem;
            RespiratorySystemAdd = createCreatures.Create(TypeCreature.Mammal).RespiratorySystem;
            NervousSystemAdd = createCreatures.Create(TypeCreature.Mammal).NervousSystem;  
        }

        private void CreateBird()
        {
            SkinCoversAdd = createCreatures.Create(TypeCreature.Bird).SkinCovers;
            SkeletonAdd = createCreatures.Create(TypeCreature.Bird).Skeleton;
            MuscularSystemAdd = createCreatures.Create(TypeCreature.Bird).MuscularSystem;
            RespiratorySystemAdd = createCreatures.Create(TypeCreature.Bird).RespiratorySystem;
            NervousSystemAdd = createCreatures.Create(TypeCreature.Bird).NervousSystem;  
        }

        private void CreateAmphibia()
        {
            SkinCoversAdd = createCreatures.Create(TypeCreature.Amphibia).SkinCovers;
            SkeletonAdd = createCreatures.Create(TypeCreature.Amphibia).Skeleton;
            MuscularSystemAdd = createCreatures.Create(TypeCreature.Amphibia).MuscularSystem;
            RespiratorySystemAdd = createCreatures.Create(TypeCreature.Amphibia).RespiratorySystem;
            NervousSystemAdd = createCreatures.Create(TypeCreature.Amphibia).NervousSystem;
        }

        private void CreateUnknown()
        {
            SkinCoversAdd = createCreatures.Create(TypeCreature.Unknown).SkinCovers;
            SkeletonAdd = createCreatures.Create(TypeCreature.Unknown).Skeleton;
            MuscularSystemAdd = createCreatures.Create(TypeCreature.Unknown).MuscularSystem;
            RespiratorySystemAdd = createCreatures.Create(TypeCreature.Unknown).RespiratorySystem;
            NervousSystemAdd = createCreatures.Create(TypeCreature.Unknown).NervousSystem;
        }

        private void CreateCollectionCreature()
        {
            Creatures.Add(new Creature(
                TypeCreatureAdd, NameAdd, SkinCoversAdd,
                SkeletonAdd, MuscularSystemAdd,
                RespiratorySystemAdd, NervousSystemAdd));
        }

        #region Метод очистки строк ввода
        /// <summary>
        /// Метод очистки строк ввода
        /// </summary>
        private void MetClearTextBox()
        {
            NameAdd = String.Empty;
            SkinCoversAdd = String.Empty;
            SkeletonAdd = String.Empty;
            MuscularSystemAdd = String.Empty;
            RespiratorySystemAdd = String.Empty;
            NervousSystemAdd = String.Empty;
        }
        #endregion

        #region Свойства полей окна AddCreature

        private string _typeCreatureAdd;
        public string TypeCreatureAdd
        {
            get { return _typeCreatureAdd; }
            set
            {
                _typeCreatureAdd = value;
                _eventAggregator.GetEvent<EventText>().Publish(TypeCreatureAdd);
            }
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
