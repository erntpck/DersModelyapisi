using DersModelYapisi.Models;

namespace DersModelYapisi.ViewModels
{
    public class CartViewModel
    {
        public List<CartProduct> CartProducts { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Tax { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
