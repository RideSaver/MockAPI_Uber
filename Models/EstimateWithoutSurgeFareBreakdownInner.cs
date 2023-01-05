/*
 * Uber API
 *
 * Uber Mock Api Specification
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace UberAPI.Models
{
    /// <summary>
    /// EstimateWithoutSurgeFareBreakdownInner
    /// </summary>
    [DataContract(Name = "EstimateWithoutSurge_fare_breakdown_inner")]
    public partial class EstimateWithoutSurgeFareBreakdownInner : IEquatable<EstimateWithoutSurgeFareBreakdownInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EstimateWithoutSurgeFareBreakdownInner" /> class.
        /// </summary>
        [JsonConstructor]
        protected EstimateWithoutSurgeFareBreakdownInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EstimateWithoutSurgeFareBreakdownInner" /> class.
        /// </summary>
        /// <param name="type">The type of breakdown this object represents. Can be base_fare or promotion. (required).</param>
        /// <param name="notice">A notice to show to the rider when a fare is higher than normal due to increased demand..</param>
        /// <param name="value">The value of this portion of the fare. This can be a negative or positive value. (required).</param>
        /// <param name="name">A string that can be displayed to the user representing this portion of the fare. (required).</param>
        public EstimateWithoutSurgeFareBreakdownInner(string type = default(string), string notice = default(string), decimal value = default(decimal), string name = default(string))
        {
            this.Type = type;
            this.Value = value;
            this.Name = name;
            this.Notice = notice;
        }

        /// <summary>
        /// The type of breakdown this object represents. Can be base_fare or promotion.
        /// </summary>
        /// <value>The type of breakdown this object represents. Can be base_fare or promotion.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// A notice to show to the rider when a fare is higher than normal due to increased demand.
        /// </summary>
        /// <value>A notice to show to the rider when a fare is higher than normal due to increased demand.</value>
        [DataMember(Name = "notice", EmitDefaultValue = false)]
        public string Notice { get; set; }

        /// <summary>
        /// The value of this portion of the fare. This can be a negative or positive value.
        /// </summary>
        /// <value>The value of this portion of the fare. This can be a negative or positive value.</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public decimal Value { get; set; }

        /// <summary>
        /// A string that can be displayed to the user representing this portion of the fare.
        /// </summary>
        /// <value>A string that can be displayed to the user representing this portion of the fare.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
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

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EstimateWithoutSurgeFareBreakdownInner);
        }

        /// <summary>
        /// Returns true if EstimateWithoutSurgeFareBreakdownInner instances are equal
        /// </summary>
        /// <param name="input">Instance of EstimateWithoutSurgeFareBreakdownInner to be compared</param>
        /// <returns>Boolean</returns>
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

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
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

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
