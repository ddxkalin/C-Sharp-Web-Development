namespace CarDealer2.Services.Contracts.Parts
{
    using CarDealer2.Services.Models.Parts;
    using System.Collections.Generic;

    public interface IPartService
    {
        IEnumerable<PartListingModel> All(int page = 1);
    }
}
