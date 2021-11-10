using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BidvestData.Common.Models;
using BidvestData.Common.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Bidvest.API.Controllers
{
    public class PersonalDetailsController : Controller
    {
        private readonly IPersonService _personService;

        public PersonalDetailsController(IPersonService personService)
        {
            _personService = personService;
        }

        public async Task<string> UpdateDetails(string details)
        {
            var person = JsonConvert.DeserializeObject<PersonalDetails>(details);
            var saveResult = await _personService.UpdatePerson(person);
            return JsonConvert.SerializeObject(saveResult);
        }
    }
}
