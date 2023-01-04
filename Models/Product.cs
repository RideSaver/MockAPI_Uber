using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UberAPI.Models
{ 
    [DataContract]
    public class Product : IEquatable<Product>
    { 
        [DataMember(Name="upfront_fare_enabled")]
        public bool? UpfrontFareEnabled { get; set; }

        [DataMember(Name="capacity")]
        public int? Capacity { get; set; }

        [DataMember(Name="product_id")]
        public string ProductId { get; set; }


        [DataMember(Name="price_details")]
        public ProductPriceDetails PriceDetails { get; set; }


        [DataMember(Name="image")]
        public string Image { get; set; }

        [DataMember(Name="cash_enabled")]
        public bool? CashEnabled { get; set; }

        [DataMember(Name="shared")]
        public bool? Shared { get; set; }

        [DataMember(Name="short_description")]
        public string ShortDescription { get; set; }

        [DataMember(Name="display_name")]
        public string DisplayName { get; set; }

        [DataMember(Name="product_group")]
        public string ProductGroup { get; set; }

        [DataMember(Name="description")]
        public string Description { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
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

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Product)obj);
        }
        public bool Equals(Product other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    UpfrontFareEnabled == other.UpfrontFareEnabled ||
                    UpfrontFareEnabled != null &&
                    UpfrontFareEnabled.Equals(other.UpfrontFareEnabled)
                ) && 
                (
                    Capacity == other.Capacity ||
                    Capacity != null &&
                    Capacity.Equals(other.Capacity)
                ) && 
                (
                    ProductId == other.ProductId ||
                    ProductId != null &&
                    ProductId.Equals(other.ProductId)
                ) && 
                (
                    PriceDetails == other.PriceDetails ||
                    PriceDetails != null &&
                    PriceDetails.Equals(other.PriceDetails)
                ) && 
                (
                    Image == other.Image ||
                    Image != null &&
                    Image.Equals(other.Image)
                ) && 
                (
                    CashEnabled == other.CashEnabled ||
                    CashEnabled != null &&
                    CashEnabled.Equals(other.CashEnabled)
                ) && 
                (
                    Shared == other.Shared ||
                    Shared != null &&
                    Shared.Equals(other.Shared)
                ) && 
                (
                    ShortDescription == other.ShortDescription ||
                    ShortDescription != null &&
                    ShortDescription.Equals(other.ShortDescription)
                ) && 
                (
                    DisplayName == other.DisplayName ||
                    DisplayName != null &&
                    DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    ProductGroup == other.ProductGroup ||
                    ProductGroup != null &&
                    ProductGroup.Equals(other.ProductGroup)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (UpfrontFareEnabled != null)
                    hashCode = hashCode * 59 + UpfrontFareEnabled.GetHashCode();
                    if (Capacity != null)
                    hashCode = hashCode * 59 + Capacity.GetHashCode();
                    if (ProductId != null)
                    hashCode = hashCode * 59 + ProductId.GetHashCode();
                    if (PriceDetails != null)
                    hashCode = hashCode * 59 + PriceDetails.GetHashCode();
                    if (Image != null)
                    hashCode = hashCode * 59 + Image.GetHashCode();
                    if (CashEnabled != null)
                    hashCode = hashCode * 59 + CashEnabled.GetHashCode();
                    if (Shared != null)
                    hashCode = hashCode * 59 + Shared.GetHashCode();
                    if (ShortDescription != null)
                    hashCode = hashCode * 59 + ShortDescription.GetHashCode();
                    if (DisplayName != null)
                    hashCode = hashCode * 59 + DisplayName.GetHashCode();
                    if (ProductGroup != null)
                    hashCode = hashCode * 59 + ProductGroup.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Product left, Product right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Product left, Product right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
