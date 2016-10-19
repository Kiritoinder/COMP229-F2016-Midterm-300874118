namespace COMP229_F2016_MidTerm_300874118.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ToDo")]
    public partial class ToDo
    {
        public int TodoID { get; set; }

        [Required]
        [StringLength(50)]
        public string ToDoDescription { get; set; }

        public string ToDoNotes { get; set; }

        [Required]
        [StringLength(10)]
        public string Compleated { get; set; }
    }
}
