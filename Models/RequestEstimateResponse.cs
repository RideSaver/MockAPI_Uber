using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using UberAPI.Helper;

namespace UberAPI.Models
{
    [JsonConverter(typeof(RequestEstimateResponseJsonConverter))]
    [DataContract(Name = "RequestEstimateResponse")]
    public class RequestEstimateResponse : ModelValidation, IEquatable<RequestEstimateResponse>, IValidatableObject
    {
        public RequestEstimateResponse(EstimateWithSurge actualInstance)
        {
            IsNullable = false;
            SchemaType = "oneOf";
            ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        public RequestEstimateResponse(EstimateWithoutSurge actualInstance)
        {
            IsNullable = false;
            SchemaType = "oneOf";
            ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        private object _actualInstance;
        public override object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(EstimateWithSurge))
                {
                    _actualInstance = value;
                }
                else if (value.GetType() == typeof(EstimateWithoutSurge))
                {
                    _actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: EstimateWithSurge, EstimateWithoutSurge");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `EstimateWithSurge`. If the actual instance is not `EstimateWithSurge`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of EstimateWithSurge</returns>
        public EstimateWithSurge GetEstimateWithSurge()
        {
            return (EstimateWithSurge)ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `EstimateWithoutSurge`. If the actual instance is not `EstimateWithoutSurge`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of EstimateWithoutSurge</returns>
        public EstimateWithoutSurge GetEstimateWithoutSurge()
        {
            return (EstimateWithoutSurge)ActualInstance;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestEstimateResponse {\n");
            sb.Append("  ActualInstance: ").Append(ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        public override string ToJson()
        {
            return JsonConvert.SerializeObject(ActualInstance, SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of RequestEstimateResponse
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of RequestEstimateResponse</returns>
        public static RequestEstimateResponse FromJson(string jsonString)
        {
            RequestEstimateResponse? newRequestEstimateResponse = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newRequestEstimateResponse!;
            }
            int match = 0;
            List<string> matchedTypes = new();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(EstimateWithSurge).GetProperty("AdditionalProperties") == null)
                {
                    newRequestEstimateResponse = new RequestEstimateResponse(JsonConvert.DeserializeObject<EstimateWithSurge>(jsonString, RequestEstimateResponse.SerializerSettings));
                }
                else
                {
                    newRequestEstimateResponse = new RequestEstimateResponse(JsonConvert.DeserializeObject<EstimateWithSurge>(jsonString, RequestEstimateResponse.AdditionalPropertiesSerializerSettings));
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
                    newRequestEstimateResponse = new RequestEstimateResponse(JsonConvert.DeserializeObject<EstimateWithoutSurge>(jsonString, RequestEstimateResponse.SerializerSettings));
                }
                else
                {
                    newRequestEstimateResponse = new RequestEstimateResponse(JsonConvert.DeserializeObject<EstimateWithoutSurge>(jsonString, RequestEstimateResponse.AdditionalPropertiesSerializerSettings));
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
            return newRequestEstimateResponse!;
        }

        public override bool Equals(object? input)
        {
            return Equals((RequestEstimateResponse)input!);
        }

        public bool Equals(RequestEstimateResponse? input)
        {
            if (input == null)
                return false;

            return ActualInstance.Equals(input.ActualInstance);
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

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for RequestEstimateResponse
    /// </summary>
    public class RequestEstimateResponseJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((typeof(RequestEstimateResponse)!.GetMethod("ToJson").Invoke(value, null)) as string);
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object? ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.Null)
            {
                return RequestEstimateResponse.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
