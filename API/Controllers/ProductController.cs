using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProductController:ControllerBase
    {

        [HttpGet]

        public string GetProducts()
        {

            return "hello mostafa";
        }

        [HttpGet("id")]
        public string GetProducts(int id)
        {
            return "Hello Mostafa khairalla" + id;
        }
    }
}
