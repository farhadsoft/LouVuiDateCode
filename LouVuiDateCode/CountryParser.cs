using System;
using System.Collections.Generic;

namespace LouVuiDateCode
{
    public static class CountryParser
    {
        /// <summary>
        /// Gets a an array of <see cref="Country"/> enumeration values for a specified factory location code. One location code can belong to many countries.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <returns>An array of <see cref="Country"/> enumeration values.</returns>
        public static Country[] GetCountry(string factoryLocationCode)
        {
            if (string.IsNullOrEmpty(factoryLocationCode))
            {
                throw new ArgumentNullException(nameof(factoryLocationCode));
            }

            List<Country> countries = new List<Country>();

            switch (factoryLocationCode)
            {
                case "A0":
                    countries.Add(Country.France);
                    break;
                case "A1":
                    countries.Add(Country.France);
                    break;
                case "A2":
                    countries.Add(Country.France);
                    break;
                case "AA":
                    countries.Add(Country.France);
                    break;
                case "AH":
                    countries.Add(Country.France);
                    break;
                case "AN":
                    countries.Add(Country.France);
                    break;
                case "AR":
                    countries.Add(Country.France);
                    break;
                case "AS":
                    countries.Add(Country.France);
                    break;
                case "BA":
                    countries.Add(Country.France);
                    break;
                case "BJ":
                    countries.Add(Country.France);
                    break;
                case "BU":
                    countries.Add(Country.France);
                    break;
                case "DR":
                    countries.Add(Country.France);
                    break;
                case "DU":
                    countries.Add(Country.France);
                    break;
                case "DT":
                    countries.Add(Country.France);
                    break;
                case "CO":
                    countries.Add(Country.France);
                    break;
                case "CT":
                    countries.Add(Country.France);
                    break;
                case "CX":
                    countries.Add(Country.France);
                    break;
                case "ET":
                    countries.Add(Country.France);
                    break;
                case "FL":
                    countries.Add(Country.France);
                    countries.Add(Country.USA);
                    break;
                case "LW":
                    countries.Add(Country.France);
                    countries.Add(Country.Spain);
                    break;
                case "MB":
                    countries.Add(Country.France);
                    break;
                case "MI":
                    countries.Add(Country.France);
                    break;
                case "NO":
                    countries.Add(Country.France);
                    break;
                case "RA":
                    countries.Add(Country.France);
                    break;
                case "RI":
                    countries.Add(Country.France);
                    break;
                case "SD":
                    countries.Add(Country.France);
                    countries.Add(Country.USA);
                    break;
                case "SF":
                    countries.Add(Country.France);
                    break;
                case "SL":
                    countries.Add(Country.France);
                    break;
                case "SN":
                    countries.Add(Country.France);
                    break;
                case "SP":
                    countries.Add(Country.France);
                    break;
                case "SR":
                    countries.Add(Country.France);
                    break;
                case "TJ":
                    countries.Add(Country.France);
                    break;
                case "TH":
                    countries.Add(Country.France);
                    break;
                case "TR":
                    countries.Add(Country.France);
                    break;
                case "TS":
                    countries.Add(Country.France);
                    break;
                case "VI":
                    countries.Add(Country.France);
                    break;
                case "VX":
                    countries.Add(Country.France);
                    break;
                case "LP":
                    countries.Add(Country.Germany);
                    break;
                case "OL":
                    countries.Add(Country.Germany);
                    break;
                case "BC":
                    countries.Add(Country.Italy);
                    break;
                case "BO":
                    countries.Add(Country.Italy);
                    break;
                case "CE":
                    countries.Add(Country.Italy);
                    break;
                case "FO":
                    countries.Add(Country.Italy);
                    break;
                case "MA":
                    countries.Add(Country.Italy);
                    break;
                case "OB":
                    countries.Add(Country.Italy);
                    break;
                case "RC":
                    countries.Add(Country.Italy);
                    break;
                case "RE":
                    countries.Add(Country.Italy);
                    break;
                case "SA":
                    countries.Add(Country.Italy);
                    break;
                case "TD":
                    countries.Add(Country.Italy);
                    break;
                case "CA":
                    countries.Add(Country.Spain);
                    break;
                case "LO":
                    countries.Add(Country.Spain);
                    break;
                case "LB":
                    countries.Add(Country.Spain);
                    break;
                case "LM":
                    countries.Add(Country.Spain);
                    break;
                case "GI":
                    countries.Add(Country.Spain);
                    break;
                case "DI":
                    countries.Add(Country.Switzerland);
                    break;
                case "FA":
                    countries.Add(Country.Switzerland);
                    break;
                case "FC":
                    countries.Add(Country.USA);
                    break;
                case "FH":
                    countries.Add(Country.USA);
                    break;
                case "LA":
                    countries.Add(Country.USA);
                    break;
                case "OS":
                    countries.Add(Country.USA);
                    break;
                default:
                    break;
            }

            return countries.ToArray();
        }
    }
}
