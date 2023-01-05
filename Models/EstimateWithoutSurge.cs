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
using FileParameter = UberAPI.Client.Client.FileParameter;
using OpenAPIDateConverter = UberAPI.Client.Client.OpenAPIDateConverter;

namespace UberAPI.Client.Model
{
    /// <summary>
    /// EstimateWithoutSurge
    /// </summary>
    [DataContract(Name = "EstimateWithoutSurge")]
    public partial class EstimateWithoutSurge : IEquatable<EstimateWithoutSurge>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EstimateWithoutSurge" /> class.
        /// </summary>
        /// <param name="fare">fare.</param>
        /// <param name="trip">trip.</param>
        /// <param name="pickupEstimate">The estimate vehicle arrival time in minutes. null if no cars are available..</param>
        public EstimateWithoutSurge(EstimateWithoutSurgeFare fare = default(EstimateWithoutSurgeFare), EstimateWithoutSurgeTrip trip = default(EstimateWithoutSurgeTrip), int pickupEstimate = default(int))
        {
            this.Fare = fare;
            this.Trip = trip;
            this.PickupEstimate = pickupEstimate;
        }

        /// <summary>
        /// Gets or Sets Fare
        /// </summary>
        [DataMember(Name = "fare", EmitDefaultValue = false)]
        public EstimateWithoutSurgeFare Fare { get; set; }

        /// <summary>
        /// Gets or Sets Trip
        /// </summary>
        [DataMember(Name = "trip", EmitDefaultValue = false)]
        public EstimateWithoutSurgeTrip Trip { get; set; }

        /// <summary>
        /// The estimate vehicle arrival time in minutes. null if no cars are available.
        /// </summary>
        /// <value>The estimate vehicle arrival time in minutes. null if no cars are available.</value>
        [DataMember(Name = "pickup_estimate", EmitDefaultValue = false)]
        public int PickupEstimate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EstimateWithoutSurge {\n");
            sb.Append("  Fare: ").Append(Fare).Append("\n");
            sb.Append("  Trip: ").Append(Trip).Append("\n");
            sb.Append("  PickupEstimate: ").Append(PickupEstimate).Append("\n");
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
            return this.Equals(input as EstimateWithoutSurge);
        }

        /// <summary>
        /// Returns true if EstimateWithoutSurge instances are equal
        /// </summary>
        /// <param name="input">Instance of EstimateWithoutSurge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EstimateWithoutSurge input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Fare == input.Fare ||
                    (this.Fare != null &&
                    this.Fare.Equals(input.Fare))
                ) && 
                (
                    this.Trip == input.Trip ||
                    (this.Trip != null &&
                    this.Trip.Equals(input.Trip))
                ) && 
                (
                    this.PickupEstimate == input.PickupEstimate ||
                    this.PickupEstimate.Equals(input.PickupEstimate)
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
                if (this.Fare != null)
                {
                    hashCode = (hashCode * 59) + this.Fare.GetHashCode();
                }
                if (this.Trip != null)
                {
                    hashCode = (hashCode * 59) + this.Trip.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PickupEstimate.GetHashCode();
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
