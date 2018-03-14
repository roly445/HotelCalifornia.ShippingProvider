using System;

namespace HotelCalifornia.ShippingProvider.Web.Models
{
    public class ShippingMethod
    {
        public Guid Id { get; set; }
        public string Label { get; set; }
        public decimal Value { get; set; }
    }
}