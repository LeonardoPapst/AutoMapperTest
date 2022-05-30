using AutoMapper;
using AutoMapperTest.models;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet]
        public IActionResult Test()
        {
            ContactProtheus test = new ContactProtheus();
            ContactPloomes ploomes = mapper.Map<ContactPloomes>(test);
            return Ok();
        }

    }
}