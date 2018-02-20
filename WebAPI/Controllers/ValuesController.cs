using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        List<string> list;

        //Set
        public ValuesController()
        {
            list = new List<string> { "value1", "value2" };
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return list;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return list.ElementAt(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            list.Add(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            list.Add(value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            list.RemoveAt(id);
        }
    }
}
