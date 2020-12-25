using System;
using System.Globalization;
using System.Text;

namespace LouVuiDateCode
{
    public static class DateCodeParser
    {
        /// <summary>
        /// Parses a date code and returns a <see cref="manufacturingYear"/> and <see cref="manufacturingMonth"/>.
        /// </summary>
        /// <param name="dateCode">A three or four number date code.</param>
        /// <param name="manufacturingYear">A manufacturing year to return.</param>
        /// <param name="manufacturingMonth">A manufacturing month to return.</param>
        public static void ParseEarly1980Code(string dateCode, out uint manufacturingYear, out uint manufacturingMonth)
        {
            if (string.IsNullOrEmpty(dateCode))
            {
                throw new ArgumentNullException(nameof(dateCode));
            }

            if (dateCode.Length < 3 || dateCode.Length > 4)
            {
                throw new ArgumentException("Argument is not correct!");
            }

            manufacturingMonth = uint.Parse(dateCode[2..], CultureInfo.CurrentCulture);
            manufacturingYear = uint.Parse(dateCode[..2], CultureInfo.CurrentCulture) + 1900;
        }

        /// <summary>
        /// Parses a date code and returns a <paramref name="factoryLocationCode"/>, <paramref name="manufacturingYear"/>, <paramref name="manufacturingMonth"/> and <paramref name="factoryLocationCountry"/> array.
        /// </summary>
        /// <param name="dateCode">A three or four number date code.</param>
        /// <param name="factoryLocationCountry">A factory location country array.</param>
        /// <param name="factoryLocationCode">A factory location code.</param>
        /// <param name="manufacturingYear">A manufacturing year to return.</param>
        /// <param name="manufacturingMonth">A manufacturing month to return.</param>
        public static void ParseLate1980Code(string dateCode, out Country[] factoryLocationCountry, out string factoryLocationCode, out uint manufacturingYear, out uint manufacturingMonth)
        {
            if (string.IsNullOrEmpty(dateCode))
            {
                throw new ArgumentNullException(nameof(dateCode));
            }

            if (dateCode.Length < 5 || dateCode.Length > 6)
            {
                throw new ArgumentException("Argument is not correct");
            }

            factoryLocationCode = dateCode[^2..];
            factoryLocationCountry = CountryParser.GetCountry(factoryLocationCode);
            manufacturingMonth = uint.Parse(dateCode[2..^2], CultureInfo.CurrentCulture);
            manufacturingYear = uint.Parse(dateCode[..2], CultureInfo.CurrentCulture) + 1900;
        }

        /// <summary>
        /// Parses a date code and returns a <paramref name="factoryLocationCode"/>, <paramref name="manufacturingYear"/>, <paramref name="manufacturingMonth"/> and <paramref name="factoryLocationCountry"/> array.
        /// </summary>
        /// <param name="dateCode">A three or four number date code.</param>
        /// <param name="factoryLocationCountry">A factory location country array.</param>
        /// <param name="factoryLocationCode">A factory location code.</param>
        /// <param name="manufacturingYear">A manufacturing year to return.</param>
        /// <param name="manufacturingMonth">A manufacturing month to return.</param>
        public static void Parse1990Code(string dateCode, out Country[] factoryLocationCountry, out string factoryLocationCode, out uint manufacturingYear, out uint manufacturingMonth)
        {
            if (string.IsNullOrEmpty(dateCode))
            {
                throw new ArgumentNullException(nameof(dateCode));
            }

            if (dateCode.Length != 6)
            {
                throw new ArgumentException("Argument is not correct");
            }

            factoryLocationCode = dateCode[..2];
            factoryLocationCountry = CountryParser.GetCountry(factoryLocationCode);

            StringBuilder month = new StringBuilder();
            StringBuilder year = new StringBuilder();
            uint year19 = 1900, year20 = 2000;
            month.Append(dateCode[2]);
            month.Append(dateCode[4]);
            year.Append(dateCode[3]);
            year.Append(dateCode[5]);
            manufacturingMonth = uint.Parse(month.ToString(), CultureInfo.CurrentCulture);
            manufacturingYear = uint.Parse(year.ToString(), CultureInfo.CurrentCulture);
            manufacturingYear += (manufacturingYear >= 90) ? year19 : year20;
        }

        /// <summary>
        /// Parses a date code and returns a <paramref name="factoryLocationCode"/>, <paramref name="manufacturingYear"/>, <paramref name="manufacturingWeek"/> and <paramref name="factoryLocationCountry"/> array.
        /// </summary>
        /// <param name="dateCode">A three or four number date code.</param>
        /// <param name="factoryLocationCountry">A factory location country array.</param>
        /// <param name="factoryLocationCode">A factory location code.</param>
        /// <param name="manufacturingYear">A manufacturing year to return.</param>
        /// <param name="manufacturingWeek">A manufacturing month to return.</param>
        public static void Parse2007Code(string dateCode, out Country[] factoryLocationCountry, out string factoryLocationCode, out uint manufacturingYear, out uint manufacturingWeek)
        {
            if (string.IsNullOrEmpty(dateCode))
            {
                throw new ArgumentNullException(nameof(dateCode));
            }

            if (dateCode.Length != 6)
            {
                throw new ArgumentException("Argument is not correct");
            }

            factoryLocationCode = dateCode[..2];
            factoryLocationCountry = CountryParser.GetCountry(factoryLocationCode);

            StringBuilder week = new StringBuilder();
            StringBuilder year = new StringBuilder();
            week.Append(dateCode[2]);
            week.Append(dateCode[4]);
            year.Append(dateCode[3]);
            year.Append(dateCode[5]);
            manufacturingWeek = uint.Parse(week.ToString(), CultureInfo.CurrentCulture);
            manufacturingYear = uint.Parse(year.ToString(), CultureInfo.CurrentCulture);
            manufacturingYear += (manufacturingYear >= 90) ? 1900 : 2000;
        }
    }
}
