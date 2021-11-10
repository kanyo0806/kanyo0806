using BidvestData.Common.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bidvest.Core.Converts
{
    public static class DetailsConverter
    {
        public static string ConvertToJson(IEnumerable<string> detailsCollection)
        {
            List<PersonalDetails> personalDetails = new List<PersonalDetails>();

            foreach (var line in detailsCollection)
            {
                var detailsBreakdown = line.Split('|');
                personalDetails.Add(
                    new PersonalDetails
                    {
                        Id = Convert.ToInt32(detailsBreakdown[0]),
                        FirstName = detailsBreakdown[1],
                        Surname = detailsBreakdown[2],
                        Email = detailsBreakdown[3],
                        Gender = (GenderType)Enum.Parse(typeof(GenderType), detailsBreakdown[4].ToString().ToUpper()),
                        IPAddress = detailsBreakdown[5]
                    });
            }

            return JsonConvert.SerializeObject(personalDetails);
        }
    }
}
