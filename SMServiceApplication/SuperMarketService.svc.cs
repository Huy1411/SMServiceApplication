using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SMServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SuperMarketService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SuperMarketService.svc or SuperMarketService.svc.cs at the Solution Explorer and start debugging.
    public class SuperMarketService : ISuperMarketService
    {
        SuperMarketDbDataContext data = new SuperMarketDbDataContext();

        public bool AddCategory(Category category)
        {
            try
            {
                data.Categories.InsertOnSubmit(category);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool AddCustomer(Customer customer)
        {
            try
            {
                data.Customers.InsertOnSubmit(customer);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool AddOrder(Order order)
        {
            try
            {
                data.Orders.InsertOnSubmit(order);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool AddOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                data.OrderDetails.InsertOnSubmit(orderDetail);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool AddProduct(Product product)
        {
            try
            {
                data.Products.InsertOnSubmit(product);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool DeleteCategory(string id)
        {
            try
            {
                var category = data.Categories.Where(ca => ca.ID == int.Parse(id)).FirstOrDefault();
                data.Categories.DeleteOnSubmit(category);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool DeleteCustomer(string id)
        {
            try
            {
                var customer = data.Customers.Where(cus => cus.ID == int.Parse(id)).FirstOrDefault();
                data.Customers.DeleteOnSubmit(customer);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool DeleteOrder(string id)
        {
            try
            {
                var order = data.Customers.Where(or => or.ID == int.Parse(id)).FirstOrDefault();
                data.Customers.DeleteOnSubmit(order);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool DeleteOrderDetail(string id)
        {
            try
            {
                var orderDetail = data.OrderDetails.Where(ordt => ordt.ID == int.Parse(id)).FirstOrDefault();
                data.OrderDetails.DeleteOnSubmit(orderDetail);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool DeleteProduct(string id)
        {
            try
            {
                var product = data.Customers.Where(pro => pro.ID == int.Parse(id)).FirstOrDefault();
                data.Customers.DeleteOnSubmit(product);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool EditCategory(string id, Category newCategory)
        {
            try
            {
                var category = data.Categories.Where(ca => ca.ID == int.Parse(id)).FirstOrDefault();
                data.Categories.DeleteOnSubmit(category);
                data.Categories.InsertOnSubmit(newCategory);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool EditCustomer(string id, Customer newCustomer)
        {
            try
            {
                var customer = data.Customers.Where(cus => cus.ID == int.Parse(id)).FirstOrDefault();
                data.Customers.DeleteOnSubmit(customer);
                data.Customers.InsertOnSubmit(newCustomer);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool EditOrder(string id, Order newOrder)
        {
            try
            {
                var order = data.Orders.Where(or => or.ID == int.Parse(id)).FirstOrDefault();
                data.Orders.DeleteOnSubmit(order);
                data.Orders.InsertOnSubmit(newOrder);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool EditOrderDetail(string id, OrderDetail newOrderDetail)
        {
            try
            {
                var orderDetail = data.OrderDetails.Where(ordt => ordt.ID == int.Parse(id)).FirstOrDefault();
                data.OrderDetails.DeleteOnSubmit(orderDetail);
                data.OrderDetails.InsertOnSubmit(newOrderDetail);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool EditProduct(string id, Product newProduct)
        {
            try
            {
                var product = data.Products.Where(pro => pro.ID == int.Parse(id)).FirstOrDefault();
                data.Products.DeleteOnSubmit(product);
                data.Products.InsertOnSubmit(newProduct);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public List<Category> GetCategories()
        {
            try
            {
                var categories = (from category in data.Categories select category).ToList();
                return categories;
            }
            catch { return null; }
        }

        public List<Customer> GetCustomers()
        {
            try
            {
                var customers = (from customer in data.Customers select customer).ToList();
                return customers;
            }
            catch { return null; }
        }

        public List<OrderDetail> GetOrderDetails()
        {
            try
            {
                var orderDetails = (from orderDetail in data.OrderDetails select orderDetail).ToList();
                return orderDetails;
            }
            catch { return null; }
        }

        public List<Order> GetOrders()
        {
            try
            {
                var orders = (from order in data.Orders select order).ToList();
                return orders;
            }
            catch { return null; }
        }

        public List<Product> GetProducts()
        {
            try
            {
                var products = (from product in data.Products select product).ToList();
                return products;
            }
            catch { return null; }
        }
    }
}
