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
