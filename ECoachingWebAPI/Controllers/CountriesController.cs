using ECoachingWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ECoachingWebAPI.Controllers
{
    public class CountriesController : ApiController
    {        
        private Context db = new Context();

        /// <summary>
        /// Get all countries
        /// </summary>
        /// <returns>Return a list of countries</returns>
        public IEnumerable<Country> GetAllCountries()
        {
            return db.Country.AsEnumerable();
        }

        /// <summary>
        /// Get country
        /// </summary>
        /// <param name="id">Country id</param>
        /// <returns></returns>
        public Country GetCountry(int id)
        {
            Country country = db.Country.Find(id);
            if (country == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return country;
        }
    }
}
