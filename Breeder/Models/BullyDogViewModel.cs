using System.Collections.Generic;
using Breeder.Common.Dto;

namespace BreederWeb.Models
{
    public class BullyDogViewModel
    {

        public ICollection<PetDto> Pets
        {
            get; set;
        }

        public PetDto SelectedPet
        {
            get; set;
        }

        public string Title
        {
            get;set;
        }
       
    }
}
