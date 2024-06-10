using Core.Event;

namespace Entity.Events
{
    public class ProductReport : IEvent
    {
        public ProductReport(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public void Execute()
        {
            Console.WriteLine($"Product ProductReport {this.Name} {this.Description}");
        }
    }
}
