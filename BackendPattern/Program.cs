using Application.Concrete;
using Application.Product;
using Entity.Dto.ProductDtos;

namespace BackendPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();
            productManager.GetProducts();

            Console.WriteLine(new string('-', 50));

            productManager.AddProduct(new CreateProduct("ibrahim", "yerebakan"));

            productManager.DeleteProduct(1);

            Console.ReadLine();
        }
    }
}