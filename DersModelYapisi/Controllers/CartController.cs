using DersModelYapisi.Models;
using DersModelYapisi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DersModelYapisi.Controllers
{
    public class CartController : Controller
    {
        public ActionResult Index()
        {
            var product1 = new Product { Id = 1, Name = "Ürün 1", Price = 10.99m };
            var product2 = new Product { Id = 2, Name = "Ürün 2", Price = 19.99m };
            var product3 = new Product { Id = 3, Name = "Ürün 3", Price = 5.99m };

            var cartProduct1 = new CartProduct { Id = 1, Product = product1, Quantity = 5, Price = product1.Price * 5 };
            var cartProduct2 = new CartProduct { Id = 2, Product = product2, Quantity = 3, Price = product2.Price * 3 };
            var cartProduct3 = new CartProduct { Id = 3, Product = product3, Quantity = 2, Price = product3.Price * 2 };

            var cartProducts = new List<CartProduct> { cartProduct1, cartProduct2, cartProduct3 };

            decimal totalPrice = 0;
            foreach (var cartProduct in cartProducts)
            {
                totalPrice += cartProduct.Price;
            }

            decimal tax = totalPrice * 0.18m; // KDV oranını burada %18 olarak varsaydım.
            decimal totalAmount = totalPrice + tax;

            var viewModel = new CartViewModel
            {
                CartProducts = cartProducts,
                TotalPrice = totalPrice,
                Tax = tax,
                TotalAmount = totalAmount
            };

            return View(viewModel);
        }
    }

}

