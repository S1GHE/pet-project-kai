
using System.Text.Json.Serialization;
using KaiDns.Domain.Model;
using KaiDns.Server.Repositories;
using KaiDns.Server.Services;
using KaiDns.Server.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration; 

namespace KaiDns.Server
{
    public class Startup
    {
        //private readonly IWebHostEnvironment environment; // Используйте IWebHostEnvironment
        private  IConfiguration config;

        // Изменил тип параметра с IHostEnvironment на IWebHostEnvironment
        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            this.config = configuration;
            //this.environment = environment;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //services.FullRegistrationServerServices(config, out var serverOption);
            // Add Services
            services.AddScoped<CatalogRepository>();
            services.AddControllers();
            services.AddEndpointsApiExplorer(); 
            services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);
            services.AddSwaggerGen();
            services.AddScoped<CatalogRepository>();
            services.AddScoped<IAuthorizationService, AuthorizationService>();
            services.AddScoped<IEmailService, EmailService>();


            var connectionString = "Data Source=db4660.public.databaseasp.net;Initial Catalog=db4660;Persist Security Info=True;User ID=db4660;Password=wX@3N+2j-yD4; TrustServerCertificate=True"; //config["Database_Connection"]; // Используйте GetConnectionString
            services.AddDbContext<Db4660Context>(options =>
                options.UseSqlServer(connectionString)); // Используйте options
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();
            app.UseRouting(); // Добавлен вызов UseRouting

            app.UseAuthorization();
            var pathBase = config["PATH_BASE"];
            if (!string.IsNullOrWhiteSpace(pathBase))
            {
                pathBase = $"/{pathBase}";
                app.UsePathBase(pathBase);
            }
            app.UseEndpoints(endpoints => // Используйте UseEndpoints для маршрутизации контроллеров
            {
                endpoints.MapControllers();
            });

            // Удален вызов app.Run(), так как он не нужен в данном контексте
        }
    }
}
