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
    }
}
