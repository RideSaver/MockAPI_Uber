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
    /// The upfront fare details.
    /// </summary>
    [DataContract(Name = "EstimateWithoutSurge_fare")]
    public partial class EstimateWithoutSurgeFare : IEquatable<EstimateWithoutSurgeFare>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EstimateWithoutSurgeFare" /> class.
        /// </summary>
        /// <param name="value">The total upfront fare value..</param>
        /// <param name="fareId">A unique upfront fare identifier..</param>
        /// <param name="expiresAt">The fare_id expiration as a Unix timestamp..</param>
        /// <param name="display">Formatted string of estimate in local currency..</param>
        /// <param name="currencyCode">ISO 4217 currency code..</param>
        /// <param name="breakdown">An array of objects which make up the fare. The value of these objects can be summed to arrive at fare.value..</param>
        public EstimateWithoutSurgeFare(decimal value = default(decimal), string fareId = default(string), int expiresAt = default(int), string display = default(string), string currencyCode = default(string), List<EstimateWithoutSurgeFareBreakdownInner> breakdown = default(List<EstimateWithoutSurgeFareBreakdownInner>))
        {
            this.Value = value;
            this.FareId = fareId;
            this.ExpiresAt = expiresAt;
            this.Display = display;
            this.CurrencyCode = currencyCode;
            this.Breakdown = breakdown;
        }

        /// <summary>
        /// The total upfront fare value.
        /// </summary>
        /// <value>The total upfront fare value.</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public decimal Value { get; set; }

        /// <summary>
        /// A unique upfront fare identifier.
        /// </summary>
        /// <value>A unique upfront fare identifier.</value>
        [DataMember(Name = "fare_id", EmitDefaultValue = false)]
        public string FareId { get; set; }

        /// <summary>
        /// The fare_id expiration as a Unix timestamp.
        /// </summary>
        /// <value>The fare_id expiration as a Unix timestamp.</value>
        [DataMember(Name = "expires_at", EmitDefaultValue = false)]
        public int ExpiresAt { get; set; }

        /// <summary>
        /// Formatted string of estimate in local currency.
        /// </summary>
        /// <value>Formatted string of estimate in local currency.</value>
        [DataMember(Name = "display", EmitDefaultValue = false)]
        public string Display { get; set; }

        /// <summary>
        /// ISO 4217 currency code.
        /// </summary>
        /// <value>ISO 4217 currency code.</value>
        [DataMember(Name = "currency_code", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// An array of objects which make up the fare. The value of these objects can be summed to arrive at fare.value.
        /// </summary>
        /// <value>An array of objects which make up the fare. The value of these objects can be summed to arrive at fare.value.</value>
        [DataMember(Name = "breakdown", EmitDefaultValue = false)]
        public List<EstimateWithoutSurgeFareBreakdownInner> Breakdown { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EstimateWithoutSurgeFare {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  FareId: ").Append(FareId).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  Display: ").Append(Display).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  Breakdown: ").Append(Breakdown).Append("\n");
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
            return this.Equals(input as EstimateWithoutSurgeFare);
        }

        /// <summary>
        /// Returns true if EstimateWithoutSurgeFare instances are equal
        /// </summary>
        /// <param name="input">Instance of EstimateWithoutSurgeFare to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EstimateWithoutSurgeFare input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
                ) && 
                (
                    this.FareId == input.FareId ||
                    (this.FareId != null &&
                    this.FareId.Equals(input.FareId))
                ) && 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    this.ExpiresAt.Equals(input.ExpiresAt)
                ) && 
                (
                    this.Display == input.Display ||
                    (this.Display != null &&
                    this.Display.Equals(input.Display))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.Breakdown == input.Breakdown ||
                    this.Breakdown != null &&
                    input.Breakdown != null &&
                    this.Breakdown.SequenceEqual(input.Breakdown)
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
                hashCode = (hashCode * 59) + this.Value.GetHashCode();
                if (this.FareId != null)
                {
                    hashCode = (hashCode * 59) + this.FareId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExpiresAt.GetHashCode();
                if (this.Display != null)
                {
                    hashCode = (hashCode * 59) + this.Display.GetHashCode();
                }
                if (this.CurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyCode.GetHashCode();
                }
                if (this.Breakdown != null)
                {
                    hashCode = (hashCode * 59) + this.Breakdown.GetHashCode();
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
