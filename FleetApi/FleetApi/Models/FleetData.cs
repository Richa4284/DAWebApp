﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FleetApi.Models
{
    public class FleetData
    {
        [Key]
        public long FleetID { get; set; }

        [Required]
        [MaxLength(17)]
        public string FleetRCNo { get; set; }

        [Required]
        [MaxLength(20)]
        public string FleetType { get; set; }

        [Required]
        [MaxLength(50)]
        public string CompanyName { get; set; }

        //[ForeignKey("OwnerId")]
       // public OwnerData Owner { get; set; }

        [Required]
        public long OwnerId { get; set; }
    }
}
