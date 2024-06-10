using Core.Event;

namespace Entity.Events
{
    public class ProductCreatedSendEmail : IEvent
    {
        public ProductCreatedSendEmail(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public void Execute()
        {
            Console.WriteLine($"ProductCreatedSendEmail {this.Name} {this.Description}");
        }
    }
}
