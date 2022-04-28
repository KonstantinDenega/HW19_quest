using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW19_quest.Events
{
    abstract class Event
    {
        //public class EventClient : PubSubEvent<User> { }
        //public class EventProduct : PubSubEvent<Product> { }
        //public class EventClientCollection : PubSubEvent<ObservableCollection<User>> { }
        //public class EventProductCollection : PubSubEvent<ObservableCollection<Product>> { }
        public class EventText : PubSubEvent<string> { }
        public class EventBool : PubSubEvent<bool> { }
        //public class EventLogCollection : PubSubEvent<ObservableCollection<LogMsg>> { }

    }
}
