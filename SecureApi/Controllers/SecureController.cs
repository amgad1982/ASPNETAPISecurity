using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SecureApi.Controllers
{
    public class SecureController : ApiController
    {
        [HttpGet]
        [Authorize]
        public List<Person> People()
        {
            var people = new Faker("ar").Make<Person>(30, p => new Faker().Person).ToList();
            return people;
        }
    }


   
}
