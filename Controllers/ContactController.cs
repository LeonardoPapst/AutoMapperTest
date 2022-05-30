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
        public IActionResult Test(JObject objProt)
        {
            ContactProtheus test = JsonConvert.DeserializeObject<ContactProtheus>(objProt.ToString());
            ContactPloomes ploomes = mapper.Map<ContactPloomes>(test);
            ploomes.LegalName = "Leonardo Guerra Papst";
            return Ok(ploomes);
        }

    }
}