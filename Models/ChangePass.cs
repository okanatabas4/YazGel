﻿namespace YazGel.Models
{
    public class ChangePass
    {
        public int studentId { get; set; }
        public int Id { get; set; }
        public string CurrentPass { get; set; }
        public string NewPass { get; set; }
    }
}
