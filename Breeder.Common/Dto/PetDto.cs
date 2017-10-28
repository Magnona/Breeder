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
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Gender Gender { get; set; }

        public double Price { get; set; }

        public Guid ColorId { get; set; }

        public ColorDto Color { get; set; }

        public Guid BreedId { get; set; }

        public BreedDto Breed { get; set; }

        public string Description { get; set; }

        public DateTime? Birthdate { get; set; }

        public Guid StatusId { get; set; }

        public StatusDto Status { get; set; }

        public bool IsForSale { get; set; }

        public bool IsAdult { get; set; }

        public Guid? SirId { get; set; }

        public PetDto Sir { get; set; }

        public Guid? DamId { get; set; }

        public PetDto Dam { get; set; }

        public ICollection<PhotoDto> Photos { get; set; }
        public ICollection<VideoDto> Videos { get; set; }

        #endregion

        public bool HasPicture { get { return Photos != null && Photos.Count > 0; } }
    }
}
