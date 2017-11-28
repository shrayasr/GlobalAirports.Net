using System;
using System.Collections.Generic;

namespace GADB.Net
{
    public class Airport
    {
        public string ICAOCode { get; set; }
        public string IATACode { get; set; }
        public string AirportName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int? LatitudeDegrees { get; set; }
        public int? LatitudeMinutes { get; set; }
        public int? LatitudeSeconds { get; set; }
        public char? LatitudeDirection { get; set; }
        public int? LongitudeDegrees { get; set; }
        public int? LongitudeMinutes { get; set; }
        public int? LongitudeSeconds { get; set; }
        public char? LongitudeDirection { get; set; }
        public int? Altitude { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }

        public Airport(List<string> splits)
        {
            ICAOCode = GetString(splits[0]);
            IATACode = GetString(splits[1]);
            AirportName = GetString(splits[2]);

            City = GetString(splits[3]);
            Country = GetString(splits[4]);

            LatitudeDegrees = GetInt(splits[5]);
            LatitudeMinutes = GetInt(splits[6]);
            LatitudeSeconds = GetInt(splits[7]);
            LatitudeDirection = GetChar(splits[8]);

            LongitudeDegrees = GetInt(splits[9]);
            LongitudeMinutes = GetInt(splits[10]);
            LongitudeSeconds = GetInt(splits[11]);
            LongitudeDirection = GetChar(splits[12]);

            Altitude = GetInt(splits[13]);

            Latitude = GetDecimal(splits[14]);
            Longitude = GetDecimal(splits[15]);
        }

        private string GetString(string value)
            => value == "N/A" ? null : value;

        private int? GetInt(string value)
        {
            int intVal = Convert.ToInt32(value);
            int? retVal = null;

            if (intVal != 0)
                retVal = intVal;

            return retVal;
        }

        private char? GetChar(string value)
        {
            char? retVal = null;

            if (value != "U")
                retVal = value[0];

            return retVal;
        }

        private decimal? GetDecimal(string value)
        {
            decimal decVal = Convert.ToDecimal(value);
            decimal? retVal = null;

            if (decVal != 0.0m)
                retVal = decVal;

            return retVal;
        }
    }
}
