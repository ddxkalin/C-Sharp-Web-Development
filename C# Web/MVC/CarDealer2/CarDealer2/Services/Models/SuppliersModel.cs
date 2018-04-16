namespace CarDealer2.Services.Models
{
    using System.Collections.Generic;
    using CarDealer2.Services.Models;
    using CarDealer2.Models.Suppliers;

    public class SuppliersModel
    {
        public string Type { get; set; }

        public IEnumerable<SupplierModel> Suppliers { get; set; }
    }
}
