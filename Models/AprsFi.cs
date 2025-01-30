using System.Text.Json.Serialization;

namespace RepeaterWarning.Models
{
    public class AprsFi
    {
        // Consider making it a static class

        // Get data from settings URL
    }

    public class AprsFiResponse
    {
        /// <summary>
        /// the API command which was called
        /// </summary>
        [JsonPropertyName("command")]
        public string? Command;

        /// <summary>
        /// what was being queried
        /// </summary>
        [JsonPropertyName("what")]
        public string? What;

        /// <summary>
        /// the result of the query, either ok or fail
        /// </summary>
        [JsonPropertyName("result")]
        public string? Result;

        /// <summary>
        /// the number of entries returned
        /// </summary>
        [JsonPropertyName("found")]
        public int Found;

        [JsonPropertyName("entries")]
        public List<AprsFiEntry>? AprsFiEntries;
    }

    public class AprsFiEntry
    {
        private string? _destinationCall;

        /// <summary>
        /// class of station identifier (a: APRS, i: AIS, w: Web ...)
        /// </summary>
        [JsonPropertyName("class")]
        public string? StationClass { get; set; }

        /// <summary>
        /// name of station, object, item or vessel
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// displayed name of station (may differ from the unique name)
        /// </summary>
        [JsonPropertyName("showname")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// type of target: a for AIS, l for APRS station, i for APRS item,
        ///        o for APRS object, w for weather station
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// the time when the target first reported this (current) position
        ///        (the time of arrival at current coordinates)
        /// </summary>
        [JsonPropertyName("time")]
        public string? Time { get; set; }

        /// <summary>
        /// the time when the target last reported this (current) position
        /// </summary>
        [JsonPropertyName("lasttime")]
        public string? LastTime { get; set; }

        /// <summary>
        /// latitude in decimal degrees, north is positive
        /// </summary>
        [JsonPropertyName("lat")]
        public string? Latitude { get; set; }

        /// <summary>
        /// longitude in decimal degrees, east is positive
        /// </summary>
        [JsonPropertyName("lng")]
        public string? Longitude { get; set; }

        /// <summary>
        /// Course over ground / COG, in degrees
        /// </summary>
        [JsonPropertyName("course")]
        public string? Course { get; set; }

        /// <summary>
        /// Speed, in kilometers per hour
        /// </summary>
        [JsonPropertyName("speed")]
        public string? Speed { get; set; }

        /// <summary>
        /// Altitude, in meters
        /// </summary>
        [JsonPropertyName("altitude")]
        public string? Altitude { get; set; }

        /// <summary>
        /// APRS symbol table and code
        /// </summary>
        [JsonPropertyName("symbol")]
        public string? Symbol { get; set; }

        /// <summary>
        /// Source callsign - either APRS source callsign or AIS vessel callsign
        /// </summary>
        [JsonPropertyName("srccall")]
        public string? SourceCallsign { get; set; }

        /// <summary>
        /// APRS packet destination callsign
        /// </summary>
        [JsonPropertyName("dstcall")]
        public string? DestinationCallsign
        {
            get => _destinationCall;
            set => _destinationCall = value;
        }

        /// <summary>
        /// comment - APRS comment or AIS destination and estimated time of arrival
        /// </summary>
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// path - APRS or AIS packet path
        /// </summary>
        [JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// phg - APRS PHG value
        /// </summary>
        [JsonPropertyName("phg")]
        public string? Phg { get; set; }

        /// <summary>
        /// status - Last status message transmitted by station
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// status_lasttime - The time when the last status message was received
        /// </summary>
        [JsonPropertyName("status_lasttime")]
        public string? StatusLastTime { get; set; }

        #region Additional fields for AIS targets
        /// <summary>
        /// mmsi - AIS vessel MMSI number
        /// </summary>
        [JsonPropertyName("mmsi")]
        public string? Mmsi { get; set; }

        /// <summary>
        /// imo - AIS vessel IMO number
        /// </summary>
        [JsonPropertyName("imo")]
        public string? Imo { get; set; }

        /// <summary>
        /// vesselclass - AIS vessel class code
        /// </summary>
        [JsonPropertyName("vesselclass")]
        public string? Vesselclass { get; set; }

        /// <summary>
        /// navstat - AIS navigational status code
        /// </summary>
        [JsonPropertyName("navstat")]
        public string? Navstat { get; set; }

        /// <summary>
        /// heading - Heading
        /// </summary>
        [JsonPropertyName("heading")]
        public string? Heading { get; set; }

        /// <summary>
        /// length - AIS vessel length in meters
        /// </summary>
        [JsonPropertyName("length")]
        public string? Length { get; set; }

        /// <summary>
        /// width - AIS vessel width in meters
        /// </summary>
        [JsonPropertyName("width")]
        public string? Width { get; set; }

        /// <summary>
        /// draught - AIS vessel draught in meters
        /// </summary>
        [JsonPropertyName("draught")]
        public string? Draught { get; set; }

        /// <summary>
        /// ref_front - AIS vessel position reference distance from the front
        /// </summary>
        [JsonPropertyName("ref_front")]
        public string? RefFront { get; set; }

        /// <summary>
        /// ref_left - AIS vessel position reference distance from the left
        /// </summary>
        [JsonPropertyName("ref_left")]
        public string? RefLeft { get; set; }
        #endregion

        #region Additional fields for weather stations
        /// <summary>
        /// temp - Temperature in degrees Celsius
        /// </summary>
        [JsonPropertyName("temp")]
        public string? Temperature { get; set; }

        /// <summary>
        /// pressure - Atmospheric pressure, in millibars (mbar)
        /// </summary>
        [JsonPropertyName("pressure")]
        public string? Pressure { get; set; }

        /// <summary>
        /// humidity - Relative air humidity, %
        /// </summary>
        [JsonPropertyName("humidity")]
        public string? Humidity { get; set; }

        /// <summary>
        /// wind_direction - Average wind direction
        /// </summary>
        [JsonPropertyName("wind_direction")]
        public string? WindDirection { get; set; }

        /// <summary>
        /// wind_speed - Average wind speed, in meters per second
        /// </summary>
        [JsonPropertyName("wind_speed")]
        public string? WindSpeed { get; set; }

        /// <summary>
        /// wind_gust - Wind gust, m/s
        /// </summary>
        [JsonPropertyName("wind_gust")]
        public string? WindGust { get; set; }

        /// <summary>
        /// rain_1h - Rainfall over past 1 hour, in millimeters
        /// </summary>
        [JsonPropertyName("rain_1h")]
        public string? RainPastHour { get; set; }

        /// <summary>
        /// rain_24h - Rainfall over past 24 hours, in mm
        /// </summary>
        [JsonPropertyName("rain_24h")]
        public string? RainPast24Hours { get; set; }

        /// <summary>
        /// rain_mn - Rainfall since midnight, in mm
        /// </summary>
        [JsonPropertyName("rain_mn")]
        public string? RainSinceMidnight { get; set; }

        /// <summary>
        /// luminosity - Luminosity, watts / square meter (W/m^2)
        /// </summary>
        [JsonPropertyName("luminosity")]
        public string? Luminosity { get; set; }
        #endregion

        #region Additional fields for text messages
        /// <summary>
        /// messageid - an incrementing id of the message (will wrap to 0 some day)
        /// </summary>
        [JsonPropertyName("messageid")]
        public string? Messageid { get; set; }

        /// <summary>
        /// dst - APRS message destination
        /// </summary>
        [JsonPropertyName("dst")]
        public string? Dst
        {
            get => _destinationCall;
            set => _destinationCall = value;
        }

        /// <summary>
        /// message - The message contents
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; set; }
        #endregion
    }

}
