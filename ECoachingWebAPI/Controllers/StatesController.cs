using ECoachingWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ECoachingWebAPI.Controllers
{
    public class StatesController : ApiController
    {
        private Context db = new Context();

        /// <summary>
        /// Get all states
        /// </summary>
        /// <returns>Return a list of states</returns>
        [Route("api/countries/{countryId}/states")]
        public IEnumerable<State> GetAllStates(int countryId)
        {
            return db.State.Where(x => x.CountryId == countryId).AsEnumerable();
        }
    }
}
