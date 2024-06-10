using Application.Product;
using Core.Result;
using Entity.Dto.ProductDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Concrete
{
    public class ProductManager
    {
        public ProductManager() { }

        public DataResponse<List<ProductDto>> GetProducts()
        {
            GetProductsHandler productService = new GetProductsHandler();
            return productService.Operation(new GetProducts());
        }

        public bool AddProduct(CreateProduct createProduct)
        {
            CreateProductHandler createProductHandler = new CreateProductHandler();
            return createProductHandler.Operation(createProduct).Data;
        }

        public bool DeleteProduct(int Id)
        {
            DeleteProductHandler deleteProductHandler = new DeleteProductHandler();
            return deleteProductHandler.Operation(new DeleteProduct(Id)).Data;
        }
    }
}
