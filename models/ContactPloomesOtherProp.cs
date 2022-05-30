using Newtonsoft.Json;
namespace AutoMapperTest.models
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class ContactPloomesOtherProp
    {
        public string FieldKey { get; set; }
        public string StringValue { get; set; }
        public string BigStringValue { get; set; }
        public int IntegerValue { get; set; }
        public float DecimalValue { get; set; }
        public string DateTimeValue { get; set; }
        public bool BoolValue { get; set; }

    }
}