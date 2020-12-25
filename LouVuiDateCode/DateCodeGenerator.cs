using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace LouVuiDateCode
{
    public static class DateCodeGenerator
    {
        /// <summary>
        /// Generates a date code using rules from early 1980s.
        /// </summary>
        /// <param name="manufacturingYear">A manufacturing year.</param>
        /// <param name="manufacturingMonth">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string GenerateEarly1980Code(uint manufacturingYear, uint manufacturingMonth)
        {
            if (manufacturingYear >= 1990 || manufacturingYear < 1980)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingYear));
            }

            if (manufacturingMonth <= 0 || manufacturingMonth > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingMonth));
            }

            StringBuilder sb = new StringBuilder();
            sb.Append(manufacturingYear);
            sb.Append(manufacturingMonth);

            string result = sb.ToString();

            return result[2..];
        }

        /// <summary>
        /// Generates a date code using rules from early 1980s.
        /// </summary>
        /// <param name="manufacturingDate">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string GenerateEarly1980Code(DateTime manufacturingDate)
        {
            DateTime from = new DateTime(1980, 1, 1);
            DateTime to = new DateTime(1990, 1, 1);
            if (manufacturingDate < from || manufacturingDate >= to)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingDate));
            }

            StringBuilder result = new StringBuilder();
            result.Append(manufacturingDate.ToString("yy", CultureInfo.CurrentCulture));
            result.Append(manufacturingDate.Month);

            return result.ToString();
        }

        /// <summary>
        /// Generates a date code using rules from early 1980s.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingYear">A manufacturing year.</param>
        /// <param name="manufacturingMonth">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string GenerateLate1980Code(string factoryLocationCode, uint manufacturingYear, uint manufacturingMonth)
        {
            if (string.IsNullOrEmpty(factoryLocationCode))
            {
                throw new ArgumentNullException(nameof(factoryLocationCode));
            }

            if (manufacturingYear >= 1990 || manufacturingYear < 1980)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingYear));
            }

            if (manufacturingMonth <= 0 || manufacturingMonth > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingMonth));
            }

            if (!Regex.IsMatch(factoryLocationCode, @"^[a-zA-Z]+$"))
            {
                throw new ArgumentException("Argument is not correct!");
            }

            StringBuilder sb = new StringBuilder();
            sb.Append(manufacturingYear);
            sb.Append(manufacturingMonth);
            sb.Append(factoryLocationCode.ToUpper(CultureInfo.CurrentCulture));

            string result = sb.ToString();

            return result[2..];
        }

        /// <summary>
        /// Generates a date code using rules from late 1980s.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingDate">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string GenerateLate1980Code(string factoryLocationCode, DateTime manufacturingDate)
        {
            DateTime from = new DateTime(1980, 1, 1);
            DateTime to = new DateTime(1990, 1, 1);
            if (manufacturingDate < from || manufacturingDate >= to)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingDate));
            }

            if (string.IsNullOrEmpty(factoryLocationCode))
            {
                throw new ArgumentNullException(nameof(factoryLocationCode));
            }

            if (!Regex.IsMatch(factoryLocationCode, @"^[a-zA-Z]+$"))
            {
                throw new ArgumentException("Argument is not correct!");
            }

            StringBuilder result = new StringBuilder();
            result.Append(manufacturingDate.ToString("yy", CultureInfo.CurrentCulture));
            result.Append(manufacturingDate.Month);
            result.Append(factoryLocationCode.ToUpper(CultureInfo.CurrentCulture));

            return result.ToString();
        }

        /// <summary>
        /// Generates a date code using rules from 1990 to 2006 period.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingYear">A manufacturing year.</param>
        /// <param name="manufacturingMonth">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string Generate1990Code(string factoryLocationCode, uint manufacturingYear, uint manufacturingMonth)
        {
            if (string.IsNullOrEmpty(factoryLocationCode))
            {
                throw new ArgumentNullException(nameof(factoryLocationCode));
            }

            if (manufacturingYear >= 2006 || manufacturingYear < 1990)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingYear));
            }

            if (manufacturingMonth <= 0 || manufacturingMonth > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingMonth));
            }

            if (!Regex.IsMatch(factoryLocationCode, @"^[a-zA-Z]+$"))
            {
                throw new ArgumentException("Argument is not correct!");
            }

            StringBuilder sb = new StringBuilder();
            sb.Append(factoryLocationCode.ToUpper(CultureInfo.CurrentCulture));
            string year = manufacturingYear.ToString(CultureInfo.CurrentCulture);
            string month = manufacturingMonth.ToString(CultureInfo.CurrentCulture);
            if (month.Length < 2)
            {
                sb.Append("0");
            }
            else
            {
                sb.Append(month[^2]);
            }

            sb.Append(year[^2]);
            sb.Append(month[^1]);
            sb.Append(year[^1]);

            string result = sb.ToString();

            return result;
        }

        /// <summary>
        /// Generates a date code using rules from 1990 to 2006 period.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingDate">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string Generate1990Code(string factoryLocationCode, DateTime manufacturingDate)
        {
            DateTime from = new DateTime(1990, 1, 1);
            DateTime to = new DateTime(2006, 12, 1);
            if (manufacturingDate < from || manufacturingDate >= to)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingDate));
            }

            if (string.IsNullOrEmpty(factoryLocationCode))
            {
                throw new ArgumentNullException(nameof(factoryLocationCode));
            }

            if (!Regex.IsMatch(factoryLocationCode, @"^[a-zA-Z]+$"))
            {
                throw new ArgumentException("Argument is not correct!");
            }

            StringBuilder result = new StringBuilder();
            result.Append(factoryLocationCode.ToUpper(CultureInfo.CurrentCulture));
            string year = manufacturingDate.ToString("yy", CultureInfo.CurrentCulture);
            string month = manufacturingDate.Month.ToString(CultureInfo.CurrentCulture);
            if (month.Length < 2)
            {
                result.Append("0");
            }
            else
            {
                result.Append(month[^2]);
            }

            result.Append(year[^2]);
            result.Append(month[^1]);
            result.Append(year[^1]);

            return result.ToString();
        }

        /// <summary>
        /// Generates a date code using rules from post 2007 period.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingYear">A manufacturing year.</param>
        /// <param name="manufacturingWeek">A manufacturing week number.</param>
        /// <returns>A generated date code.</returns>
        public static string Generate2007Code(string factoryLocationCode, uint manufacturingYear, uint manufacturingWeek)
        {
            if (manufacturingYear < 2007 || manufacturingYear > DateTime.Now.Year)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingYear));
            }

            if (manufacturingWeek > 53)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingWeek));
            }

            if (string.IsNullOrEmpty(factoryLocationCode))
            {
                throw new ArgumentNullException(nameof(factoryLocationCode));
            }

            if (!Regex.IsMatch(factoryLocationCode, @"^[a-zA-Z]+$"))
            {
                throw new ArgumentException("Argument is not correct!");
            }

            StringBuilder sb = new StringBuilder();
            sb.Append(factoryLocationCode.ToUpper(CultureInfo.CurrentCulture));
            string year = manufacturingYear.ToString(CultureInfo.CurrentCulture);
            string week = manufacturingWeek.ToString(CultureInfo.CurrentCulture);
            if (week.Length < 2)
            {
                sb.Append("0");
            }
            else
            {
                sb.Append(week[^2]);
            }

            sb.Append(year[^2]);
            sb.Append(week[^1]);
            sb.Append(year[^1]);

            string result = sb.ToString();

            return result;
        }

        /// <summary>
        /// Generates a date code using rules from post 2007 period.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingDate">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string Generate2007Code(string factoryLocationCode, DateTime manufacturingDate)
        {
            DateTime from = new DateTime(2007, 1, 1);
            if (manufacturingDate < from || manufacturingDate >= DateTime.Now)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingDate));
            }

            if (string.IsNullOrEmpty(factoryLocationCode))
            {
                throw new ArgumentNullException(nameof(factoryLocationCode));
            }

            if (!Regex.IsMatch(factoryLocationCode, @"^[a-zA-Z]+$"))
            {
                throw new ArgumentException("Argument is not correct!");
            }

            var currentCulture = CultureInfo.CurrentCulture;
            var weekNo = currentCulture.Calendar.GetWeekOfYear(
                            manufacturingDate,
                            currentCulture.DateTimeFormat.CalendarWeekRule,
                            currentCulture.DateTimeFormat.FirstDayOfWeek);

            StringBuilder result = new StringBuilder();
            result.Append(factoryLocationCode.ToUpper(CultureInfo.CurrentCulture));
            string year = manufacturingDate.ToString("yy", CultureInfo.CurrentCulture);
            string week = weekNo.ToString(CultureInfo.CurrentCulture);
            if (week.Length < 2)
            {
                result.Append("0");
            }
            else
            {
                result.Append(week[^2]);
            }

            result.Append(year[^2]);
            result.Append(week[^1]);
            result.Append(year[^1]);

            return result.ToString();
        }
    }
}
