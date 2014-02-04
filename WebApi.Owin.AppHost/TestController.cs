using System.Collections.Generic;
using System.Web.Http;

namespace WebApi.Owin.AppHost
{
    public class TestController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new[] {"string1", "string2"};
        }

        public string Get(int id)
        {
            return "Id: " + id;
        }

        public string Post()
        {
            return "posted string: ";
        }
    }
}