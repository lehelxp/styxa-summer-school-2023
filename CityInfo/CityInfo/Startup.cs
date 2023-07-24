using CityInfo.Contexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo
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
      //services.AddControllers();
      //services.AddMvc();
      services.AddMvc()
            .AddMvcOptions(options =>
            {
              options.OutputFormatters.Add(new XmlDataContractSerializerOutputFormatter());
            });

      services.AddDbContext<CityInfoContext>(o =>
      {
        o.UseSqlServer("Server=(local);Database=CityInfoDB;Trusted_Connection=True;");
      });

      services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
      services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                  policy =>
                  {
                      policy.WithOrigins("http://localhost:3000").AllowAnyHeader().AllowAnyMethod();
                      policy.WithOrigins("192.168.1.26:3000").AllowAnyHeader().AllowAnyMethod();
                  });
       });
        }
// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      app.UseCors();
      app.UseRouting();

      app.UseStatusCodePages();

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}
