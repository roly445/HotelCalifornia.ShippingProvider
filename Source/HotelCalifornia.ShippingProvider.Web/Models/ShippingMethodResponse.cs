using System.Collections.Generic;

namespace HotelCalifornia.ShippingProvider.Web.Models
{
    public class ShippingMethodResponse
    {
        public ShippingMethodResponse(string postalCode, IReadOnlyList<ShippingMethod> shippingMethods)
        {
            PostalCode = postalCode;
            ShippingMethods = shippingMethods;
        }

        public string PostalCode { get; }
        public IReadOnlyList<ShippingMethod> ShippingMethods { get; }

    }
}