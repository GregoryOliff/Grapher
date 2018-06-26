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
            services.AddMvc(
                options =>
                {
                    options.SslPort = 5000;
                    options.Filters.Add(new RequireHttpsAttribute());
                });
            services.AddAntiForgery(
                options =>
                {
                    options.Cookie.Name = "_af";
                    options.Cookie.HttpOnly = true;
                    options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
                    options.HeaderName = "X-XSRF-TOKEN";
                });
            services.AddSpaStaticFiles(configuration => { configuration.RootPath = "ClientApp/build"; })
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
            else
            {
                app.UseExceptionHandler("/Home/Error/");
            }

            app.UseStaticFiles();
            app.UseSpaStaticFiles():
            app.UseGraphiQl();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });
            app.UseSpaStaticFiles(spa =>
            {
                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }
            });
            db.EnsureSeedData();
        }
    }
}