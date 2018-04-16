namespace CarDealer2.Services.Models.Cars
{
    using CarDealer2.Services.Cars.Models;
    using System.Collections.Generic;
    
    public class CarWithPartsModel : CarModel
    {
        public IEnumerable<PartModel> Parts { get; set; }
    }
}
