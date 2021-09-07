﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestMVCAPI.Controllers
{
    public class TestAPIController : ApiController
    {
        // GET: api/TestAPI
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/TestAPI/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TestAPI
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TestAPI/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TestAPI/5
        public void Delete(int id)
        {
        }
    }
}
