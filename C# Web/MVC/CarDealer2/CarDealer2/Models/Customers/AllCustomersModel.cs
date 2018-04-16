namespace CarDealer2.Models.Customers
{
    using CarDealer2.Services.Models;
    using CarDealer2.Services.Models.Customers;
    using System.Collections.Generic;

    public class AllCustomersModel
    {
        public IEnumerable<CustomerModel> Customers { get; set; }

        public OrderDirection OrderDirection { get; set; }
    }
}
