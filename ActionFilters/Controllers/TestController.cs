using Microsoft.AspNetCore.Mvc;

namespace ActionFilters.Controllers
{
 
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : Controller
    {

        [ServiceFilter(typeof(SampleActionFilter))]
        [HttpGet("get")]
        public ActionResult<string> Get()
        {
            return Ok(new { success = true, message = "Test message!" });
        }

        [HttpGet ("gettest")]
        public ActionResult<string> GetTest()
        {
            return Ok(new { success = true, message = "Test message!" });
        }

        [ServiceFilter(typeof(SampleAsyncActionFilter))]
        [HttpGet("gettestasync")]
        public ActionResult<string> GetTestAsync()
        {
            return Ok(new { success = true, message = "Test message!" });
        }

        [ResponseHeader("Filter-Header", "Filter Value")]
        [HttpGet("GetActionAttribute")]
        public ActionResult<string> GetActionAttribute()
        {
            return Ok(new { success = true, message = "Test message!" });
        }
    }
}
