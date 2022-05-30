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
        private readonly IConfiguration myConfig;

        public ContactController(IMapper mapper, IConfiguration myConfig)
        {
            this.mapper = mapper;
            this.myConfig = myConfig;
            PlooLib.UK = myConfig.GetValue<string>("Secrets:UK");
        }

        [HttpPost]
        public IActionResult Test(JObject objPloo)
        {
            ContactPloomes test = JsonConvert.DeserializeObject<ContactPloomes>(objPloo.ToString());
            PlooLib.InstantiateConnection();
            test.ConvertJsonOtherProp();
            ContactProtheus protheus = mapper.Map<ContactProtheus>(test);

            string json = JsonConvert.SerializeObject(protheus);

            return Ok(json);
        }

    }
}