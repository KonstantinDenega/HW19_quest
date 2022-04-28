using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HW19_quest.Events.Event;

namespace HW19_quest.ModuleDStatus.ViewModels
{
    class StatusViewModel : BindableBase
    {
        protected readonly IEventAggregator _eventAggregator;


        public StatusViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;

            _eventAggregator.GetEvent<EventText>().Subscribe(MethodText);
            _eventAggregator.GetEvent<EventBool>().Subscribe(MethodBool);
        }

        private void MethodBool(bool obj)
        {
            BoolMes = obj;
        }

        private void MethodText(string text)
        {
            TextMes = text;
        }

        #region Свойства работы со статусом Сообщений
        private bool boolMes;
        public bool BoolMes
        {
            get { return boolMes; }
            set { SetProperty(ref boolMes, value); }
        }

        private string textMes;
        public string TextMes
        {
            get { return textMes; }
            set { SetProperty(ref textMes, value); }
        }

        #endregion
    }
}

