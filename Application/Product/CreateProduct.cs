using Core.Abstract;

namespace Application.Product
{
    public class CreateProduct : Request
    {
        public Entity.Product Product { get; set; }

        public CreateProduct(string name, string description)
        {
            this.Product = new Entity.Product();
            this.Product.CreateProduct(name, description);
        }
    }
}
