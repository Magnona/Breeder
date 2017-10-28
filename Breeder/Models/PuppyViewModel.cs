using System;
using System.Collections.Generic;
using Breeder.Common.Dto;
using Breeder.Framework.Repositories;
using Microsoft.Extensions.Configuration;

namespace BreederWeb.Models
{
    public class PuppyViewModel
    {
        private static IConfigurationRoot _configuration;
        public PuppyViewModel(IConfigurationRoot configuration)
        {
        }


        public void Init(){

            var repo = new PetRepository(_configuration);
            Puppies = repo.GetPetsSync();

        }
        public ICollection<PetDto> Puppies
        {
            get;set;
        }
    }
}
