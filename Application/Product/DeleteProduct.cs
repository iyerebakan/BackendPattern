using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Product
{
    public class DeleteProduct : Request
    {
        public int Id { get; set; }
        public DeleteProduct(int id)
        {
            this.Id = id;
        }
    }
}
