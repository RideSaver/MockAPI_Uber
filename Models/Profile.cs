using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UberAPI.Models
{ 
    [DataContract]
    public class Profile : IEquatable<Profile>
    { 
        [DataMember]
        public string Picture { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Uuid { get; set; }

        [DataMember]
        public string RiderId { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public bool? MobileVerified { get; set; }

        [DataMember]
        public string PromoCode { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Profile {\n");
            sb.Append("  Picture: ").Append(Picture).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  RiderId: ").Append(RiderId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  MobileVerified: ").Append(MobileVerified).Append("\n");
            sb.Append("  PromoCode: ").Append(PromoCode).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Profile)obj);
        }
        public bool Equals(Profile other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Picture == other.Picture ||
                    Picture != null &&
                    Picture.Equals(other.Picture)
                ) && 
                (
                    FirstName == other.FirstName ||
                    FirstName != null &&
                    FirstName.Equals(other.FirstName)
                ) && 
                (
                    LastName == other.LastName ||
                    LastName != null &&
                    LastName.Equals(other.LastName)
                ) && 
                (
                    Uuid == other.Uuid ||
                    Uuid != null &&
                    Uuid.Equals(other.Uuid)
                ) && 
                (
                    RiderId == other.RiderId ||
                    RiderId != null &&
                    RiderId.Equals(other.RiderId)
                ) && 
                (
                    Email == other.Email ||
                    Email != null &&
                    Email.Equals(other.Email)
                ) && 
                (
                    MobileVerified == other.MobileVerified ||
                    MobileVerified != null &&
                    MobileVerified.Equals(other.MobileVerified)
                ) && 
                (
                    PromoCode == other.PromoCode ||
                    PromoCode != null &&
                    PromoCode.Equals(other.PromoCode)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Picture != null)
                    hashCode = hashCode * 59 + Picture.GetHashCode();
                    if (FirstName != null)
                    hashCode = hashCode * 59 + FirstName.GetHashCode();
                    if (LastName != null)
                    hashCode = hashCode * 59 + LastName.GetHashCode();
                    if (Uuid != null)
                    hashCode = hashCode * 59 + Uuid.GetHashCode();
                    if (RiderId != null)
                    hashCode = hashCode * 59 + RiderId.GetHashCode();
                    if (Email != null)
                    hashCode = hashCode * 59 + Email.GetHashCode();
                    if (MobileVerified != null)
                    hashCode = hashCode * 59 + MobileVerified.GetHashCode();
                    if (PromoCode != null)
                    hashCode = hashCode * 59 + PromoCode.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Profile left, Profile right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Profile left, Profile right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
