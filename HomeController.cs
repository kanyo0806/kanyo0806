using Microsoft.AspNetCore.Mvc;
using BidvestData.Common.Services;

namespace Bidvest.API.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersonService _personService;

        public HomeController(IPersonService personService)
        {
            _personService = personService;
        }

        public IActionResult Index()
        {
            var personelCollection = _personService.GetAllPersonel();
            return View("../Index", personelCollection.Result.Data);
        }
    }
}
