using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Configuration;

namespace CH.Controllers
{
    public class HelloController : ApiController
    {
        string strOutputText = "Hello World";

        public IHttpActionResult GetOutputText()
        {
            return Ok(strOutputText);
        }

        public IHttpActionResult WriteOutputText()
        {
            var databaseString = ConfigurationManager.AppSettings["DatabaseString"];
            if (databaseString != null && databaseString.ToString() != "")
            {
                // Insert future call to a database here
                // Ex:
                // private Repository rep(databasestring);
                // rep.WriteToDatabase(strOutputText);
                return Ok(strOutputText);
            }
            else
            {
                return Ok("Error writing to database");
            }
        }
    }
}
