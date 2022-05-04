using HW19_quest.Business;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW19_quest.Events
{
    abstract class Event
    {

        public class EventTypeCreature : PubSubEvent<TypeCreature> { }
        public class EventSelectedCreatures : PubSubEvent<Creature> { }
        public class EventCreatureCollection : PubSubEvent<ObservableCollection<Creature>> { }
        public class EventText : PubSubEvent<string> { }
        public class EventBool : PubSubEvent<bool> { }
    }
}
