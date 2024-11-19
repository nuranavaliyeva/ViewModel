using Microsoft.AspNetCore.Mvc;
using ViewModel.Models;
using ViewModel.ViewModels;

namespace ViewModel.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>
            {
               new Product
               {
                   Id = 1,
                   Name="Teddy",
                   Description="Fluffy teddy",
                   Price=50,
                   DiscountPrice=40,
                   Category="Toy",
                   Color="White",
                   Img="https://yandex.ru/images/search?pos=0&from=tabbar&img_url=https%3A%2F%2Fyt3.ggpht.com%2Fa%2FAGF-l7-PDUAEuBQayiWIVGoYoZmvLa5jRJKkUpUD9Q%3Ds900-c-k-c0xffffffff-no-rj-mo&text=White+teddy&rpt=simage&lr=105888"
               }
            };

            ProductVM productVM = new ProductVM
            {
                Products = products
            };
            return View(productVM);
        }
    }
}
