using AutoBogus;
using Bogus;
using UberAPI.Models;

namespace UberAPI.Registry
{
    public static class RequestEstimateGenerator
    {
        public static Faker<EstimateWitoutSurgeFareBreakdown> WO_SurgeFareBreakdown_FAKER_CONFG = new AutoFaker<RequestIdDrivers>()
            .RuleFor(o => o.PhoneNumber, f => f.Phone.PhoneNumber())
            .RuleFor(o => o.SmsNumber, f => f.Phone.PhoneNumber())
            .RuleFor(o => o.Rating, f => f.Random.Int(5, 25))
            .RuleFor(o => o.Name, f => f.Name.FirstName())
            .RuleFor(o => o.PictureUrl, () => "");

        public static Faker<RequestIdVehicle> RV_FAKER_CONFIG = new AutoFaker<RequestIdVehicle>()
            .RuleFor(o => o.Make, f => f.Vehicle.Manufacturer())
            .RuleFor(o => o.Model, f => f.Vehicle.Model())
            .RuleFor(o => o.LicensePlate, () => "XY54FCZ")
            .RuleFor(o => o.PictureUrl, () => "");

        public static Faker<RequestIdLocation> RL_FAKER_CONFIG = new AutoFaker<RequestIdLocation>()
            .RuleFor(o => o.Latitude, () => 180.0f)
            .RuleFor(o => o.Longitude, () => 100.0f)
            .RuleFor(o => o.Bearing, () => 5);

        public static Faker<Trip> T_FAKER_CONFIG = new AutoFaker<Trip>()
            .RuleFor(o => o.Alias, f => f.Name.FirstName())
            .RuleFor(o => o.Latitude, () => 180.0f)
            .RuleFor(o => o.Longitude, () => 100.0f)
            .RuleFor(o => o.Name, f => f.Name.FirstName())
            .RuleFor(o => o.Address, f => f.Address.FullAddress())
            .RuleFor(o => o.Eta, () => 15.0f);

        public static Faker<RequestIdRiders> RR_FAKER_CONFIG = new AutoFaker<RequestIdRiders>()
            .RuleFor(o => o.RiderId, f => f.Random.Guid().ToString())
            .RuleFor(o => o.FirstName, f => f.Name.FirstName());

        public static Faker<RequestIdWaypoints> RW_FAKER_CONFIG = new AutoFaker<RequestIdWaypoints>()
            .RuleFor(o => o.RiderId, f => f.Random.Guid().ToString())
            .RuleFor(o => o.Latitude, () => 180.0f)
            .RuleFor(o => o.Longitude, () => 100.0f)
            .RuleFor(o => o.Type, () => "RideShare");


        public static RequestId GenerateRequest()
        {
            var request = new RequestId()
            {
                ProductId = "product-id-place-holder",
                Id = "request-id-place-holder",
                Status = "Arriving Shortly",
                SurgeMultiplier = 0,
                Shared = false,
                Drivers = RD_FAKER_CONFG.Generate(),
                Vehicle = RV_FAKER_CONFIG.Generate(),
                Location = RL_FAKER_CONFIG.Generate(),
                Pickup = T_FAKER_CONFIG.Generate(3),
                Destination = T_FAKER_CONFIG.Generate(),
                Waypoints = RW_FAKER_CONFIG.Generate(),
                Riders = RR_FAKER_CONFIG.Generate(),

            };

            return request;
        }
    }
}
