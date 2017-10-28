using System;
using AutoMapper;

namespace Breeder.Framework.Mappings
{
    public interface IMapping
    {
        void ConfigureMaps(IMapperConfigurationExpression mapper);
    }
}
