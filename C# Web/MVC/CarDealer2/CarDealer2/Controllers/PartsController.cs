namespace CarDealer2.Controllers
{
    using CarDealer2.Services.Contracts.Parts;
    using Microsoft.AspNetCore.Mvc;

    public class PartsController : Controller
    {
        private const int PageSize = 25;

        private readonly IPartService parts;

        public PartsController(IPartService parts)
        {
            this.parts = parts;
        }

        public IActionResult All(int page = 1)
            => View(this.parts.All(page));

    }
}
