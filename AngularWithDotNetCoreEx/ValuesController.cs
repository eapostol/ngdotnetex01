﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AngularWithDotNetCoreEx
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET: api/values
        // removed for demo
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
         //   return new string[] { "value1", "value2", "value3" };
        //}

        // GET api/values/5
        // also public IEnumerable<string>
        //  or public string[]
        // also remove ("{id}") from annotation. we don't need ID (yet)
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "This","exemplifies","live","updates","during","development" };
        }
        /*
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
        */
    }
}
