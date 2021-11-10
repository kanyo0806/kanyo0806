using BidvestData.Common.Services;
using System.Threading.Tasks;

namespace Bidvest.API.Controllers
{
  public class HomeController : Controller
  {
    private readonly IPersonService _personService;

    public HomeController(IPersonService personService)
    {
      _personService = personService;
    }

    public object Index()
    {
      var personelCollection = _personService.GetAllPersonel();
      return personelCollection.Result;
    }

    public Task<object> IndexAsync()
    {
      return View(_personService.GetAllPersonel().Result);
    }

    protected override Task<object> View(object x)
    {
      throw new System.NotImplementedException();
    }
  }

  public abstract class Controller
  {
    protected abstract Task<object> View(object x);
  }
}
