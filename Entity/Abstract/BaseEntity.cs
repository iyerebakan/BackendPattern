using Core.Event;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Abstract
{
    public abstract class BaseEntity
    {
        public long Id { get; set; }
        public long CreateUserId { get; set; }
        public string CreateDateTime { get; set; }
        public long UpdateUserId { get; set; }
        public string UpdateDateTime { get; set; }
        public int Status { get; set; }

        public Queue<IEvent> Events { get; set; } = new Queue<IEvent>();

        public void Append(IEvent e)
        {
            Events.Enqueue(e);
        }
    }
}
