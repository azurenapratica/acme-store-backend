using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AZDONaPratica.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace AZDONaPratica.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return new List<Product>
            {
                new Product("Huawei MediaPad", "new_1.jpg", 500, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas fermentum laoreet."),
                new Product("Huawei MediaPad", "new_5.jpg", 500, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas fermentum laoreet."),
                new Product("Huawei MediaPad", "new_8.jpg", 500, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas fermentum laoreet."),
                new Product("Huawei MediaPad", "best_3.png", 500, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas fermentum laoreet."),
                new Product("Huawei MediaPad", "featured_2.png", 500, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas fermentum laoreet."),
                new Product("Huawei MediaPad", "featured_8.png", 500, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas fermentum laoreet."),
                new Product("Huawei MediaPad", "new_1.jpg", 500, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas fermentum laoreet."),
                new Product("Huawei MediaPad", "new_1.jpg", 500, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas fermentum laoreet."),
                new Product("Huawei MediaPad", "new_1.jpg", 500, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas fermentum laoreet."),
                new Product("Huawei MediaPad", "new_1.jpg", 500, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas fermentum laoreet."),
                new Product("Huawei MediaPad", "new_1.jpg", 500, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas fermentum laoreet."),
                new Product("Huawei MediaPad", "new_1.jpg", 500, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas fermentum laoreet.")
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
