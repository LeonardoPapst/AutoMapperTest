using AutoMapper;
using AutoMapperTest.models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AutoMapperTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : Controller
    {
        private readonly IMapper mapper;

        public ContactController(IMapper mapper)
        {
            this.mapper = mapper;
        }

        [HttpPost]
        public IActionResult Test(JObject objPloo)
        {
            ContactPloomes test = JsonConvert.DeserializeObject<ContactPloomes>(objPloo.ToString());
            test.ConvertJsonOtherProp();
            ContactProtheus protheus = mapper.Map<ContactProtheus>(test);

            string json = JsonConvert.SerializeObject(protheus);

            return Ok(json);
        }

    }
}