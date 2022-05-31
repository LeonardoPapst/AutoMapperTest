using Newtonsoft.Json;
namespace AutoMapperTest.models
{
    public class ContactProtheus
    {
        [JsonIgnore]
        public int Id { get; set; }

        [JsonPropertyAttribute("A1_NREDUZ")]
        public string Name { get; set; }

        [JsonPropertyAttribute("A1_NOME")]
        public string LegalName { get; set; }

        [JsonIgnore]
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

        [JsonIgnore]
        public int IdTipo { get; set; }

        [JsonPropertyAttribute("A1_TIPO")]
        public string Tipo { get; set; }

        [JsonPropertyAttribute("A1_COD")]
        public string Codigo { get; set; }

        [JsonPropertyAttribute("A1_LOJA")]
        public string Loja { get; set; }

        [JsonIgnore]
        public List<ContactPloomesPhones> Phones { get; set; }
        [JsonIgnore]
        public List<ContactPloomesOtherProp> OtherProperties { get; set; }

        public void ConvertJsonOtherProp()
        {
            PlooLib.InstantiateConnection();
            OtherProperties = new List<ContactPloomesOtherProp>();
            OtherProperties.Add(new ContactPloomesOtherProp("contact_1B8EC404-830F-4E49-AD0D-A2665FDC69D4", Codigo));
            OtherProperties.Add(new ContactPloomesOtherProp("contact_CA8D65D1-6D75-411B-863F-D9E6F5ECDE0B", Loja));

            if (Tipo != "")
            {
                IdTipo = PlooLib.GetTableOptionId(Tipo, 43991);
                OtherProperties.Add(new ContactPloomesOtherProp("contact_C44E9AB3-4817-40D7-B68E-AF9D1ABDA536", IdTipo));
            }

            if (Pessoa == "J")
                TypeId = 1;
            else
                TypeId = 2;
        }
    }
}