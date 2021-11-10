using BidvestData.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BidvestData.Common.Services
{
    public interface IPersonService:IServiceBase
    {
        Task<Resultant<List<PersonalDetails>>> GetAllPersonel();
        Task<Resultant> UpdatePerson(PersonalDetails person);
    }
}
