using Application.Events;
using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Product
{
    public class GetProducts : Request
    {
        public GetProducts()
        {
            Append(new GetProductsCompleted());
        }
    }
}
