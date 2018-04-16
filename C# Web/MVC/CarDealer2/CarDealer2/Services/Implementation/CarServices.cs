namespace CarDealer2.Services.Implementation
{
    using CarDealer2.Data;
    using CarDealer2.Services.Contracts;
    using CarDealer2.Services.Cars.Models;
    using System.Collections.Generic;
    using System.Linq;
    using CarDealer2.Services.Models.Cars;
    using CarDealer2.Services.Models;

    public class CarServices : ICarService
    {
        private readonly CarDealerDbContext db;

        public CarServices(CarDealerDbContext db)
        {
            this.db = db;
        }    
        public IEnumerable<CarModel> ByMake(string make)
             => this.db
                .Cars
                .Where(c => c.Make.ToLower() == make.ToLower())
                .OrderBy(c => c.Model)
                .ThenBy(c => c.TravelledDistance)
                .Select(c => new CarModel
                {
                    Make = c.Make,
                    Model = c.Model,
                    TravelledDistance = c.TravelledDistance
                })
                .ToList();

        public IEnumerable<CarWithPartsModel> WithParts()
            => this.db
                .Cars
                .OrderByDescending(c => c.Id)
                .Select(c => new CarWithPartsModel
                {
                    Make = c.Make,
                    Model = c.Model,
                    TravelledDistance = c.TravelledDistance,
                    Parts = c.Parts.Select(p => new PartModel
                    {
                        Name = p.Part.Name,
                        Price = p.Part.Price
                    })
                })
                .ToList();
    }
}
