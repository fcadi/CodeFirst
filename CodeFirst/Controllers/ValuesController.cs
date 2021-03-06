﻿using System.Collections.Generic;
using System.Web.Http;

namespace CodeFirst.Controllers
{
    public class ValuesController : ApiController
    {
        [AllowAnonymous]
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        
        [Authorize(Roles = "Admin")]
        // GET api/values/5
        public string Get(int id)
        {
            return "value: " + id;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
