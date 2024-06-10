using Entity.Abstract;
using Entity.Events;

namespace Entity
{
    public class Product : BaseEntity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public void CreateProduct(string name, string description)
        {
            this.Name = name;
            this.Description = description;
            Append(new ProductCreated(name, description));
            Append(new ProductCreatedSendEmail(name, description));
            Append(new ProductReport(name, description));
        }

        public void DeleteProduct(string name, string description)
        {
            this.Name = name;
            this.Description = description;
            Append(new ProductDeleted(name, description));
        }
    }
}