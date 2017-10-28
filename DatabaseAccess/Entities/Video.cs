using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseAccess.Entities
{
    public class Video
    {
        [Column("VideoId")]
        [Key]
        public Guid Id { get; set; }

        [StringLength((int)DefaultStringLength.Name)]
        public string FileName { get; set; }

        [StringLength((int)DefaultStringLength.FileLink)]
        public string VideoLink { get; set; }

        public int Order { get; set; }

        public Guid PetId { get; set; }

        public virtual Pet Pet { get; set; }
    }
}
