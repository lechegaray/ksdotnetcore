using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ksdotnetcore.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ksdotnetcore.Controllers
{
    [Route("api/[controller]")]
    public class DevelopersController : Controller
    {
        // GET: api/values
        [HttpGet]
        public Developers[] Get()
        {
            var developers = new List<Developers>();

            developers.Add(new Developers()
            {
                Id = 1,
                FirstName = "Luis",
                LastName = "Echegaray",
                Age = 30,
                FavoriteIde = "Visual Studio Code"
            });

            developers.Add(new Developers()
            {
                Id = 2,
                FirstName = "Jordan",
                LastName = "Harris",
                Age = 27,
                FavoriteIde = "Sublime Text"
            });
            
            developers.Add(new Developers()
            {
                Id = 3,
                FirstName = "Parimal",
                LastName = "Deshmukh",
                Age = 25,
                FavoriteIde = "IntelliJ"
            });

            return developers.ToArray();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Developers Get(int id)
        {
            IList<Developers> developers = Get();

            return developers.Where(r => r.Id == id).FirstOrDefault();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
