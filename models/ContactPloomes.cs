using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace AutoMapperTest.models
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class ContactPloomes
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string LegalName { get; set; }
        public int TypeId { get; set; }
        public string Register { get; set; }
        public string Email { get; set; }
        public string StreetAddress { get; set; }
        public string StreetAddress2 { get; set; }
        public string Tipo { get; set; }
        public int IdTipo { get; set; }
        public string Codigo { get; set; }
        public string Loja { get; set; }
        public List<ContactPloomesPhones> Phones { get; set; }
        public List<ContactPloomesOtherProp> OtherProperties { get; set; }

        public void ConvertJsonOtherProp()
        {
            try
            {
                Codigo = (OtherProperties.Find(x => x.FieldKey == "contact_1B8EC404-830F-4E49-AD0D-A2665FDC69D4").StringValue);
            }
            catch (Exception)
            { Codigo = ""; }
            try
            {
                Loja = (OtherProperties.Find(x => x.FieldKey == "contact_CA8D65D1-6D75-411B-863F-D9E6F5ECDE0B").StringValue);
            }
            catch (Exception)
            { Loja = ""; }

            try
            {
                IdTipo = (OtherProperties.Find(x => x.FieldKey == "contact_C44E9AB3-4817-40D7-B68E-AF9D1ABDA536").IntegerValue);
                Tipo = PlooLib.GetTableOptionName(IdTipo, 43991);
                if (Tipo != "")
                    Tipo = Tipo.Split("-")[0].Trim();
            }
            catch (Exception)
            { IdTipo = 0; Tipo = ""; }

        }

    }
}