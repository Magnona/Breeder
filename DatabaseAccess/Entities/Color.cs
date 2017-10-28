using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseAccess.Entities
{
    public class Color
    {
        [Key]
        [Column("ColorId")]
        public Guid Id { get; set; }

        [StringLength((int)DefaultStringLength.Name)]
        public string Name { get; set; }
    }
}
