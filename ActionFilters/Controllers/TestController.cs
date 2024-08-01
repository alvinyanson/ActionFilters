using Microsoft.AspNetCore.Mvc;

namespace ActionFilters.Controllers
{
 
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : Controller
    {

        [HttpGet("view")]
        [AuthorizationFilter]
        public IActionResult ViewReport()
        {
            return Ok(new { success = true, message = "Report data" });
        }

        [HttpGet("export")]
        [AuthorizationFilter]
        public IActionResult ExportReport()
        {
            return Ok(new { success = true, message = "Report exported" });
        }
    }
}
