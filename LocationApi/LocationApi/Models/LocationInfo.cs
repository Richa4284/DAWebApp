using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LocationApi.Models
{
    public class LocationInfo
    {
        [Key]
        public int LocationID { get; set; }
        
        //for Prevent AutoIncrement
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FleetID { get; set; }

        [Required]
        public double Latitude { get; set; }

        [Required]
        public double Longitude { get; set; }

    }
}
