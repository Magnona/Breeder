using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Breeder.Common;

namespace DatabaseAccess.Entities
{
    public class Pet
    {
        #region c-tor
        public Pet()
        {
            //Photos = new HashSet<Photo>();
           // Videos = new HashSet<Video>();
        }

        #endregion

        #region Properties
        [Key]
        [Column("PetId")]
        public Guid Id { get; set; }

        [StringLength((int)DefaultStringLength.Name)]
        public string Name { get; set; }

        public Gender Gender { get; set; }

        public double Price { get; set; }

        [StringLength((int)DefaultStringLength.Description)]
        public string Description { get; set; }

        public DateTime? Birthdate { get; set; }

        public bool IsForSale { get; set; }

        public bool IsAdult { get; set; }

        public Guid StatusId { get; set; }

        public Guid ColorId { get; set; }

        public Guid BreedId { get; set; }

        public Guid? SirId { get; set; }

        public Guid? DamId { get; set; }

        #region ForeignKey

        [ForeignKey(nameof(ColorId))]
        public Color Color { get; set; }

        [ForeignKey(nameof(StatusId))]
        public  Status Status { get; set; }

        [ForeignKey(nameof(SirId))]
        public  Pet Sir { get; set; }

        [ForeignKey(nameof(DamId))]
        public  Pet Dam { get; set; }

        [ForeignKey(nameof(BreedId))]
        public  Breed Breed { get; set; }

        public  ICollection<Photo> Photos { get; set; }
        public  ICollection<Video> Videos { get; set; }

        #endregion

        #endregion
    }
}
