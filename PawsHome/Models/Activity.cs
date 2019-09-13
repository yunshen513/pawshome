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

        public string url { get; set; }

        public string video { get; set; }

        public string atype { get; set; }
    }
}