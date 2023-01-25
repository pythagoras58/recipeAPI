using Microsoft.AspNetCore.Mvc;

namespace recipeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceipeController : ControllerBase
    {
        [HttpGet]
        public string[] getDishes()
        {
            string[] dishes = {"Fufu", "Banku", "Yam"};
            return dishes;
        }

        [HttpGet]
        public ActionResult GetReceipes()
        {
            return null;
        }

        [HttpPost]
        public ActionResult createNewReceipe()
        {
            return null;
        }

        [HttpDelete]
        public ActionResult deleteReceipe(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            return NoContent();
        }

        [HttpPatch]
        public IActionResult updateReceipe(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            return NoContent();
        }
    }
}
