using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Breeder.Common.Dto;
using Microsoft.Extensions.Configuration;

namespace Breeder.Framework.Repositories
{
    public class PetRepository: BaseRepository, IDbRepository
    {
        public ICollection<PetDto> GetAllPets()
        {
            var list = new List<PetDto>();
            list.Add(new PetDto()
            {
                Id = 22,
                Name = "Father Dog Name",
                Gender = Common.Gender.Male,
                IsAdult = true

            });
            list.Add(new PetDto()
            {
                Id = 23,
                Name = "Mom Dog Name",
                Gender = Common.Gender.Female,
                IsAdult = true

            });

            list.Add(new PetDto()
            {
                Id = 1,
                Name = "Dog 1",
                Gender = Common.Gender.Male,
                Price = 1000,
                IsAdult = true,
                Sir = list[0],
                Dam = list[1]

            });
            list.Add(new PetDto()
            {
                Id = 2,
                Name = "Dog 2",
                Gender = Common.Gender.Female,
                Price = 1000,
                IsAdult = true,
                IsForSale = true,
                Sir = list[0]

            });
            list.Add(new PetDto()
            {
                Id = 3,
                Name = "Dog 3",
                Gender = Common.Gender.Female,
                Price = 1000,
                Sir = list[2],
                Dam = list[3],
                IsForSale = true,
                Birthdate = DateTime.Now.AddMonths(-3),
                Status = new StatusDto(){Name = "Available"}

            });

            list.Add(new PetDto()
            {
                Id = 4,
                Name = "Dog 4",
                Gender = Common.Gender.Female,
                Price = 1000,
                    Sir = list[0],
                Dam = list[1],
                IsForSale = true,
                Status = new StatusDto() { Name = "Available" }
            });

            list.Add(new PetDto()
            {
                Id = 5,
                Name = "Dog 5",
                Gender = Common.Gender.Female,
                Price = 1000,
                IsForSale = true,
                Status = new StatusDto() { Name = "Sold" }
                    

            });

            list.Add(new PetDto()
            {
                Id = 6,
                Name = "Dog 6",
                Gender = Common.Gender.Female,
                Price = 1000,
                IsForSale = true,
                Status = new StatusDto() { Name = "Reserved" }

            });


           

            return list;

        }


        public async Task<ICollection<PetDto>> GetPets()
        {
            return GetAllPets();
        }
    }
}