using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Wipro.ProvaProgramacao.CSharpV3.Data;
using Wipro.ProvaProgramacao.CSharpV3.Infra.Interface;
using Wipro.ProvaProgramacao.CSharpV3.Infra.Repository;
using Wipro.ProvaProgramacao.CSharpV3.Service.Interface;
using Wipro.ProvaProgramacao.CSharpV3.Service;

namespace Wipro.ProvaProgramacao.CSharpV3.WebApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<WiproContext>(options=> 
                options.UseSqlServer(Configuration.GetConnectionString("SqlConnectionString")));

            services.AddTransient<WiproContext>();
            services.AddTransient<IFilaRepository, FilaRepository>();
            services.AddTransient<IFilaService, FilaService >();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
