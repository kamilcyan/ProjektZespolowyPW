using MotoShop.Domain.Infrastructure;
using System.Threading.Tasks;

namespace MotoShop.Application.OrdersAdmin
{
    [Service]
    public class UpdateOrder
    {
        private IOrderManager _orderManager;

        public UpdateOrder(IOrderManager orderManager)
        {
            _orderManager = orderManager;
        }

        public Task<int> DoAsync(int id)
        {
            return _orderManager.AdvanceOrder(id);
        }
    }
}
