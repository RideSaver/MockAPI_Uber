using AutoBogus;
using Bogus;
using UberAPI.Models;

namespace UberAPI.Registry
{
    public static class EstimateGenerator
    {
        private static Faker<EstimateWithoutSurgeTrip> Trip = new AutoFaker<EstimateWithoutSurgeTrip>()
            .RuleFor(o => o.DistanceUnit, f => "Mile")
            .RuleFor(o => o.DurationEstimate, f => f.Random.Int(5, 15))
            .RuleFor(o => o.DistanceEstimate, f => f.Random.Decimal(0.0m, 1.0m));

        private static string[] BreakdownTypes = {"promotion", "base_fare"};
        private static Faker<EstimateWithoutSurgeFareBreakdownInner> FareBreakdownWithout = new AutoFaker<EstimateWithoutSurgeFareBreakdownInner>()
            .RuleFor(o => o.Type, f => f.Random.ArrayElement(BreakdownTypes))
            .RuleFor(o => o.Notice, (f, fb) => (fb.Type == "base_fare" ? f.Lorem.Sentence() : null))
            .RuleFor(o => o.Value, f => f.Random.Double(-5, 30))
            .RuleFor(o => o.Name, (f, fb) => (fb.Type == "base_fare" ? "Base Fare" : "Promotion"));

        private static Faker<EstimateWithoutSurgeFare> FareWithout = new AutoFaker<EstimateWithoutSurgeFare>()
            .RuleFor(o => o.Value, f => f.Random.Decimal(5, 30))
            .RuleFor(o => o.FareId, f => new Guid())
            .RuleFor(o => o.ExpiresAt, f => f.Date.Soon())
            .RuleFor(o => o.Display, (f, est) => $"${est.Value.ToString("0.00")}")
            .RuleFor(o => o.CurrencyCode, f => "USD")
            .RuleFor(o => o.Breakdown, f => FareBreakdownWithout.Generate(f.Random.Number(1, 3)).ToList());

        private static Faker<EstimateWithSurgeEstimateFareBreakdownInner> FareBreakdownWith = new AutoFaker<EstimateWithSurgeEstimateFareBreakdownInner>()
            .RuleFor(o => o.LowAmount, f => f.Random.Decimal(2, 10))
            .RuleFor(o => o.HighAmount, (f, fb) => f.Random.Decimal(fb.LowAmount, 10))
            .RuleFor(o => o.DisplayAmount, (f, fb) => $"{fb.LowAmount}-{fb.HighAmount}")
            .RuleFor(o => o.DisplayName, f => $"{f.Random.Word()} Fee");

        private static Faker<EstimateWithSurgeEstimate> EstimateWith = new AutoFaker<EstimateWithSurgeEstimate>()
            .RuleFor(o => o.SurgeConfirmationId, f => f.Random.Guid())
            .RuleFor(o => o.SurgeConfirmationHref, (f, est) => $"/confirm/{est.SurgeConfirmationId}")
            .RuleFor(o => o.LowEstimate, f => f.Random.Decimal(20, 50))
            .RuleFor(o => o.HighEstimate, (f, est) => f.Random.Decimal(est.LowEstimate, 50))
            .RuleFor(o => o.Display, (f, est) => $"${est.LowEstimate}-{est.HighEstimate}")
            .RuleFor(o => o.Minimum, f => f.Random.Number(10, 40).OrNull(f, .9f))
            .RuleFor(o => o.FareBreakdown, f => FareBreakdownWith.Generate(5).ToList())
            .RuleFor(o => o.SurgeMultiplier, f => f.Random.Decimal(1, 2))
            .RuleFor(o => o.CurrencyCode, f => "USD");

        private static Faker<EstimateWithoutSurge> FullEstimateWithout = new AutoFaker<EstimateWithoutSurge>()
            .RuleFor(o => o.Fare, f => FareWithout.Generate())
            .RuleFor(o => o.Trip, f => Trip.Generate())
            .RuleFor(o => o.PickupEstimate, f => f.Random.Number(10, 30));

        private static Faker<EstimateWithSurge> FullEstimateWith = new AutoFaker<EstimateWithSurge>()
            .RuleFor(o => o.Estimate, f => EstimateWith.Generate())
            .RuleFor(o => o.Trip, f => Trip.Generate())
            .RuleFor(o => o.PickupEstimate, f => f.Random.Number(10, 30));


        public static EstimateWithoutSurge GenerateEstimateWithoutSurge()
        {
            return FullEstimateWithout.Generate();
        }

        public static EstimateWithSurge GenerateEstimateWithSurge()
        {
            return FullEstimateWith.Generate();
        }

        public static RequestEstimateResponse GenerateEstimate(bool? surgeActive)
        {
            bool _surgeActive = false;
            if(surgeActive == null)
            {
                var random = new Bogus.Randomizer();
                _surgeActive = random.Bool();
            }
            else
            {
                _surgeActive = (bool)surgeActive;
            }

            if(_surgeActive)
            {// Return surge pricing
                return new RequestEstimateResponse(GenerateEstimateWithSurge());
            }
            else
            {// Return upfront fare pricing
                return new RequestEstimateResponse(GenerateEstimateWithoutSurge());
            }
        }
    }
}
