using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApiDemo_V2.Models
{
    public class WebApiDemoContextInitializer : DropCreateDatabaseAlways<WebApiDemo_V2Context>
    {
        protected override void Seed(WebApiDemo_V2Context context)
        {

            var books = new List<Book> {
                new Book() { Name="War and Peace", Author="Tolstoy", Price=14.99m},
                new Book() { Name="Book 1", Author="Dench", Price=15.99m},
                new Book() { Name="Book 2", Author="Dench", Price=16.99m},
                new Book() { Name="Book 3", Author="Dench", Price=17.99m},
                new Book() { Name="Book 4", Author="Dench", Price=18.99m},
                new Book() { Name="Book 5", Author="Dench", Price=19.99m},
                new Book() { Name="Book 6", Author="Dench", Price=11.99m}
            };

            books.ForEach(b => context.Books.Add(b));
            context.SaveChanges();

            var order = new Order() { Customer = "John doe", OrderDate = new DateTime(2015, 8, 17) };
            var details = new List<OrderDetail> {
                new OrderDetail() { Book=books[0], Quantity=1,Order=order},
                new OrderDetail() { Book=books[3], Quantity=2,Order=order},
                new OrderDetail() { Book=books[4], Quantity=4,Order=order}
            };
            context.Orders.Add(order);
            details.ForEach(o => context.OrderDetails.Add(o));
            context.SaveChanges();

            order = new Order() { Customer = "Alex P. Keaton", OrderDate = new DateTime(2015, 9, 1) };
            details = new List<OrderDetail> {
                new OrderDetail() { Book=books[1], Quantity=1,Order=order},
                new OrderDetail() { Book=books[1], Quantity=1,Order=order},
                new OrderDetail() { Book=books[3], Quantity=12,Order=order},
                new OrderDetail() { Book=books[4], Quantity=3,Order=order}
            };
            context.Orders.Add(order);
            details.ForEach(o => context.OrderDetails.Add(o));
            context.SaveChanges();

            order = new Order() { Customer = "Angela Lansbury", OrderDate = new DateTime(2015, 11, 27) };
            details = new List<OrderDetail> {
                new OrderDetail() { Book=books[2], Quantity=1,Order=order},
                new OrderDetail() { Book=books[4], Quantity=1,Order=order},
                new OrderDetail() { Book=books[3], Quantity=1,Order=order},
                new OrderDetail() { Book=books[1], Quantity=3,Order=order}
            };
            context.Orders.Add(order);
            details.ForEach(o => context.OrderDetails.Add(o));
            context.SaveChanges();
            
            base.Seed(context);
        }
    }
}