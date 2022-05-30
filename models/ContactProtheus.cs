using Newtonsoft.Json;
namespace AutoMapperTest.models
{
    public class ContactProtheus
    {
        [JsonPropertyAttribute("A1_COD")]
        public int Id { get; set; }

        [JsonPropertyAttribute("A1_NREDUZ")]
        public string Name { get; set; }

        [JsonPropertyAttribute("A1_NOME")]
        public string LegalName { get; set; }
        [JsonPropertyAttribute("A1_LOJA")]
        public int TypeId { get; set; }
    }
}