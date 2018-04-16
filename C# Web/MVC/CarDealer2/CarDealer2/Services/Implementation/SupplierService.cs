namespace CarDealer2.Services.Implementation
{
    using System.Collections.Generic;
    using CarDealer2.Models.Suppliers;
    using CarDealer2.Services.Contracts;
    using CarDealer2.Data;
    using System.Linq;

    public class SupplierService : ISupplierService
    {
        private readonly CarDealerDbContext db;

        public SupplierService(CarDealerDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<SupplierModel> All(bool isImporter)
        =>  this.db
            .Suppliers
            .OrderByDescending(c => c.Id)
            .Where(s => s.IsImporter == isImporter)
            .Select(s => new SupplierModel
            {
                Id = s.Id,
                Name = s.Name,
                TotalParts = s.Parts.Count
            })
            .ToList();
    }
}
