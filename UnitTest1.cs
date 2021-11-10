using Bidvest.API.Controllers;
using BidvestData.Common.Models;
using BidvestData.Common.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kanyo0806
{
  [TestClass]
  public class HomeControllerTest
  {
    HomeController GetHomeController()
    {
      throw new System.NotImplementedException();
    }
    [TestMethod]
    public void IndexTest()
    {
      var controller = GetHomeController();
      var result = controller.Index();
      PersonalDetails x = (result as Resultant<List<PersonalDetails>>).Data.FirstOrDefault();
      Assert.AreEqual(x.FirstName, "Bob");
    }
    [TestMethod]
    public async Task AsyncIndexTest()
    {
      var name = await Answers.GetFirstEntryName(GetHomeController());
      Assert.AreEqual(name, "Bob");
    }

   
  }
}
