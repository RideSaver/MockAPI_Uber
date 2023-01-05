using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text;

namespace UberAPI.Models
{
    [DataContract]
    public class RequestEstimate
    {
        [DataMember]
        public string ProductId { get; set; }

        [DataMember]
        public double StartLat { get; set; }

        [DataMember]
        public double StartLong { get; set; }

        [DataMember]
        public string? StartPlaceId { get; set; }

        [DataMember]
        public double? EndLat { get; set; }

        [DataMember]
        public double? EndLong { get; set; }

        [DataMember]
        public string? EndPlaceId { get; set; }

        [DataMember]
        public int? Seats { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestId {\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  StartLat: ").Append(StartLat).Append("\n");
            sb.Append("  StartLong: ").Append(StartLong).Append("\n");
            sb.Append("  StartPlaceId: ").Append(StartPlaceId).Append("\n");
            sb.Append("  EndLat: ").Append(EndLat).Append("\n");
            sb.Append("  EndLong: ").Append(EndLong).Append("\n");
            sb.Append("  EndPlaceId: ").Append(EndPlaceId).Append("\n");
            sb.Append("  Seats: ").Append(Seats).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
