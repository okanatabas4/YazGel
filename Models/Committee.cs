﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YazGel.Models
{
    public class Committee
    {
        [Key]

        public int Id{ get; set; }
        public int teacherId { get; set; }
        public Teacher tId { get; set; }
        public int role { get; set; }
        public Role Role { get; set; }
    }
}
