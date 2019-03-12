namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BookInfo_View
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BkId { get; set; }

        [StringLength(50)]
        public string BkName { get; set; }

        [Column(TypeName = "money")]
        public decimal? BkPrice { get; set; }

        public DateTime? BkDate { get; set; }

        public int? TypeId { get; set; }

        [StringLength(50)]
        public string TypeName { get; set; }
    }
}
