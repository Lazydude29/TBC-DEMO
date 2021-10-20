using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Models.Dtos.Events
{
    public class EventDto
    {
        public string Name { get; set; }
        public string Month { get; set; }
        public int Year { get; set; }
        public int Day { get; set; }
        public string Location { get; set; }
        public string ImageUrl { get; set; }
    }
}
