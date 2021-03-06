using Microsoft.AspNetCore.Mvc;
using MotoShop.Application.Cart;
using System.Linq;

namespace MotoShop.UI.ViewComponents
{
    public class CartViewComponent : ViewComponent
    {
        private GetCart _getCart;

        public CartViewComponent(GetCart getCart)
        {
            _getCart = getCart;
        }

        public IViewComponentResult Invoke(string view = "Default")
        {
            if (view == "Small")
            {
                var totalValue = _getCart.Do().Sum(x => x.RealValue * x.Qty);
                return View(view, $"{totalValue} zł");
            }

            return View(view, _getCart.Do());
        }
    }
}
