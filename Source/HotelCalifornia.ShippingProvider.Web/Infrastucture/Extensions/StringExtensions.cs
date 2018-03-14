using System.Linq;

namespace HotelCalifornia.ShippingProvider.Web.Infrastucture.Extensions
{
    public static class StringExtensions
    {
        public static decimal GenerateDecimal(this string source, int totalDigits = 4, int precision = 2)
        {
            var total = source.Sum(c => c);

            if (total == 0)
            {
                return 0;
            }

            var totalAsString = total.ToString();
            totalAsString = totalAsString.PadLeft(4, '0');
            totalAsString = totalAsString.Substring(totalAsString.Length - totalDigits);
            totalAsString = totalAsString.Insert(totalAsString.Length - precision, ".");
            return decimal.Parse(totalAsString);
        }
    }
}