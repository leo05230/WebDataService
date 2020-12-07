using System;
using System.Collections.Generic;

#nullable disable

namespace WebDataService.Domain.Entities
{
    public partial class WeatherDetail
    {
        public int IndexNo { get; set; }
        public int MainNo { get; set; }
        public string AreaId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public decimal RainRatio { get; set; }
        public string States { get; set; }
        public decimal BodyTemperature { get; set; }
        public decimal Temperature { get; set; }
        public decimal Humidity { get; set; }
        public decimal ComfortIndex { get; set; }
        public string Comfort { get; set; }
        public string Detail { get; set; }
        public decimal WindSpeed { get; set; }
        public string WindDirection { get; set; }
        public decimal DewPoint { get; set; }

        public virtual WeatherMain MainNoNavigation { get; set; }
    }
}
