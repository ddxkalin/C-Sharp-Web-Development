namespace CarDealer2.Services.Implementation
{
    using CarDealer2.Data;
    using CarDealer2.Services.Contracts.Parts;
    using CarDealer2.Services.Models.Parts;
    using System.Collections.Generic;
    using System.Linq;

    public class PartService : IPartService
    {
        private const int PageSize = 25;

        private readonly CarDealerDbContext db;

        public PartService(CarDealerDbContext db)
        {

            this.db = db;
        }

        //IEnumerable<PartListingModel> All(int page = 1)
        //    => this.db
        //    .Parts
        //    .Skip((page - 1) * PageSize)
        //    .Take(PageSize)
        //    .Select(p => new PartListingModel
        //    {
        //        Id = p.Id,
        //        Name = p.Name,
        //        Price = p.Price,
        //        Quantity = p.Quantity,
        //        SupplierName = p.Supplier.Name
        //    })
            //.ToList();

        IEnumerable<PartListingModel> IPartService.All(int page)
            => this.db
                .Parts
                .OrderByDescending(p => p.Id)
                .Skip((page - 1) * PageSize)
                .Take(PageSize)
                .Select(p => new PartListingModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Quantity = p.Quantity,
                    SupplierName = p.Supplier.Name
                })
                .ToList();
    }
}
