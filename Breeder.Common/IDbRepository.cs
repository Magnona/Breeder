using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Breeder.Common.Dto;

namespace Breeder.Framework.Repositories
{
    public interface IDbRepository
    {
        Task<ICollection<PetDto>> GetPets();
    }
}
