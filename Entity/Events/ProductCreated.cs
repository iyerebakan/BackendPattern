using Core.Event;

namespace Entity.Events
{
    public class ProductCreated : IEvent
    {
        public ProductCreated(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public void Execute()
        {
            Console.WriteLine($"Product Created {this.Name} {this.Description}");
        }
    }
}
