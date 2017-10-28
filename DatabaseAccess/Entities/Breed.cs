using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseAccess.Entities
{
    public class Breed
    {
        [Key]
        [Column("BreedId")]
        public Guid Id { get; set; }

        [StringLength((int)DefaultStringLength.Name)]
        public string Name { get; set; }

        [StringLength((int)DefaultStringLength.Description)]
        public string Description { get; set; }
    }
}
