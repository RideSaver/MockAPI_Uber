using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace UberAPI.Models
{ 
    [DataContract(Name = "request_id")]
    public class RequestId : IEquatable<RequestId>
    {
        public RequestId() { }
        public RequestId(string productId, string requestId, string status, float surgeMultiplier, bool shared, RequestIdDrivers drivers, RequestIdVehicle vehicle, RequestIdLocation location, Trip pickup, Trip destination, RequestIdWaypoints waypoints, RequestIdRiders riders)
        {
            ProductId = productId;
            _RequestId = requestId;
            Status = status;
            SurgeMultiplier = surgeMultiplier;
            Shared = shared;
            Drivers = drivers;
            Vehicle = vehicle;
            Location = location;
            Pickup = pickup;
            Destination = destination;
            Waypoints = waypoints;
            Riders = riders;
        }

        [DataMember]
        public string? ProductId { get; set; }

        [DataMember]
        public string? _RequestId { get; set; }

        [DataMember]
        public string? Status { get; set; }

        [DataMember]
        public float? SurgeMultiplier { get; set; }

        [DataMember]
        public bool? Shared { get; set; }

        [DataMember]
        public RequestIdDrivers? Drivers { get; set; }

        [DataMember]
        public RequestIdVehicle? Vehicle { get; set; }

        [DataMember]
        public RequestIdLocation? Location { get; set; }

        [DataMember]
        public Trip Pickup { get; set; }

        [DataMember]
        public Trip? Destination { get; set; }

        [DataMember]
        public RequestIdWaypoints? Waypoints { get; set; }

        [DataMember]
        public RequestIdRiders? Riders { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestId {\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  RequestId: ").Append(_RequestId).Append("\n");
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
                    _RequestId == other._RequestId ||
                    _RequestId != null &&
                    _RequestId.Equals(other._RequestId)
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
                    if (_RequestId != null)
                    hashCode = hashCode * 59 + _RequestId.GetHashCode();
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
