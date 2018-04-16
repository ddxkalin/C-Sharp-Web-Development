namespace CarDealer2.Services.Contracts
{
    using CarDealer2.Services.Models;
    using CarDealer2.Services.Models.Customers;
    using System;
    using System.Collections.Generic;

    public interface ICustomerService
    {
        IEnumerable<CustomerModel> Ordered(OrderDirection order);

        CustomerTotalSalesModel TotalSalesById(int id);

        void Create(string name, DateTime birthdate, bool IsYoungDriver);
       
        CustomerModel ById(int id);

        void Edit(int id, string name, DateTime birthday, bool isYoungDriver);

        bool Exists(int id);
    }
}
