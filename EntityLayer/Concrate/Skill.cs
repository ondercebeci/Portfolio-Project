﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrate
{
   public class Skill
    {
        [Key]
        public int SillID { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }

    }
}
