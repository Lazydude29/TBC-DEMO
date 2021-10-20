using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Data.Models.Entities
{
    public class Event
    {
        [Key]
        public int Id { get; set; }       
        
        public string CreatorId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreateDate { get; init; }
        public bool IsActive { get; set; }
    }
}
