using ClientInventory.Business;
using ClientInventory.Repository;
using ClientInventory.Utils;
using Infra.Aspnet.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ClientInventory.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<AppSettings>(settings =>
            {
                settings.ConnectionString = Configuration.GetSection("MongoConnection:ConnectionString").Value;
                settings.DBName = Configuration.GetSection("MongoConnection:Database").Value;
            });



            services.AddMvc();
            services.AddScoped(typeof(AppSettings));
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IClientServices, ClientServices>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMiddleware<ExceptionHandler>();
            app.UseMvc();
        }
    }
}
