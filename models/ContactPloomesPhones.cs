using Newtonsoft.Json;
namespace AutoMapperTest.models
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class ContactPloomesPhones
    {
        public int Id { get; set; }
        public int ContactId { get; set; }
        public string PhoneNumber { get; set; }
        public double SearchPhoneNumber { get; set; }
        public int TypeId { get; set; }
        public int CountryId { get; set; }
    }
}