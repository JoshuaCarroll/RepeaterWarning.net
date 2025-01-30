using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RepeaterWarning.Models
{
    public class Repeater
    {
        private string _telemetryVoltageChannel;
		private string _telemetryGridPowerStatusChannel;
		private string _telemetryTempuratureChannel;
		private int _alertWhenRepeaterOfflineMoreThanTheseSeconds = 1800;
		private int _alertWhenVoltageDropsBelow = 125;

		public string Voltage;
		public string GridPower;
		public string Tempurature;
		public string LastStatusTime;
		public string Latitude;
		public string Longitude;
		public string Comment;
		public string Status;
		public string HealthyVoltage;
		public string HealthyGridPower;
        public string HealthyStatusTime;
        public string Callsign;

        public Repeater(string repeaterCallsign, object aprsFi, object telemetry, string telemetryGridPowerStatusChannel)
        {
			// Right now, these are the same for each repeater. However since it's possible that another
			// repeater might be added later that is different, I kept these as variables. If that were
			// to be needed, just add that variable to the constructor method as a parameter.
			_telemetryVoltageChannel = "1";
			_telemetryGridPowerStatusChannel = telemetryGridPowerStatusChannel;  //W5AUU-3 needs telemetryGridPowerStatusChannel to be 3
			_telemetryTempuratureChannel = "2";

			Callsign = repeaterCallsign;

			LastStatusTime = aprsFi.status_lasttime;
			Latitude = aprsFi["lat"];
			Longitude = aprsFi["lng"];
			Comment = aprsFi["comment"];
			Status = aprsFi["status"];

			Voltage = $telemetry["telemetry". $this->telemetryVoltageChannel];
			GridPower = $telemetry["telemetry". $this->telemetryGridPowerStatusChannel];
			Tempurature = $telemetry["telemetry". $this->telemetryTempuratureChannel];

			$this->HealthCheck();
        }
    }
}
