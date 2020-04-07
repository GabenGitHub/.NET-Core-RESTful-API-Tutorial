using Microsoft.AspNetCore.Mvc;

namespace tweetbook.Controllers
{
    public class TestController : Controller
    {
        [HttpGet("api/user")]
        public IActionResult GetAction()
        {
            return Ok(new { name = "Nick" });
        }
    }
}