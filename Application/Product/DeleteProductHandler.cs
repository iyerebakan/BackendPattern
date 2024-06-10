using Core;
using DataAccess.Concrete;
using Entity.Dto.ProductDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Product
{
    public class DeleteProductHandler : OperationBase<DeleteProduct, bool>
    {
        protected override bool Execute(DeleteProduct request)
        {
            ProductRepository productRepository = new ProductRepository();
            var product = new Entity.Product();
            product.DeleteProduct("deneme", "deneme");
            return productRepository.Delete(product);
        }
    }
}
