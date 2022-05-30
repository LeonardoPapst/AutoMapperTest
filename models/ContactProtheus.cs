using Newtonsoft.Json;
namespace AutoMapperTest.models
{
    public class ContactProtheus
    {
        public int Id { get; set; }

        [JsonPropertyAttribute("A1_NREDUZ")]
        public string Name { get; set; }

        [JsonPropertyAttribute("A1_NOME")]
        public string LegalName { get; set; }

        public int TypeId { get; set; }

        [JsonPropertyAttribute("A1_CGC")]
        public string Register { get; set; }

        [JsonPropertyAttribute("A1_EMAIL")]
        public string Email { get; set; }

        [JsonPropertyAttribute("A1_END")]
        public string StreetAddress { get; set; }

        [JsonPropertyAttribute("A1_COMPLEM")]
        public string StreetAddress2 { get; set; }

        [JsonPropertyAttribute("A1_DDD")]
        public string DDD { get; set; }

        [JsonPropertyAttribute("A1_TEL")]
        public string Telefone { get; set; }

        [JsonPropertyAttribute("A1_PESSOA")]
        public string Pessoa { get; set; }

        [JsonPropertyAttribute("A1_TIPO")]
        public string Tipo { get; set; }

        [JsonPropertyAttribute("A1_COD")]
        public string Codigo { get; set; }

        [JsonPropertyAttribute("A1_LOJA")]
        public string Loja { get; set; }
    }
}