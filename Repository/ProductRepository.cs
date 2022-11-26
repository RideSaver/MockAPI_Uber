using UberAPI.Interface;
using UberAPI.Models;

namespace UberAPI.Repository

{
    public class ProductRepository : IProductRepository
    {
        // UberX, UberXL, UberLUX, UberPOOL, UberComfort
        // UberBlack, UberBlack SUV

        public static List<Product> productTypes = new List<Product>
        {
            new Product() // UberX
            {
                ProductId = new Guid(),
                Upfront_Fare_Enabled = false,
                Capacity = 3,
                Price_Details = new PriceDetails()
                {
                    Cost_Per_Minute = 0.20F,
                    Distance_Unit = "mile",
                    Minimum = 2.50F,
                    Cost_Per_Distance = 0.90F,
                    Base = 2.50F,
                    Cancellation_Fee = 5F,
                    Currency_Code = "USD"
                },
                Image = "uberX-image-url",
                Cash_Enabled = false,
                Shared = false,
                Short_Description = "UberX ride for 3 people",
                Display_Name = "uberX",
                Product_Group = "uberX",
                Description = "UberX ride for up to 3 people"
            },

            new Product() // UberXL
            {
                ProductId = new Guid(),
                Upfront_Fare_Enabled = false,
                Capacity = 6,
                Price_Details = new PriceDetails()
                {
                    Cost_Per_Minute = 0.50F,
                    Distance_Unit = "mile",
                    Minimum = 3.50F,
                    Cost_Per_Distance = 1.40F,
                    Base = 3.50F,
                    Cancellation_Fee = 5F,
                    Currency_Code = "USD"
                },
                Image = "uberXL-image-url",
                Cash_Enabled = false,
                Shared = false,
                Short_Description = "UberXL ride for 6 people",
                Display_Name = "UberXL",
                Product_Group = "UberXL",
                Description = "UberXL ride for up to 6 people"
            },

            new Product() // UberLUX
            {
                ProductId = new Guid(),
                Upfront_Fare_Enabled = false,
                Capacity = 3,
                Price_Details = new PriceDetails()
                {
                    Cost_Per_Minute = 0.70F,
                    Distance_Unit = "mile",
                    Minimum = 3.00F,
                    Cost_Per_Distance = 1.60F,
                    Base = 3.00F,
                    Cancellation_Fee = 5F,
                    Currency_Code = "USD"
                },
                Image = "uberLUX-image-url",
                Cash_Enabled = false,
                Shared = false,
                Short_Description = "UberLUX ride for 3 people",
                Display_Name = "UberLUX",
                Product_Group = "UberLUX",
                Description = "UberLUX ride for up to 3 people"
            },

            new Product() // UberPOOL
            {
                ProductId = new Guid(),
                Upfront_Fare_Enabled = false,
                Capacity = 3,
                Price_Details = new PriceDetails()
                {
                    Cost_Per_Minute = 0.40F,
                    Distance_Unit = "mile",
                    Minimum = 2.50F,
                    Cost_Per_Distance = 0.60F,
                    Base = 2.50F,
                    Cancellation_Fee = 5F,
                    Currency_Code = "USD"
                },
                Image = "uberPOOL-image-url",
                Cash_Enabled = false,
                Shared = true,
                Short_Description = "UberPOOL ride for 3 people",
                Display_Name = "UberPOOL",
                Product_Group = "UberPOOL",
                Description = "UberPOOL ride for up to 3 people"
            },

            new Product() // UberCOMFORT
            {
                ProductId = new Guid(),
                Upfront_Fare_Enabled = false,
                Capacity = 3,
                Price_Details = new PriceDetails()
                {
                    Cost_Per_Minute = 0.40F,
                    Distance_Unit = "mile",
                    Minimum = 2.50F,
                    Cost_Per_Distance = 1.10F,
                    Base = 3.50F,
                    Cancellation_Fee = 5F,
                    Currency_Code = "USD"
                },
                Image = "UberComfort-image-url",
                Cash_Enabled = false,
                Shared = false,
                Short_Description = "UberComfort ride for 3 people",
                Display_Name = "UberComfort",
                Product_Group = "UberComfort",
                Description = "UberComfort ride for up to 3 people"
            },

            new Product() // UberBlack
            {
                ProductId = new Guid(),
                Upfront_Fare_Enabled = false,
                Capacity = 3,
                Price_Details = new PriceDetails()
                {
                    Cost_Per_Minute = 0.80F,
                    Distance_Unit = "mile",
                    Minimum = 5.00F,
                    Cost_Per_Distance = 1.20F,
                    Base = 5.00F,
                    Cancellation_Fee = 5F,
                    Currency_Code = "USD"
                },
                Image = "UberBlack-image-url",
                Cash_Enabled = false,
                Shared = false,
                Short_Description = "UberBlack ride for 3 people",
                Display_Name = "UberBlack",
                Product_Group = "UberBlack",
                Description = "UberBlack ride for up to 3 people"
            },

            new Product() // UberBlack SUV
            {
                ProductId = new Guid(),
                Upfront_Fare_Enabled = false,
                Capacity = 6,
                Price_Details = new PriceDetails()
                {
                    Cost_Per_Minute = 1.00F,
                    Distance_Unit = "mile",
                    Minimum = 5.00F,
                    Cost_Per_Distance = 1.40F,
                    Base = 5.00F,
                    Cancellation_Fee = 5F,
                    Currency_Code = "USD"
                },
                Image = "UberBlack SUV-image-url",
                Cash_Enabled = false,
                Shared = false,
                Short_Description = "UberBlack ride for 6 people",
                Display_Name = "UberBlack SUV",
                Product_Group = "UberBlack SUV",
                Description = "UberBlack SUV ride for up to 6 people"
            },

        };



        public List<Product> GetAvailableProducts(Location location)
        {
            return productTypes;
        }

        public List<Product> GetProducts(string productId)
        {
            return productTypes.FindAll(x => x.ProductId == new Guid(productId));
        }
    }
}
