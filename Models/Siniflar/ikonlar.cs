﻿using System.ComponentModel.DataAnnotations;


namespace WebApplication33333.Models.Siniflar
{
    public class ikonlar
    {
        [Key]
        public int id { get; set; }
        public string ikon { get; set; }
        public string link { get; set; }
    }
}