namespace CarDealer2.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using CarDealer2.Models.Cars;
    using CarDealer2.Services.Contracts;
    using CarDealer2.Services.Models;
    using System.Collections.Generic;
    using CarDealer2.Models.Customers;
    using System.Linq;

    public class SupplierController : Controller
    {
        //private const string SuppliersView = "Suppliers";

        private readonly ISupplierService suppliers;

        public SupplierController(ISupplierService suppliers)
        {
            this.suppliers = suppliers;
        }

        [Route("suppliers/local")]
        public IActionResult Local()
            => View("Suppliers", this.GetSuppliersModel(false));
        
        [Route("suppliers/importers")]
        public IActionResult Importers()
            => View("Suppliers", this.GetSuppliersModel(true));
        
        private SuppliersModel GetSuppliersModel(bool importers)
        {
            var type = importers 
                ? "Importer" 
                : "Local";

            var suppliers = this.suppliers.All(importers);

            return new SuppliersModel
            {
                Type = type,
                Suppliers = suppliers
            };
        }
    }
}
