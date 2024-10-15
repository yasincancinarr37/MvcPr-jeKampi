﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Content
    {
        [Key]
        public int ContentID { get; set; }

        [StringLength(100)]
        public string ContentValue { get; set; }

        public DateTime ContentDate { get; set; }
        //Content yazar
        //contentBaşlık


        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; }


        public int? WriterID { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
