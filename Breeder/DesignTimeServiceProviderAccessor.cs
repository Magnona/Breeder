using System;
namespace BreederWeb
{
    public class DesignTimeServiceProviderAccessor : IDesignTimeServiceProviderAccessor
    {
        public IServiceProvider GetServiceProvider(string[] args)
            => Program.BuildWebHost(args).Services;
    }
}
