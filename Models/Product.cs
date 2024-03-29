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
    /// Product
    /// </summary>
    [DataContract(Name = "Product")]
    public partial class Product : IEquatable<Product>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product" /> class.
        /// </summary>
        /// <param name="upfrontFareEnabled">upfrontFareEnabled.</param>
        /// <param name="capacity">Capacity of product. For example, 4 people..</param>
        /// <param name="productId">Unique identifier representing a specific product for a given latitude &amp; longitude. For example, uberX in San Francisco will have a different product_id than uberX in Los Angeles..</param>
        /// <param name="priceDetails">priceDetails.</param>
        /// <param name="image">Image URL representing the product..</param>
        /// <param name="cashEnabled">Specifies whether this product allows cash payments.</param>
        /// <param name="shared">Specifies whether this product allows for the pickup and drop off of other riders during the trip.</param>
        /// <param name="shortDescription">An abbreviated description of the product. Localized according to Accept-Language header..</param>
        /// <param name="displayName">Display name of product..</param>
        /// <param name="productGroup">The product group that this product belongs to. One of rideshare,uberx,uberxl,uberblack, suv, or taxi..</param>
        /// <param name="description">Description of product..</param>
        public Product(bool upfrontFareEnabled = default(bool), int capacity = default(int), string productId = default(string), ProductPriceDetails priceDetails = default(ProductPriceDetails), string image = default(string), bool cashEnabled = default(bool), bool shared = default(bool), string shortDescription = default(string), string displayName = default(string), string productGroup = default(string), string description = default(string))
        {
            this.UpfrontFareEnabled = upfrontFareEnabled;
            this.Capacity = capacity;
            this.ProductId = productId;
            this.PriceDetails = priceDetails;
            this.Image = image;
            this.CashEnabled = cashEnabled;
            this.Shared = shared;
            this.ShortDescription = shortDescription;
            this.DisplayName = displayName;
            this.ProductGroup = productGroup;
            this.Description = description;
        }

        /// <summary>
        /// Gets or Sets UpfrontFareEnabled
        /// </summary>
        [DataMember]
        public bool UpfrontFareEnabled { get; set; }

        /// <summary>
        /// Capacity of product. For example, 4 people.
        /// </summary>
        /// <value>Capacity of product. For example, 4 people.</value>
        [DataMember]
        public int Capacity { get; set; }

        /// <summary>
        /// Unique identifier representing a specific product for a given latitude &amp; longitude. For example, uberX in San Francisco will have a different product_id than uberX in Los Angeles.
        /// </summary>
        /// <value>Unique identifier representing a specific product for a given latitude &amp; longitude. For example, uberX in San Francisco will have a different product_id than uberX in Los Angeles.</value>
        [DataMember]
        public string ProductId { get; set; }

        /// <summary>
        /// Gets or Sets PriceDetails
        /// </summary>
        [DataMember]
        public ProductPriceDetails PriceDetails { get; set; }

        /// <summary>
        /// Image URL representing the product.
        /// </summary>
        /// <value>Image URL representing the product.</value>
        [DataMember]
        public string Image { get; set; }

        /// <summary>
        /// Specifies whether this product allows cash payments
        /// </summary>
        /// <value>Specifies whether this product allows cash payments</value>
        [DataMember]
        public bool CashEnabled { get; set; }

        /// <summary>
        /// Specifies whether this product allows for the pickup and drop off of other riders during the trip
        /// </summary>
        /// <value>Specifies whether this product allows for the pickup and drop off of other riders during the trip</value>
        [DataMember]
        public bool Shared { get; set; }

        /// <summary>
        /// An abbreviated description of the product. Localized according to Accept-Language header.
        /// </summary>
        /// <value>An abbreviated description of the product. Localized according to Accept-Language header.</value>
        [DataMember]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Display name of product.
        /// </summary>
        /// <value>Display name of product.</value>
        [DataMember]
        public string DisplayName { get; set; }

        /// <summary>
        /// The product group that this product belongs to. One of rideshare,uberx,uberxl,uberblack, suv, or taxi.
        /// </summary>
        /// <value>The product group that this product belongs to. One of rideshare,uberx,uberxl,uberblack, suv, or taxi.</value>
        [DataMember]
        public string ProductGroup { get; set; }

        /// <summary>
        /// Description of product.
        /// </summary>
        /// <value>Description of product.</value>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Product {\n");
            sb.Append("  UpfrontFareEnabled: ").Append(UpfrontFareEnabled).Append("\n");
            sb.Append("  Capacity: ").Append(Capacity).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  PriceDetails: ").Append(PriceDetails).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  CashEnabled: ").Append(CashEnabled).Append("\n");
            sb.Append("  Shared: ").Append(Shared).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  ProductGroup: ").Append(ProductGroup).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as Product);
        }

        /// <summary>
        /// Returns true if Product instances are equal
        /// </summary>
        /// <param name="input">Instance of Product to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Product input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UpfrontFareEnabled == input.UpfrontFareEnabled ||
                    this.UpfrontFareEnabled.Equals(input.UpfrontFareEnabled)
                ) && 
                (
                    this.Capacity == input.Capacity ||
                    this.Capacity.Equals(input.Capacity)
                ) && 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.PriceDetails == input.PriceDetails ||
                    (this.PriceDetails != null &&
                    this.PriceDetails.Equals(input.PriceDetails))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.CashEnabled == input.CashEnabled ||
                    this.CashEnabled.Equals(input.CashEnabled)
                ) && 
                (
                    this.Shared == input.Shared ||
                    this.Shared.Equals(input.Shared)
                ) && 
                (
                    this.ShortDescription == input.ShortDescription ||
                    (this.ShortDescription != null &&
                    this.ShortDescription.Equals(input.ShortDescription))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.ProductGroup == input.ProductGroup ||
                    (this.ProductGroup != null &&
                    this.ProductGroup.Equals(input.ProductGroup))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                hashCode = (hashCode * 59) + this.UpfrontFareEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.Capacity.GetHashCode();
                if (this.ProductId != null)
                {
                    hashCode = (hashCode * 59) + this.ProductId.GetHashCode();
                }
                if (this.PriceDetails != null)
                {
                    hashCode = (hashCode * 59) + this.PriceDetails.GetHashCode();
                }
                if (this.Image != null)
                {
                    hashCode = (hashCode * 59) + this.Image.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CashEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.Shared.GetHashCode();
                if (this.ShortDescription != null)
                {
                    hashCode = (hashCode * 59) + this.ShortDescription.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.ProductGroup != null)
                {
                    hashCode = (hashCode * 59) + this.ProductGroup.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
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
