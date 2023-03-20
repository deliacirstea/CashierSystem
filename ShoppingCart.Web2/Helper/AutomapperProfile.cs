using AutoMapper;
using ShoppingCart.DataAccess.Models;
using ShoppingCart.Web2.Models.ViewModels;

namespace ShoppingCart.Web2.Helper
{
    public class AutomapperProfile: Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Category,CategoryViewModel>();    
        }
    }
}
