using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UberAPI.Models
{ 
    [DataContract(Name = "request_id")]
    public class RequestId : IEquatable<RequestId>
    {
        public RequestId(string productId = default(string), string requestId = default(string), string status = default(string), float surgeMultiplier = default(float), bool shared = default(bool), RequestIdDrivers drivers = default(RequestIdDrivers), RequestIdVehicle vehicle = default(RequestIdVehicle), RequestIdLocation location = default(RequestIdLocation), Trip pickup = default(Trip), Trip destination = default(Trip), RequestIdWaypoints waypoints = default(RequestIdWaypoints), RequestIdRiders riders = default(RequestIdRiders))
        {
            this.ProductId = productId;
            this.Id = requestId;
            this.Status = status;
            this.SurgeMultiplier = surgeMultiplier;
            this.Shared = shared;
            this.Drivers = drivers;
            this.Vehicle = vehicle;
            this.Location = location;
            this.Pickup = pickup;
            this.Destination = destination;
            this.Waypoints = waypoints;
            this.Riders = riders;
        }

        [DataMember(Name="product_id")]
        public string? ProductId { get; set; }

        [DataMember(Name="request_id")]
        public string? Id { get; set; }

        [DataMember(Name="status")]
        public string? Status { get; set; }

        [DataMember(Name="surge_multiplier")]
        public float? SurgeMultiplier { get; set; }

        [DataMember(Name="shared")]
        public bool? Shared { get; set; }

        [DataMember(Name="drivers")]
        public RequestIdDrivers? Drivers { get; set; }

        [DataMember(Name="vehicle")]
        public RequestIdVehicle? Vehicle { get; set; }

        [DataMember(Name="location")]
        public RequestIdLocation? Location { get; set; }

        [DataMember(Name="pickup")]
        public Trip Pickup { get; set; }

        [DataMember(Name="destination")]
        public Trip? Destination { get; set; }

        [DataMember(Name="waypoints")]
        public RequestIdWaypoints? Waypoints { get; set; }

        [DataMember(Name="riders")]
        public RequestIdRiders? Riders { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestId {\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  RequestId: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SurgeMultiplier: ").Append(SurgeMultiplier).Append("\n");
            sb.Append("  Shared: ").Append(Shared).Append("\n");
            sb.Append("  Drivers: ").Append(Drivers).Append("\n");
            sb.Append("  Vehicle: ").Append(Vehicle).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Pickup: ").Append(Pickup).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Waypoints: ").Append(Waypoints).Append("\n");
            sb.Append("  Riders: ").Append(Riders).Append("\n");
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
            return obj.GetType() == GetType() && Equals((RequestId)obj);
        }
        public bool Equals(RequestId other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ProductId == other.ProductId ||
                    ProductId != null &&
                    ProductId.Equals(other.ProductId)
                ) && 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
                ) && 
                (
                    SurgeMultiplier == other.SurgeMultiplier ||
                    SurgeMultiplier != null &&
                    SurgeMultiplier.Equals(other.SurgeMultiplier)
                ) && 
                (
                    Shared == other.Shared ||
                    Shared != null &&
                    Shared.Equals(other.Shared)
                ) && 
                (
                    Drivers == other.Drivers ||
                    Drivers != null &&
                    Drivers.Equals(other.Drivers)
                ) && 
                (
                    Vehicle == other.Vehicle ||
                    Vehicle != null &&
                    Vehicle.Equals(other.Vehicle)
                ) && 
                (
                    Location == other.Location ||
                    Location != null &&
                    Location.Equals(other.Location)
                ) && 
                (
                    Pickup == other.Pickup ||
                    Pickup != null &&
                    Pickup.Equals(other.Pickup)
                ) && 
                (
                    Destination == other.Destination ||
                    Destination != null &&
                    Destination.Equals(other.Destination)
                ) && 
                (
                    Waypoints == other.Waypoints ||
                    Waypoints != null &&
                    Waypoints.Equals(other.Waypoints)
                ) && 
                (
                    Riders == other.Riders ||
                    Riders != null &&
                    Riders.Equals(other.Riders)
                );
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (ProductId != null)
                    hashCode = hashCode * 59 + ProductId.GetHashCode();
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    if (SurgeMultiplier != null)
                    hashCode = hashCode * 59 + SurgeMultiplier.GetHashCode();
                    if (Shared != null)
                    hashCode = hashCode * 59 + Shared.GetHashCode();
                    if (Drivers != null)
                    hashCode = hashCode * 59 + Drivers.GetHashCode();
                    if (Vehicle != null)
                    hashCode = hashCode * 59 + Vehicle.GetHashCode();
                    if (Location != null)
                    hashCode = hashCode * 59 + Location.GetHashCode();
                    if (Pickup != null)
                    hashCode = hashCode * 59 + Pickup.GetHashCode();
                    if (Destination != null)
                    hashCode = hashCode * 59 + Destination.GetHashCode();
                    if (Waypoints != null)
                    hashCode = hashCode * 59 + Waypoints.GetHashCode();
                    if (Riders != null)
                    hashCode = hashCode * 59 + Riders.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RequestId left, RequestId right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RequestId left, RequestId right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
