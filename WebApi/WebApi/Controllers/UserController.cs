using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class UserController : ApiController
    {
        //[AcceptVerbs("GET", "POST")]
        [HttpPost]
        [Authorize]
        public string Get([FromBody] string str) 
        {
           

            return "Tarik Davulcu";
        
        }
    }
}
