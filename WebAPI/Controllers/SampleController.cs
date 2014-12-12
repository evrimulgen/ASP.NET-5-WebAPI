using Microsoft.AspNet.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class SampleController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "Hello World!";
        }
        [HttpPost]
        public string Post([FromBody]Test test)
        {
            return "Hello " + test.Name + " " + test.Surname + ", " + test.Age.ToString() + ".";
        }
    }

}
