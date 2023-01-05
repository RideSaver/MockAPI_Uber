using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace UberAPI.Models
{
    [DataContract(Name = "EstimateWithoutSurge_fare_breakdown_inner")]
    public class EstimateWithoutSurgeFareBreakdownInner : IEquatable<EstimateWithoutSurgeFareBreakdownInner>, IValidatableObject
    {
        [JsonConstructor]
        protected EstimateWithoutSurgeFareBreakdownInner() { }
        public EstimateWithoutSurgeFareBreakdownInner(string type = default(string), string notice = default(string), decimal value = default(decimal), string name = default(string))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for EstimateWithoutSurgeFareBreakdownInner and cannot be null");
            }
            this.Type = type;
            this.Value = value;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for EstimateWithoutSurgeFareBreakdownInner and cannot be null");
            }
            this.Name = name;
            this.Notice = notice;
        }

        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        [DataMember(Name = "notice", EmitDefaultValue = false)]
        public string Notice { get; set; }

        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public decimal Value { get; set; }

        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EstimateWithoutSurgeFareBreakdownInner {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Notice: ").Append(Notice).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }
        public override bool Equals(object input)
        {
            return this.Equals(input as EstimateWithoutSurgeFareBreakdownInner);
        }
        public bool Equals(EstimateWithoutSurgeFareBreakdownInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Notice == input.Notice ||
                    (this.Notice != null &&
                    this.Notice.Equals(input.Notice))
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Notice != null)
                {
                    hashCode = (hashCode * 59) + this.Notice.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Value.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                return hashCode;
            }
        }
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
