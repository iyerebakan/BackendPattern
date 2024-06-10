using Application.Concrete;
using DataAccess.Concrete;

namespace Application.Product
{
    public class CreateProductHandler : OperationBase<CreateProduct, bool>
    {
        protected override bool Execute(CreateProduct request)
        {
            ProductRepository productRepository = new ProductRepository();
            return productRepository.Add(request.Product);
        }

        protected override void Before(CreateProduct request)
        {
            Console.WriteLine($"Kontroller Başarılı");
        }
    }
}
