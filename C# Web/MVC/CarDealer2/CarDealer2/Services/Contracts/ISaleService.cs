namespace CarDealer2.Services.Contracts
{
    using CarDealer2.Services.Models.Sales;
    using System.Collections.Generic;

    public interface ISaleService
    {
        IEnumerable<SaleListModel> All();

        SaleDetailsModel Details(int id);
    }
}
