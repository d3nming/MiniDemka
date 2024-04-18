namespace bib.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Activity")]
    public partial class Activity
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string NameEvent { get; set; }

        public DateTime? DateStart { get; set; }

        public int? Days { get; set; }

        [Column("Activity")]
        [StringLength(100)]
        public string Activity1 { get; set; }

        public int? Day { get; set; }

        public TimeSpan? TimeStart { get; set; }

        public int? Moderator { get; set; }

        public virtual Moderator Moderator1 { get; set; }
    }
}
