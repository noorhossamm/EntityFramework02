using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityFramework02
{
    internal class Attendee
    {
        public int Id { get; set; }

        [MaxLength(150)]
        [Required]
        public string FullName { get; set; }

        [MaxLength(200)]
        [Required]
        public string Email { get; set; }


        [MaxLength(100)]
        [Required]
        public string City { get; set; }


        [MaxLength(100)]
        [Required]
        public string Country { get; set; }


        [MaxLength(150)]
        [Required]
        public string Street { get; set; }
        
        [MaxLength(20)]
        [Required]
        [Column("ZipCode")]
        public string PostalCode { get; set; }

        [NotMapped]
        public string FullAddress
        {
            get
            {
                return $"{Street}, {City}, {Country}, {PostalCode}";
            }
        }

        public Badge Badge { get; set; }
    }
}
