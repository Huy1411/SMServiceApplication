using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SMServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISuperMarketService" in both code and config file together.
    [ServiceContract]
    public interface ISuperMarketService
    {
        //Customer
       
        //Hien thi
        [OperationContract] // bắt đầu viết services phải định nghĩa contract 
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json, // format kiểu trả về và gửi lên là json
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare, // style dữ liệu trả về
           UriTemplate = "api/v1/Customer/GetList"
         )] // định nghĩa đường link trả về
        List<Customer> GetCustomers();

        // Them
        [OperationContract] 
        [WebInvoke(Method = "POST",
           ResponseFormat = WebMessageFormat.Json, 
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare, 
           UriTemplate = "api/v1/Customer/Create"
         )]
        bool AddCustomer(Customer customer);

        //Sua
        [OperationContract] 
        [WebInvoke(Method = "PUT",
          ResponseFormat = WebMessageFormat.Json,
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare, 
          UriTemplate = "api/v1/Customer/Edit/{id}"
        )] 
        bool EditCustomer(string id, Customer customer);

        //xoa
        [OperationContract]
        [WebInvoke(Method = "POST",
          ResponseFormat = WebMessageFormat.Json, 
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare, 
          UriTemplate = "api/v1/Customer/Delete/{id}"
        )] 
        bool DeleteCustomer(string id);


        //Category

        //Hien thi 
        [OperationContract] 
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json, 
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare, 
           UriTemplate = "api/v1/Category/GetList"
         )]
        List<Category> GetCategories();

        // Them
        [OperationContract] 
        [WebInvoke(Method = "POST",
           ResponseFormat = WebMessageFormat.Json, 
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "api/v1/Category/Create"
         )] 
        bool AddCategory(Category category);


        //Sua
        [OperationContract] 
        [WebInvoke(Method = "PUT",
          ResponseFormat = WebMessageFormat.Json, 
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare, 
          UriTemplate = "api/v1/Category/Edit/{id}"
        )] 
        bool EditCategory(string id, Category category);

        //xoa
        [OperationContract]
        [WebInvoke(Method = "POST",
          ResponseFormat = WebMessageFormat.Json, 
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare, 
          UriTemplate = "api/v1/Category/Delete/{id}"
        )]
        bool DeleteCategory(string id);


        //Product

        //Hien thi 
        [OperationContract] 
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "api/v1/Product/GetList"
         )] // định nghĩa đường link trả về
        List<Product> GetProducts();

        // Them
        [OperationContract] 
        [WebInvoke(Method = "POST",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare, 
           UriTemplate = "api/v1/Product/Create"
         )] // định nghĩa đường link trả về
        bool AddProduct(Product product);

        //Sua
        [OperationContract] 
        [WebInvoke(Method = "PUT",
          ResponseFormat = WebMessageFormat.Json, 
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare,
          UriTemplate = "api/v1/Product/Edit/{id}"
        )] 
        bool EditProduct(string id, Product product);

        //xoa
        [OperationContract] 
        [WebInvoke(Method = "POST",
          ResponseFormat = WebMessageFormat.Json, 
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare, 
          UriTemplate = "api/v1/Product/Delete/{id}"
        )] 
        bool DeleteProduct(string id);

        //Oder

        //Hien thi 
        [OperationContract] 
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "api/v1/Order/GetList"
         )]
        List<Order> GetOrders();

        // Them
        [OperationContract] 
        [WebInvoke(Method = "POST",
           ResponseFormat = WebMessageFormat.Json, 
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "api/v1/Order/Create"
         )]
        bool AddOrder(Order order);

        //Sua
        [OperationContract] 
        [WebInvoke(Method = "PUT",
          ResponseFormat = WebMessageFormat.Json, 
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare, 
          UriTemplate = "api/v1/Order/Edit/{id}"
        )] 
        bool EditOrder(string id, Order order);

        //xoa
        [OperationContract]
        [WebInvoke(Method = "POST",
          ResponseFormat = WebMessageFormat.Json, 
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare, 
          UriTemplate = "api/v1/Order/Delete/{id}"
        )] 
        bool DeleteOrder(string id);


        // Order Detail 
        //Hien thi 
        [OperationContract] 
        [WebInvoke(Method = "GET",
           ResponseFormat = WebMessageFormat.Json, 
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare, 
           UriTemplate = "api/v1/OrderDetail/GetList"
         )] 
        List<OrderDetail> GetOrderDetails();

        // Them
        [OperationContract] 
        [WebInvoke(Method = "POST",
           ResponseFormat = WebMessageFormat.Json, 
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare, 
           UriTemplate = "api/v1/OrderDetail/Create"
         )] 
        bool AddOrderDetail(OrderDetail orderDetail);

        //Sua
        [OperationContract] 
        [WebInvoke(Method = "PUT",
          ResponseFormat = WebMessageFormat.Json,
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare,
          UriTemplate = "api/v1/OrderDetail/Edit/{id}"
        )] 
        bool EditOrderDetail(string id, OrderDetail orderDetail);

        //xoa
        [OperationContract]
        [WebInvoke(Method = "POST",
          ResponseFormat = WebMessageFormat.Json,
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare, 
          UriTemplate = "api/v1/OrderDetail/Delete/{id}"
        )]
        bool DeleteOrderDetail(string id);

        //Payment Services
        [OperationContract] // bắt đầu viết services phải định nghĩa contract 
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "api/v1/Customer/GetList"
            )]
        List<Payment> GetPayments();

        [OperationContract]
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "api/v1/Payment/Create"
            )]
        bool AddPayment(Payment payment);

        [OperationContract]
        [WebInvoke(Method = "PUT",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "api/v1/Payment/Edit/{id}"
            )]
        bool EditPayment(string id, Payment payment);

        [OperationContract]
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "api/v1/Payment/Delete/{id}"
            )]
        bool DeletePayment(string id);

        //Employee Services
        [OperationContract] // bắt đầu viết services phải định nghĩa contract 
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "api/v1/Employee/GetList"
            )]
        List<Employee> GetEmployees();

        [OperationContract]
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "api/v1/Employee/Create"
            )]
        bool AddEmployee(Employee employee);

        [OperationContract]
        [WebInvoke(Method = "PUT",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "api/v1/Employee/Edit/{id}"
            )]
        bool EditEmployee(string id, Employee employee);

        [OperationContract]
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "api/v1/Employee/Delete/{id}"
            )]
        bool DeleteEmployee(string id);


        //Role service

        [OperationContract] // bắt đầu viết services phải định nghĩa contract 
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "api/v1/Role/GetList"
            )]
        List<Role> GetRoles();

        [OperationContract]
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "api/v1/Role/Create"
            )]
        bool AddRole(Role role);

        [OperationContract]
        [WebInvoke(Method = "PUT",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "api/v1/Role/Edit/{id}"
            )]
        bool EditRole(string id, Role Role);

        [OperationContract]
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "api/v1/Role/Delete/{id}"
            )]
        bool DeleteRole(string id);

        //Provider service 
        [OperationContract] // bắt đầu viết services phải định nghĩa contract 
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "api/v1/Provider/GetList"
            )]
        List<Provider> GetProviders();

        [OperationContract]
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "api/v1/Provider/Create"
            )]
        bool AddProvider(Provider provider);

        [OperationContract]
        [WebInvoke(Method = "PUT",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "api/v1/Provider/Edit/{id}"
            )]
        bool EditProvider(string id, Provider provider);

        [OperationContract]
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "api/v1/Provider/Delete/{id}"
            )]
        bool DeleteProvider(string id);
    }
}
