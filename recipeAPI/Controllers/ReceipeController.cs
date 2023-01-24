using Microsoft.AspNetCore.Mvc;

namespace recipeAPI.Controllers
{
    [Route("api/[controller]")]
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
        public Action deleteReceipe(string id)
        {
            return null;
        }
    }
}
