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
    /// Estimated fare details. Only products that don’t support upfront fares return this value.
    /// </summary>
    [DataContract(Name = "EstimateWithSurge_estimate")]
    public partial class EstimateWithSurgeEstimate : IEquatable<EstimateWithSurgeEstimate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EstimateWithSurgeEstimate" /> class.
        /// </summary>
        /// <param name="surgeConfirmationHref">The URL a user must visit to accept surge pricing..</param>
        /// <param name="highEstimate">Upper bound of the estimate..</param>
        /// <param name="surgeConfirmationId">A user’s unique surge session identifier. null if no surge is in effect..</param>
        /// <param name="minimum">The minimum trip fare. Only used and displayed if no end location is provided..</param>
        /// <param name="lowEstimate">Lower bound of the estimate..</param>
        /// <param name="fareBreakdown">Charges that contribute to the total fare. Trips with upfront pricing don’t have a breakdown..</param>
        /// <param name="surgeMultiplier">Expected surge multiplier. Surge is active if surge_multiplier is greater than 1. Fare estimates below factor in the surge multiplier..</param>
        /// <param name="display">Estimates are ranges except for the TAXI product, which uses “Metered”..</param>
        /// <param name="currencyCode">ISO 4217 currency code..</param>
        public EstimateWithSurgeEstimate(string surgeConfirmationHref = default(string), int highEstimate = default(int), string surgeConfirmationId = default(string), int minimum = default(int), int lowEstimate = default(int), List<EstimateWithSurgeEstimateFareBreakdownInner> fareBreakdown = default(List<EstimateWithSurgeEstimateFareBreakdownInner>), decimal surgeMultiplier = default(decimal), string display = default(string), string currencyCode = default(string))
        {
            this.SurgeConfirmationHref = surgeConfirmationHref;
            this.HighEstimate = highEstimate;
            this.SurgeConfirmationId = surgeConfirmationId;
            this.Minimum = minimum;
            this.LowEstimate = lowEstimate;
            this.FareBreakdown = fareBreakdown;
            this.SurgeMultiplier = surgeMultiplier;
            this.Display = display;
            this.CurrencyCode = currencyCode;
        }

        /// <summary>
        /// The URL a user must visit to accept surge pricing.
        /// </summary>
        /// <value>The URL a user must visit to accept surge pricing.</value>
        [DataMember(Name = "surge_confirmation_href", EmitDefaultValue = false)]
        public string SurgeConfirmationHref { get; set; }

        /// <summary>
        /// Upper bound of the estimate.
        /// </summary>
        /// <value>Upper bound of the estimate.</value>
        [DataMember(Name = "high_estimate", EmitDefaultValue = false)]
        public int HighEstimate { get; set; }

        /// <summary>
        /// A user’s unique surge session identifier. null if no surge is in effect.
        /// </summary>
        /// <value>A user’s unique surge session identifier. null if no surge is in effect.</value>
        [DataMember(Name = "surge_confirmation_id", EmitDefaultValue = false)]
        public string SurgeConfirmationId { get; set; }

        /// <summary>
        /// The minimum trip fare. Only used and displayed if no end location is provided.
        /// </summary>
        /// <value>The minimum trip fare. Only used and displayed if no end location is provided.</value>
        [DataMember(Name = "minimum", EmitDefaultValue = false)]
        public int Minimum { get; set; }

        /// <summary>
        /// Lower bound of the estimate.
        /// </summary>
        /// <value>Lower bound of the estimate.</value>
        [DataMember(Name = "low_estimate", EmitDefaultValue = false)]
        public int LowEstimate { get; set; }

        /// <summary>
        /// Charges that contribute to the total fare. Trips with upfront pricing don’t have a breakdown.
        /// </summary>
        /// <value>Charges that contribute to the total fare. Trips with upfront pricing don’t have a breakdown.</value>
        [DataMember(Name = "fare_breakdown", EmitDefaultValue = false)]
        public List<EstimateWithSurgeEstimateFareBreakdownInner> FareBreakdown { get; set; }

        /// <summary>
        /// Expected surge multiplier. Surge is active if surge_multiplier is greater than 1. Fare estimates below factor in the surge multiplier.
        /// </summary>
        /// <value>Expected surge multiplier. Surge is active if surge_multiplier is greater than 1. Fare estimates below factor in the surge multiplier.</value>
        [DataMember(Name = "surge_multiplier", EmitDefaultValue = false)]
        public decimal SurgeMultiplier { get; set; }

        /// <summary>
        /// Estimates are ranges except for the TAXI product, which uses “Metered”.
        /// </summary>
        /// <value>Estimates are ranges except for the TAXI product, which uses “Metered”.</value>
        [DataMember(Name = "display", EmitDefaultValue = false)]
        public string Display { get; set; }

        /// <summary>
        /// ISO 4217 currency code.
        /// </summary>
        /// <value>ISO 4217 currency code.</value>
        [DataMember(Name = "currency_code", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EstimateWithSurgeEstimate {\n");
            sb.Append("  SurgeConfirmationHref: ").Append(SurgeConfirmationHref).Append("\n");
            sb.Append("  HighEstimate: ").Append(HighEstimate).Append("\n");
            sb.Append("  SurgeConfirmationId: ").Append(SurgeConfirmationId).Append("\n");
            sb.Append("  Minimum: ").Append(Minimum).Append("\n");
            sb.Append("  LowEstimate: ").Append(LowEstimate).Append("\n");
            sb.Append("  FareBreakdown: ").Append(FareBreakdown).Append("\n");
            sb.Append("  SurgeMultiplier: ").Append(SurgeMultiplier).Append("\n");
            sb.Append("  Display: ").Append(Display).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
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
            return this.Equals(input as EstimateWithSurgeEstimate);
        }

        /// <summary>
        /// Returns true if EstimateWithSurgeEstimate instances are equal
        /// </summary>
        /// <param name="input">Instance of EstimateWithSurgeEstimate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EstimateWithSurgeEstimate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SurgeConfirmationHref == input.SurgeConfirmationHref ||
                    (this.SurgeConfirmationHref != null &&
                    this.SurgeConfirmationHref.Equals(input.SurgeConfirmationHref))
                ) && 
                (
                    this.HighEstimate == input.HighEstimate ||
                    this.HighEstimate.Equals(input.HighEstimate)
                ) && 
                (
                    this.SurgeConfirmationId == input.SurgeConfirmationId ||
                    (this.SurgeConfirmationId != null &&
                    this.SurgeConfirmationId.Equals(input.SurgeConfirmationId))
                ) && 
                (
                    this.Minimum == input.Minimum ||
                    this.Minimum.Equals(input.Minimum)
                ) && 
                (
                    this.LowEstimate == input.LowEstimate ||
                    this.LowEstimate.Equals(input.LowEstimate)
                ) && 
                (
                    this.FareBreakdown == input.FareBreakdown ||
                    this.FareBreakdown != null &&
                    input.FareBreakdown != null &&
                    this.FareBreakdown.SequenceEqual(input.FareBreakdown)
                ) && 
                (
                    this.SurgeMultiplier == input.SurgeMultiplier ||
                    this.SurgeMultiplier.Equals(input.SurgeMultiplier)
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
                if (this.SurgeConfirmationHref != null)
                {
                    hashCode = (hashCode * 59) + this.SurgeConfirmationHref.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HighEstimate.GetHashCode();
                if (this.SurgeConfirmationId != null)
                {
                    hashCode = (hashCode * 59) + this.SurgeConfirmationId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Minimum.GetHashCode();
                hashCode = (hashCode * 59) + this.LowEstimate.GetHashCode();
                if (this.FareBreakdown != null)
                {
                    hashCode = (hashCode * 59) + this.FareBreakdown.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SurgeMultiplier.GetHashCode();
                if (this.Display != null)
                {
                    hashCode = (hashCode * 59) + this.Display.GetHashCode();
                }
                if (this.CurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyCode.GetHashCode();
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
