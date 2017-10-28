using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Breeder.Common.Dto;
using Microsoft.Extensions.Configuration;

namespace Breeder.Framework.Repositories
{
    public class PetRepository: BaseRepository, IDbRepository
    {
        private static IConfigurationRoot _configuration;

        public PetRepository(IConfigurationRoot configuration)
        {
            _configuration = configuration;
        }

        public ICollection<PetDto> GetPetsSync()
        {
            var list = new List<PetDto>();
            list.Add(new PetDto()
            {
                Id = Guid.NewGuid(),
                Name = "Dog 1",
                Gender = Common.Gender.Male,
                Price = 1000,
                IsAdult = true

            });
            list.Add(new PetDto()
            {
                Id = Guid.NewGuid(),
                Name = "Dog 2",
                Gender = Common.Gender.Female,
                Price = 1000,
                IsAdult = true,
                IsForSale = true

            });
            list.Add(new PetDto()
            {
                Id = Guid.NewGuid(),
                Name = "Dog 3",
                Gender = Common.Gender.Female,
                Price = 1000,
                Sir = list[0],
                Dam = list[1],
                IsForSale = true

            });

            list.Add(new PetDto()
            {
                Id = Guid.NewGuid(),
                Name = "Dog 4",
                Gender = Common.Gender.Female,
                Price = 1000,
                    Sir = list[0],
                Dam = list[1],
                IsForSale = true
            });

            list.Add(new PetDto()
            {
                Id = Guid.NewGuid(),
                Name = "Dog 5",
                Gender = Common.Gender.Female,
                Price = 1000,
                IsForSale = true
                    

            });

            list.Add(new PetDto()
            {
                Id = Guid.NewGuid(),
                Name = "Dog 6",
                Gender = Common.Gender.Female,
                Price = 1000,
                IsForSale = true

            });
            return list;
        }


        public async Task<ICollection<PetDto>> GetPets()
        {
            return GetPetsSync();
        }
    }
}