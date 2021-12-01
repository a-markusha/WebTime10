﻿using System.ComponentModel.DataAnnotations;

namespace WebTime10.Data.Models
{
    public class TimeTable
    {
        [Key] public int Id { get; set; }
        public Admin Admin { get; set; }
        public string Time { get; set; }
        public Trainer Trainer { get; set; }
        public Hall Hall { get; set; }
        public int ClientCount { get; set; }
        public string NameTraining { get; set; }
        public TypeTraining TypeTraining { get; set; }
    }
}