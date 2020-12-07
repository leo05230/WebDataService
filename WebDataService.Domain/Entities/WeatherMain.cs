using System;
using System.Collections.Generic;

#nullable disable

namespace WebDataService.Domain.Entities
{
    public partial class WeatherMain
    {
        public WeatherMain()
        {
            WeatherDetails = new HashSet<WeatherDetail>();
        }

        public int IndexNo { get; set; }
        public string LocationId { get; set; }
        public string ApiId { get; set; }
        public DateTime Date { get; set; }
        public DateTime Ctime { get; set; }

        public virtual ICollection<WeatherDetail> WeatherDetails { get; set; }
    }
}
