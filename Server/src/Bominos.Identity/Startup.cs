namespace Bominos.Identity
{
    using Bominos.Identity.Data;
    using Bominos.Identity.Infrastructure;
    using Bominos.Identity.Services.Identity;
    using Bominos.Infrastructure;
    using Bominos.Services;
    
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public class Startup
    {
        public Startup(IConfiguration configuration) => this.Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services) =>
            services.AddWebService<IdentityDbContext>(this.Configuration)
                    .AddUserStorage()
                    .AddTransient<IDataSeeder, IdentityDataSeeder>()
                    .AddTransient<IIdentityService, IdentityService>()
                    .AddTransient<ITokenGeneratorService, TokenGeneratorService>();

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) =>
            app.UseWebService(env).Initialize();
    }
}