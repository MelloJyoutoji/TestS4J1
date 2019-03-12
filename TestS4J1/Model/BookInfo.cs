namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookInfo")]
    public partial class BookInfo
    {
        [Key]
        public int BkId { get; set; }

        [StringLength(50)]
        public string BkName { get; set; }

        [Column(TypeName = "money")]
        public decimal? BkPrice { get; set; }

        public DateTime? BkDate { get; set; }

        public int? TypeId { get; set; }
    }
}
