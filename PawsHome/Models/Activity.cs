namespace PawsHome.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Activity")]
    public partial class Activity
    {
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        public string description { get; set; }

        public string picture { get; set; }

        public string video { get; set; }

        public int atype { get; set; }

        public int toy { get; set; }

        public int status { get; set; }

        public int duration { get; set; }
    }
}