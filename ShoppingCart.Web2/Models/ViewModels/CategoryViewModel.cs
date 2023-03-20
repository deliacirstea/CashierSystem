using ShoppingCart.DataAccess.Models;

namespace ShoppingCart.Web2.Models.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ProductCategory>Products { get; set; }
    }
}
