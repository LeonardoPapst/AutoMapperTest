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

        public ContactPloomesOtherProp(string fieldKey, string stringValue)
        {
            FieldKey = fieldKey;
            StringValue = stringValue;
            BigStringValue = stringValue;
        }
        public ContactPloomesOtherProp(string fieldKey, int integerValue)
        {
            FieldKey = fieldKey;
            IntegerValue = integerValue;
        }
        public ContactPloomesOtherProp(string fieldKey, float decimalValue)
        {
            FieldKey = fieldKey;
            DecimalValue = decimalValue;
        }
        public ContactPloomesOtherProp(string fieldKey, bool boolValue)
        {
            FieldKey = fieldKey;
            BoolValue = boolValue;
        }
        public ContactPloomesOtherProp(string fieldKey, DateTime dateTimeValue)
        {
            FieldKey = fieldKey;
            DateTimeValue = dateTimeValue.ToString();
        }
        public ContactPloomesOtherProp()
        { }

    }
}