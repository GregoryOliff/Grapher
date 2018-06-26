using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Grapher.Api.Models;
using Grapher.Core.Data;
using Grapher.Data;
using Grapher.Data.Repositories;

namespace Grapher.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        public IConfiguration Configuration { get; }
        
        //This method gets called by runtime, use to add services to the container
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddDbContext<GrapherContext>(options =>
                options.UseSqlServer(Configuration["ConnectionStrings:GrapherDb"]));
            services.AddTransient<IAircraftRepository, AircraftRepository>();
            services.AddTransient<IFlightRepository, FlightRepository>();
            services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
            services.AddSingleton<GrapherQuery>();
            services.AddSingleton<GrapherMutation>();
            services.AddSingleton<AircraftType>();
            services.AddSingleton<FlightType>();
            services.AddSingleton<AircraftInputType>();
            services.AddSingleton<FlightInputType>();
            var sp = services.BuildServiceProvider();
            services.AddSingleton<ISchema>(new GrapherSchema(new FuncDependencyResolver(type => sp.GetService(type))));
        }
        
        //this method also gets called by runtime, use to configure http request pipeline
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, GrapherContext db)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseGraphiQl();
            app.UseMvc();
            db.EnsureSeedData();
        }
    }
}