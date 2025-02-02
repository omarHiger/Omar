﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OurHospitalManagmentSystem.Class_Attriputes
{
    public class Doctor_Phone_Numbers
    {
        [Key] 
        [Column(Order = 1)]
        public int Doctor_Id { get; set; }
        [Required]
        [Key]
        [Column(Order = 2)]
        public string Doctor_Phone_Number { get; set; }
    }
}
