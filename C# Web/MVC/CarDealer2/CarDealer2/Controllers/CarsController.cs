﻿namespace CarDealer2.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using CarDealer2.Models.Cars;
    using CarDealer2.Services.Contracts;

    [Route("cars")]
    public class CarsController : Controller
    {
        private readonly ICarService cars;

        public CarsController(ICarService cars)
        {
            this.cars = cars;
        }

        [Route("{make}", Order = 2)]
        public IActionResult ByMake(string make)
        {
            var cars = this.cars.ByMake(make);

            return View(new CarsByMakeModel
            {
                Make = make,
                Cars = cars
            });
        }

        [Route("parts", Order = 1)]
        public IActionResult Parts()
            => View(this.cars.WithParts());
    }
    
}