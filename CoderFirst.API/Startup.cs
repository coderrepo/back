using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using CMS.UIServices.Advertisment;

namespace CoderFirst.API
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
            services.AddMvc();

            var sqlConnectionString = "server=localhost;userid=zainab;pwd=hello@123;port=3306;database=coderfirst;sslmode=none;"; // Configuration.GetConnectionString("DataAccessMySqlProvider");

            services.AddDbContext<CoderFirst.DataAccess.BaseContext>(options => options.UseMySql(sqlConnectionString)
        );

         services.AddScoped<IAdvertismentService, AdvertismentService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
