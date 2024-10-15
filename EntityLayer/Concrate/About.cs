﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }


        [StringLength(1000)]
        public string AboutDetailts1 { get; set; }


        [StringLength(1000)]
        public string AboutDetailts2 { get; set; }


        [StringLength(200)]
        public string AboutImage1 { get; set; }
     
        [StringLength(200)]
        public string AboutImage2 { get; set; }
    }
}
