using OrderService.Models;

namespace OrderService.Services.Interface
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetAllOrdersAsync();
        Task<Order?> GetOrderByIdAsync(int id);
        Task<Order> CreateOrderAsync(Order order);
        Task<bool> UpdateOrderStatusAsync(int id, string status);
        Task<bool> DeleteOrderAsync(int id);
    }
}
