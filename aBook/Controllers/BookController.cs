using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace aBook.Controllers
{
    public class BookController : ApiController
    {
        [Route("api/Book/GetString")]
        [HttpGet]
        public string GetString()
        {

        }
    }
}