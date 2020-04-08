using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace tweetbook
{
    public interface IInstaller
    {
        void InstallServices(IServiceCollection services, IConfiguration configuration);
    }
}