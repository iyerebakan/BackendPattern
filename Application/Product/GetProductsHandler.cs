using Application.Concrete;
using DataAccess.Concrete;
using Entity.Dto.ProductDtos;

namespace Application.Product
{
    public class GetProductsHandler : OperationBase<GetProducts, List<ProductDto>>
    {

        protected override List<ProductDto> Execute(GetProducts request)
        {
            ProductRepository productRepository = new ProductRepository();
            var products = productRepository.GetProducts();

            foreach (ProductDto product in products)
            {
                Console.WriteLine(product.Name.PadLeft(20) + " : " + product.Description);
            }
            return products;
        }

        protected override string Cachekey { get => "GetProductHandler"; }
    }
}