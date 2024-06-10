using Core.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Events
{
    public class ProductDeleted : IEvent
    {
        public ProductDeleted(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public void Execute()
        {
            Console.WriteLine($"ProductDeleted {this.Name} {this.Description}");
        }
    }
}
