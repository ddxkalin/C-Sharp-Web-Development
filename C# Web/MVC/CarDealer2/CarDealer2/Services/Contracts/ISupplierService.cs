namespace CarDealer2.Services.Contracts
{
    using System.Collections.Generic;
    using CarDealer2.Models.Suppliers;

    public interface ISupplierService
    {
        IEnumerable<SupplierModel> All(bool isImporter);
    }
}
