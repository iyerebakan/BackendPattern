using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Event
{
    public class EventFactory
    {
        private Dictionary<string, IEvent> _events = null;

        private static readonly Lazy<EventFactory> _instance = new Lazy<EventFactory>(() => new EventFactory());

        public static EventFactory Instance
        {
            get { return _instance.Value; }
        }

        public EventFactory()
        {
            Initialize();
        }

        private void Initialize()
        {
            _events = new Dictionary<string, IEvent>()
            {
                {"email",new SendEmail() },
                {"sms",new SendSms() },
                {"completed",new Completed() },
            };
        }

        public IEvent GetEvent(string type)
        {
            try
            {
                if (Instance._events.ContainsKey(type))
                    return Instance._events[type];

                throw new System.Exception(string.Format("This type is not implemented"));
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
