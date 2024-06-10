using Core.Event;
using DataAccess.Abstract;
using Entity;
using Entity.Dto.ProductDtos;

namespace DataAccess.Concrete
{
    public class ProductRepository : BaseRepository<Product>
    {
        public ProductRepository() { }
        public List<ProductDto> GetProducts()
        {
            return new List<ProductDto>
            {
                new ProductDto { Id = 1,Name="Laptop",Description="Lenovo 124"},
                new ProductDto { Id = 1,Name="Ipad",Description="Apple"},
                new ProductDto { Id = 1,Name="Telefon",Description="Samsung"},
                new ProductDto { Id = 1,Name="Saat",Description="Huawei"},
            };
        }
    }
}