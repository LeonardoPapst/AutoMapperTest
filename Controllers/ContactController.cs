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
        [Route("PloomesToProtheus")]
        public IActionResult PloomesToProtheus(JObject objPloo)
        {
            ContactPloomes test = JsonConvert.DeserializeObject<ContactPloomes>(objPloo.ToString());
            test.ConvertJsonOtherProp();
            ContactProtheus protheus = mapper.Map<ContactProtheus>(test);

            string json = JsonConvert.SerializeObject(protheus);

            return Ok(json);
        }

        [HttpPost]
        [Route("ProtheusToPloomes")]
        public IActionResult ProtheusToPloomes(JObject objProt)
        {
            ContactProtheus test = JsonConvert.DeserializeObject<ContactProtheus>(objProt.ToString());
            test.ConvertJsonOtherProp();
            ContactPloomes ploo = mapper.Map<ContactPloomes>(test);
            string json = JsonConvert.SerializeObject(ploo);

            return Ok(json);
        }

    }
}