using System;
using System.Collections.Generic;
using HotelCalifornia.ShippingProvider.Web.Infrastucture.Extensions;
using HotelCalifornia.ShippingProvider.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelCalifornia.ShippingProvider.Web.Controllers
{
    public class ShippingController : Controller
    {
        [HttpPost]
        [Route("/")]
        public ShippingMethodResponse GatherShippingCosts([FromBody] ShippingMethodRequest shippingMethodRequest)
        {
            var initialCost = shippingMethodRequest.PostalCode.GenerateDecimal();
            var shippingMethods = new List<ShippingMethod>
            {
                new ShippingMethod
                {
                    Id = Guid.Parse("0006a9c9-f1d3-4be9-b580-baa34ab26a6e"),
                    Label = "Economy Shipping (5-7 Days)",
                    Value = initialCost / 2
                },
                new ShippingMethod
                {
                    Id = Guid.Parse("a27a840e-1bb6-4e97-b447-b3aa2d0eb2e9"),
                    Label = "Express Shipping (2-3 Days)",
                    Value = initialCost
                },
                new ShippingMethod
                {
                    Id = Guid.Parse("443fc390-17db-459e-a83e-c8fa4d68d9ae"),
                    Label = "Next Day Delivery",
                    Value = initialCost * 2
                }
            };

            return new ShippingMethodResponse(shippingMethodRequest.PostalCode, shippingMethods.AsReadOnly());
        }
    }
}