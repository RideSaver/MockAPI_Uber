using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UberAPI.Models
{ 
    [DataContract]
    public class ProductList : IEquatable<ProductList>
    { 
        [DataMember(Name="products")]
        public List<Product> Products { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductList {\n");
            sb.Append("  Products: ").Append(Products).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ProductList)obj);
        }
        public bool Equals(ProductList other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Products == other.Products ||
                    Products != null &&
                    Products.SequenceEqual(other.Products)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Products != null)
                    hashCode = hashCode * 59 + Products.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ProductList left, ProductList right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ProductList left, ProductList right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
