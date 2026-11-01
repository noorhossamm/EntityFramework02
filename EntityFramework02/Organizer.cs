using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityFramework02
{
    [Table("EventOrganizers")]
    internal class Organizer
    {
        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Name { get; set; }


        [MaxLength(150)]
        public string ? CompanyName { get; set; }
        public OrganizerProfile Profile { get; set; }
        public ICollection<Event> Events { get; set; } = new List<Event>();



    }
}
