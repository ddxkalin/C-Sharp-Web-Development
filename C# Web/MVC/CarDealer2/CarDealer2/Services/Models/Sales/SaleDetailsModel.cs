namespace CarDealer2.Services.Models.Sales
{
    using CarDealer2.Services.Cars.Models;

    public class SaleDetailsModel : SaleListModel
    {
        public CarModel Car { get; set; }
    }
}
