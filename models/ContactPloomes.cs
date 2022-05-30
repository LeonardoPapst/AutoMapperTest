using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace AutoMapperTest.models
{
    public class ContactPloomes
    {
        [JsonPropertyAttribute("Id")]
        public int Id { get; set; }
        [JsonPropertyAttribute("Name")]
        public string Name { get; set; }

        [JsonPropertyAttribute("LegalName")]
        public string LegalName { get; set; }
        [JsonPropertyAttribute("TypeId")]
        public int TypeId { get; set; }

    }
}