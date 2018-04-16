namespace CarDealer2.Services.Contracts
{
    using CarDealer2.Services.Cars.Models;
    using CarDealer2.Services.Models.Cars;
    using System.Collections.Generic;

    public interface ICarService
    {
        IEnumerable<CarModel> ByMake(string make);

        IEnumerable<CarWithPartsModel> WithParts();
    }
}
