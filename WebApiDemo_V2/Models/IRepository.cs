using System;
namespace WebApiDemo_V2.Models
{
    public interface IRepository
    {
        System.Linq.IQueryable<Order> GetAllOrders();
        System.Linq.IQueryable<Order> GetAllOrdersWithDetails();
        Order GetOrder(int id);
    }
}
