using Core.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstract
{
    public abstract class Request : IRequest
    {
        public Guid Guid { get; set; } = Guid.NewGuid();
        public Queue<IEvent> Events { get; set; } = new Queue<IEvent>();

        protected string Key { get;set; }

        public void Append(IEvent e)
        {
            Events.Enqueue(e);
        }
    }
}
