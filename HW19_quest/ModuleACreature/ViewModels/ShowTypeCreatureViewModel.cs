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
    class ShowTypeCreatureViewModel : BindableBase
    {
        public DelegateCommand BtnAdd { get; private set; }
        public DelegateCommand BtnEdit { get; private set; }
        public DelegateCommand BtnDelete { get; private set; }
        public DelegateCommand BtnTypeCreatures { get; private set; }

        private readonly IRegionManager _regionManager;
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

        public ShowTypeCreatureViewModel(IRegionManager regionManager, IEventAggregator eventAggregator)
        {
            _regionManager = regionManager;
            _eventAggregator = eventAggregator;

            BtnAdd = new DelegateCommand(MetBtnAdd);
            BtnEdit = new DelegateCommand(MetBtnEdit);
            BtnDelete = new DelegateCommand(MetBtnDelete);

            CreateFileBDClient();
        }

        /// <summary>
        /// Метод открытия окна AddCreature
        /// </summary>
        private void MetBtnAdd()
        {
            _regionManager.RequestNavigate("ParametrCreatureRegion", "AddCreature");
            _eventAggregator.GetEvent<EventCreatureCollection>().Publish(Creatures);
        }

        /// <summary>
        /// Метод открытия окна EditCreature
        /// </summary>
        private void MetBtnEdit()
        {
            if (SelectedCreatures != null)
            {
                _regionManager.RequestNavigate("ParametrCreatureRegion", "EditCreature");
                _eventAggregator.GetEvent<EventSelectedCreatures>().Publish(SelectedCreatures);
                _eventAggregator.GetEvent<EventCreatureCollection>().Publish(Creatures);
            }
            else MessageBox.Show("Невыбранна строка для изменения");
        }

        /// <summary>
        /// Метод удаление записи в коллекции Creature
        /// </summary>
        private async void MetBtnDelete()
        {
            if (SelectedCreatures != null)
            {
                //Удаление из БД 
                using (DBCreatureContext db = new DBCreatureContext())
                {
                    db.Creatures.Remove(SelectedCreatures);
                    await db.SaveChangesAsync();
                }

                Creatures.Remove(SelectedCreatures);
                MessageBox.Show("Данные успешно удалены");
            }
            else MessageBox.Show("Невыбранна строка для удаления");
        }

        /// <summary>
        /// Метод заполнения данными программу
        /// </summary>
        public void CreateFileBDClient()
        {
            ObservableCollection<Creature> TempCreature;
            using (DBCreatureContext db = new DBCreatureContext())
            {
                // получаем данные из бд
                TempCreature = new ObservableCollection<Creature>(db.Creatures.ToList());
            }
            Creatures = TempCreature;
        }
    }
}
