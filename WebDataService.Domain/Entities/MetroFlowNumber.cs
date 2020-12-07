using System;
using System.Collections.Generic;

#nullable disable

namespace WebDataService.Domain.Entities
{
    public partial class MetroFlowNumber
    {
        public int IndexNo { get; set; }
        public string Station { get; set; }
        public DateTime RecordDate { get; set; }
        public int Outbound { get; set; }
        public int Inbound { get; set; }
    }
}
