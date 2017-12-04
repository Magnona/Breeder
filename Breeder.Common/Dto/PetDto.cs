using System;
using System.Collections.Generic;
using Breeder.Common;

namespace Breeder.Common.Dto
{
    public class PetDto
    {
        public PetDto()
        {
        }


        #region DAL Properites
        public int Id { get; set; }
        public string Name { get; set; }

        public Gender Gender { get; set; }

        public double Price { get; set; }

        public int ColorId { get; set; }

        public ColorDto Color { get; set; }

        public int BreedId { get; set; }

        public BreedDto Breed { get; set; }

        public string Description { get; set; }

        public DateTime? Birthdate { get; set; }

        public int StatusId { get; set; }

        public StatusDto Status { get; set; }

        public bool IsForSale { get; set; }

        public bool IsAdult { get; set; }

        public int? SirId { get; set; }

        public PetDto Sir { get; set; }

        public int? DamId { get; set; }

        public PetDto Dam { get; set; }

        public ICollection<PhotoDto> Photos { get; set; }
        public ICollection<VideoDto> Videos { get; set; }

        #endregion

        public bool HasPicture { get { return Photos != null && Photos.Count > 0; } }
    }
}
