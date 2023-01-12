using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UberAPI.Models
{ 
    /// <summary>
    /// CreateRequests
    /// </summary>
    [DataContract(Name = "CreateRequests")]
    public partial class CreateRequests : IEquatable<CreateRequests>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequests" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateRequests() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequests" /> class.
        /// </summary>
        /// <param name="fareId">The key for the upfront fare of a ride. (required).</param>
        /// <param name="productId">The unique ID of the product being requested. (required).</param>
        /// <param name="startLatitude">The beginning or “pickup” latitude. Either this or start_place_id must be specified. (required).</param>
        /// <param name="endLatitude">The final or destination latitude. Either this or end_place_id may be specified. (required).</param>
        /// <param name="startLongitude">The beginning or “pickup” longitude. Either this or start_place_id must be specified. (required).</param>
        /// <param name="endLongitude">The final or destination longitude. Either this or end_place_id may be specified./td&gt; (required).</param>
        /// <param name="surgeConfirmationId">The unique identifier of the surge session for a user. Required when returned from a 409 Conflict response on previous POST attempt..</param>
        /// <param name="paymentMethodId">The unique identifier of the payment method selected by a user. If set, the trip will be requested using this payment method. If not set, the trip will be requested using the user&#39;s last used payment method..</param>
        /// <param name="seats">The number of seats required for uberPOOL. Default and maximum value is 2..</param>
        public CreateRequests(string fareId = default(string), string productId = default(string), float startLatitude = default(float), float endLatitude = default(float), float startLongitude = default(float), float endLongitude = default(float), string surgeConfirmationId = default(string), string paymentMethodId = default(string), int seats = default(int))
        {
            this.FareId = fareId;
            this.ProductId = productId;
            this.StartLatitude = startLatitude;
            this.EndLatitude = endLatitude;
            this.StartLongitude = startLongitude;
            this.EndLongitude = endLongitude;
            this.SurgeConfirmationId = surgeConfirmationId;
            this.PaymentMethodId = paymentMethodId;
            this.Seats = seats;
        }

        /// <summary>
        /// The key for the upfront fare of a ride.
        /// </summary>
        /// <value>The key for the upfront fare of a ride.</value>
        [DataMember(Name = "fare_id", IsRequired = true)]
        public string FareId { get; set; }

        /// <summary>
        /// The unique ID of the product being requested.
        /// </summary>
        /// <value>The unique ID of the product being requested.</value>
        [DataMember(Name = "product_id", IsRequired = true)]
        public string ProductId { get; set; }

        /// <summary>
        /// The beginning or “pickup” latitude. Either this or start_place_id must be specified.
        /// </summary>
        /// <value>The beginning or “pickup” latitude. Either this or start_place_id must be specified.</value>
        [DataMember(Name = "start_latitude", IsRequired = true)]
        public float StartLatitude { get; set; }

        /// <summary>
        /// The final or destination latitude. Either this or end_place_id may be specified.
        /// </summary>
        /// <value>The final or destination latitude. Either this or end_place_id may be specified.</value>
        [DataMember(Name = "end_latitude", IsRequired = true)]
        public float EndLatitude { get; set; }

        /// <summary>
        /// The beginning or “pickup” longitude. Either this or start_place_id must be specified.
        /// </summary>
        /// <value>The beginning or “pickup” longitude. Either this or start_place_id must be specified.</value>
        [DataMember(Name = "start_longitude", IsRequired = true)]
        public float StartLongitude { get; set; }

        /// <summary>
        /// The final or destination longitude. Either this or end_place_id may be specified./td&gt;
        /// </summary>
        /// <value>The final or destination longitude. Either this or end_place_id may be specified./td&gt;</value>
        [DataMember(Name = "end_longitude", IsRequired = true)]
        public float EndLongitude { get; set; }

        /// <summary>
        /// The unique identifier of the surge session for a user. Required when returned from a 409 Conflict response on previous POST attempt.
        /// </summary>
        /// <value>The unique identifier of the surge session for a user. Required when returned from a 409 Conflict response on previous POST attempt.</value>
        [DataMember(Name = "surge_confirmation_id")]
        public string SurgeConfirmationId { get; set; }

        /// <summary>
        /// The unique identifier of the payment method selected by a user. If set, the trip will be requested using this payment method. If not set, the trip will be requested using the user&#39;s last used payment method.
        /// </summary>
        /// <value>The unique identifier of the payment method selected by a user. If set, the trip will be requested using this payment method. If not set, the trip will be requested using the user&#39;s last used payment method.</value>
        [DataMember(Name = "payment_method_id")]
        public string PaymentMethodId { get; set; }

        /// <summary>
        /// The number of seats required for uberPOOL. Default and maximum value is 2.
        /// </summary>
        /// <value>The number of seats required for uberPOOL. Default and maximum value is 2.</value>
        [DataMember(Name = "seats")]
        public int Seats { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateRequests {\n");
            sb.Append("  FareId: ").Append(FareId).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  StartLatitude: ").Append(StartLatitude).Append("\n");
            sb.Append("  EndLatitude: ").Append(EndLatitude).Append("\n");
            sb.Append("  StartLongitude: ").Append(StartLongitude).Append("\n");
            sb.Append("  EndLongitude: ").Append(EndLongitude).Append("\n");
            sb.Append("  SurgeConfirmationId: ").Append(SurgeConfirmationId).Append("\n");
            sb.Append("  PaymentMethodId: ").Append(PaymentMethodId).Append("\n");
            sb.Append("  Seats: ").Append(Seats).Append("\n");
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
            return this.Equals(input as CreateRequests);
        }

        /// <summary>
        /// Returns true if CreateRequests instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateRequests to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateRequests input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FareId == input.FareId ||
                    (this.FareId != null &&
                    this.FareId.Equals(input.FareId))
                ) && 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.StartLatitude == input.StartLatitude ||
                    this.StartLatitude.Equals(input.StartLatitude)
                ) && 
                (
                    this.EndLatitude == input.EndLatitude ||
                    this.EndLatitude.Equals(input.EndLatitude)
                ) && 
                (
                    this.StartLongitude == input.StartLongitude ||
                    this.StartLongitude.Equals(input.StartLongitude)
                ) && 
                (
                    this.EndLongitude == input.EndLongitude ||
                    this.EndLongitude.Equals(input.EndLongitude)
                ) && 
                (
                    this.SurgeConfirmationId == input.SurgeConfirmationId ||
                    (this.SurgeConfirmationId != null &&
                    this.SurgeConfirmationId.Equals(input.SurgeConfirmationId))
                ) && 
                (
                    this.PaymentMethodId == input.PaymentMethodId ||
                    (this.PaymentMethodId != null &&
                    this.PaymentMethodId.Equals(input.PaymentMethodId))
                ) && 
                (
                    this.Seats == input.Seats ||
                    this.Seats.Equals(input.Seats)
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
                if (this.FareId != null)
                {
                    hashCode = (hashCode * 59) + this.FareId.GetHashCode();
                }
                if (this.ProductId != null)
                {
                    hashCode = (hashCode * 59) + this.ProductId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.StartLatitude.GetHashCode();
                hashCode = (hashCode * 59) + this.EndLatitude.GetHashCode();
                hashCode = (hashCode * 59) + this.StartLongitude.GetHashCode();
                hashCode = (hashCode * 59) + this.EndLongitude.GetHashCode();
                if (this.SurgeConfirmationId != null)
                {
                    hashCode = (hashCode * 59) + this.SurgeConfirmationId.GetHashCode();
                }
                if (this.PaymentMethodId != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentMethodId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Seats.GetHashCode();
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

            // to ensure "fareId" is required (not null)
            if (FareId == null)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("fareId is a required property for CreateRequests and cannot be null");
            }

            // to ensure "productId" is required (not null)
            if (ProductId == null)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("productId is a required property for CreateRequests and cannot be null");
            }







            yield break;
        }
    }
}
