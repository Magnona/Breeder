using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseAccess.Entities
{
    public class Status
    {
        [Key]
        [Column("StatusId")]
        public Guid Id { get; set; }

        [StringLength((int)DefaultStringLength.Name)]
        public string Name { get; set; }
    }
}
