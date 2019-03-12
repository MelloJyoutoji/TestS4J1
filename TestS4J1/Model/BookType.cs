namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookType")]
    public partial class BookType
    {
        [Key]
        public int TypeId { get; set; }

        [StringLength(50)]
        public string TypeName { get; set; }
    }
}
