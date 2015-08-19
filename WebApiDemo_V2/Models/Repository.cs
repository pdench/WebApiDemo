using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemo_V2.Models
{
    public class Repository : IRepository
    {
        private WebApiDemo_V2Context db;

        public Repository(WebApiDemo_V2Context db)
        {
            this.db = db;
        }

        public IQueryable<Order> GetAllOrders()
        {
            return db.Orders;
        }

        public IQueryable<Order> GetAllOrdersWithDetails()
        {
            return db.Orders.Include("OrderDetails");
        }

        public Order GetOrder(int id)
        {
            return db.Orders.Include("OrderDetails.Book")
                .FirstOrDefault(o => o.Id == id);
        }
    }
}