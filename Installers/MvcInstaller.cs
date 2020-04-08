using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace tweetbook.Installers
{
    public class MvcInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllersWithViews();
            services.AddRazorPages();

            services.AddSwaggerGen(x => 
            { 
                x.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo{Title = "Tweetbook API", Version = "v1"}); 
            });
        }
    }
}