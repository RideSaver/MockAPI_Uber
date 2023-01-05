using AutoBogus;
using Bogus;
using UberAPI.Models;

namespace UberAPI.Registry
{
    public static class EstimateGenerator
    {
        public static Faker<EstimateWithoutSurgeFare> EWOF_FAKER_CONFIG = new AutoFaker<EstimateWithoutSurgeFare>()
            .RuleFor(o => o.Value, f => f.Random.Decimal(0.0m, 1.0m))
            .RuleFor(o => o.FareId, () => "fare-id-placeholder")
            .RuleFor(o => o.ExpiresAt, () => 10)
            .RuleFor(o => o.Display, () => "display-placeholder")
            .RuleFor(o => o.CurrencyCode, () => "USD");

        public static Faker<EstimateWithoutSurgeTrip> EWOST_FAKER_CONFIG = new AutoFaker<EstimateWithoutSurgeTrip>()
            .RuleFor(o => o.DistanceUnit, () => "Mile")
            .RuleFor(o => o.DurationEstimate, f => f.Random.Int(5, 15))
            .RuleFor(o => o.DistanceEstimate, f => f.Random.Decimal(0.0m, 1.0m));

        public static Faker<EstimateWithoutSurgeFareBreakdownInner> EWOSFBI_FAKER_CONFIG = new AutoFaker<EstimateWithoutSurgeFareBreakdownInner>()
            .RuleFor(o => o.Type, () => "EstimateWithoutSurge")
            .RuleFor(o => o.Notice, () => "Exempt")
            .RuleFor(o => o.Value, f => f.Random.Decimal(0.0m, 1.0m))
            .RuleFor(o => o.Name, () => "EsimateWithoutSurge");

        public static EstimateWithoutSurge GenerateEstimateWithoutSurge()
        {
            var EWOS = new EstimateWithoutSurge()
            {
                Fare = EWOF_FAKER_CONFIG.Generate(),
                Trip = EWOST_FAKER_CONFIG.Generate(),
                PickupEstimate = 10,
            };

            return EWOS;
        }


    }
}
