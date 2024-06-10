using Core.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Events
{
    public class GetProductsCompleted : IEvent
    {
        public void Execute()
        {
            Console.WriteLine("GetProductsCompleted");
        }
    }
}
