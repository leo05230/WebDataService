using System;
using System.Collections.Generic;
using System.Text;



namespace WebDataService.Domain.ApiModel
{
	public class Weather
	{
		public string success { get; set; }
		public Records records { get; set; }
	}
	

	public class Records
	{
		public Locations[] locations { get; set; }
	}

	public class Locations
	{
		public string datasetDescription { get; set; }
		public string locationsName { get; set; }
		public string dataid { get; set; }
		public Location[] location { get; set; }
	}

	public class Location
	{
		public string locationName { get; set; }
		public string geocode { get; set; }
		public string lat { get; set; }
		public string lon { get; set; }
		public Weatherelement[] weatherElement { get; set; }
	}

	public class Weatherelement
	{
		public string elementName { get; set; }
		public string description { get; set; }
		public Time[] time { get; set; }
	}

	public class Time
	{
		public string startTime { get; set; }
		public string endTime { get; set; }
		public Elementvalue[] elementValue { get; set; }
		public string dataTime { get; set; }
	}

	public class Elementvalue
	{
		public string value { get; set; }
		public string measures { get; set; }
	}
}
