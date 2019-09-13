namespace PawsHome.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dog")]
    public partial class Dog
    {
        public int id { get; set; }

        [Required]
        public string breed { get; set; }

        [Required]
        public string url { get; set; }

        public string weight { get; set; }

        public string height { get; set; }

        public string expectancy { get; set; }

        public string origin { get; set; }

        public int? exercise { get; set; }

        public int? cost { get; set; }

        public string size { get; set; }

        public string temperament { get; set; }

        public string overview { get; set; }

        public string grooming { get; set; }

        public string feeding { get; set; }

        public string health { get; set; }

        public string fun { get; set; }

        public int? onetime { get; set; }

        public int? life { get; set; }
    }
}
