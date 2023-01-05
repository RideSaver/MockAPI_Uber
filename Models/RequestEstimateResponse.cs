using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace UberAPI.Models
{
    [JsonConverter(typeof(RequestEstimateResponseJsonConverter))]
    [DataContract(Name = "RequestEstimateResponse")]
    public partial class RequestEstimateResponse : IEquatable<RequestEstimateResponse>, IValidatableObject
    {
        public RequestEstimateResponse(EstimateWithSurge actualInstance)
        {
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        public RequestEstimateResponse(EstimateWithoutSurge actualInstance)
        {
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        public Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(EstimateWithSurge))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(EstimateWithoutSurge))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: EstimateWithSurge, EstimateWithoutSurge");
                }
            }
        }

        public EstimateWithSurge GetEstimateWithSurge()
        {
            return (EstimateWithSurge)this.ActualInstance;
        }

        public EstimateWithoutSurge GetEstimateWithoutSurge()
        {
            return (EstimateWithoutSurge)this.ActualInstance;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestEstimateResponse {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        public static RequestEstimateResponse FromJson(string jsonString)
        {
            RequestEstimateResponse newRequestEstimateResponse = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newRequestEstimateResponse;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(EstimateWithSurge).GetProperty("AdditionalProperties") == null)
                {
                    newRequestEstimateResponse = new RequestEstimateResponse(JsonConvert.DeserializeObject<EstimateWithSurge>(jsonString));
                }
                else
                {
                    newRequestEstimateResponse = new RequestEstimateResponse(JsonConvert.DeserializeObject<EstimateWithSurge>(jsonString));
                }
                matchedTypes.Add("EstimateWithSurge");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into EstimateWithSurge: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(EstimateWithoutSurge).GetProperty("AdditionalProperties") == null)
                {
                    newRequestEstimateResponse = new RequestEstimateResponse(JsonConvert.DeserializeObject<EstimateWithoutSurge>(jsonString));
                }
                else
                {
                    newRequestEstimateResponse = new RequestEstimateResponse(JsonConvert.DeserializeObject<EstimateWithoutSurge>(jsonString));
                }
                matchedTypes.Add("EstimateWithoutSurge");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into EstimateWithoutSurge: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newRequestEstimateResponse;
        }

        public override bool Equals(object input)
        {
            return this.Equals(input as RequestEstimateResponse);
        }

        public bool Equals(RequestEstimateResponse input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
                return hashCode;
            }
        }

        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    public class RequestEstimateResponseJsonConverter : JsonConverter
    {

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(RequestEstimateResponse).GetMethod("ToJson").Invoke(value, null)));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return RequestEstimateResponse.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
