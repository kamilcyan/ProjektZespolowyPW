using MotoShop.Domain.Infrastructure;
using System.Threading.Tasks;

namespace MotoShop.Application.ProductsAdmin
{
    [Service]
    public class DeleteProduct
    {
        private IProductManager _productManager;

        public DeleteProduct(IProductManager productManager)
        {
            _productManager = productManager;
        }

        public Task<int> Do(int id)
        {
            return _productManager.DeleteProduct(id);
        }
    }
}
