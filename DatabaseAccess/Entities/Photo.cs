using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseAccess.Entities
{
    public class Photo
    {
        [Key]
        [Column("PhotoId")]
        public Guid Id { get; set; }

        public bool IsKeyPhoto { get; set; }

        [StringLength((int)DefaultStringLength.Name)]
        public string FileName { get; set; }

        [StringLength((int)DefaultStringLength.FileLink)]
        public string FileLink{ get; set; }

        public int Order { get; set; }

        public Guid PetId { get; set; }

        public virtual Pet Pet { get; set; }
    }
}
