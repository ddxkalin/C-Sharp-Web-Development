namespace CarDealer2.Models.Cars
{
    using CarDealer2.Services.Cars.Models;
    using System.Collections.Generic;

    public class CarsByMakeModel
    {
        public string Make { get; set; }

        public IEnumerable<CarModel> Cars { get; set; }
    }
}
