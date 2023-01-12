using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UberAPI.Models
{
    [DataContract(Name = "request_id_vehicle")]
    public class RequestIdVehicle : IEquatable<RequestIdVehicle>
    {
        public RequestIdVehicle(string make, string model, string licensePlate, string pictureUrl)
        {
            Make = make;
            Model = model;
            LicensePlate = licensePlate;
            PictureUrl = pictureUrl;
        }

        [DataMember]
        public string? Make { get; set; }

        [DataMember]
        public string? Model { get; set; }

        [DataMember]
        public string? LicensePlate { get; set; }

        [DataMember]
        public string? PictureUrl { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestIdVehicle {\n");
            sb.Append("  Make: ").Append(Make).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  LicensePlate: ").Append(LicensePlate).Append("\n");
            sb.Append("  PictureUrl: ").Append(PictureUrl).Append("\n");
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
            return obj.GetType() == GetType() && Equals((RequestIdVehicle)obj);
        }

        public bool Equals(RequestIdVehicle other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Make == other.Make ||
                    Make != null &&
                    Make.Equals(other.Make)
                ) && 
                (
                    Model == other.Model ||
                    Model != null &&
                    Model.Equals(other.Model)
                ) && 
                (
                    LicensePlate == other.LicensePlate ||
                    LicensePlate != null &&
                    LicensePlate.Equals(other.LicensePlate)
                ) && 
                (
                    PictureUrl == other.PictureUrl ||
                    PictureUrl != null &&
                    PictureUrl.Equals(other.PictureUrl)
                );
        }
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Make != null)
                    hashCode = hashCode * 59 + Make.GetHashCode();
                    if (Model != null)
                    hashCode = hashCode * 59 + Model.GetHashCode();
                    if (LicensePlate != null)
                    hashCode = hashCode * 59 + LicensePlate.GetHashCode();
                    if (PictureUrl != null)
                    hashCode = hashCode * 59 + PictureUrl.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RequestIdVehicle left, RequestIdVehicle right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RequestIdVehicle left, RequestIdVehicle right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
