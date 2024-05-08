﻿using KaiDns.Domain.Model;
using Microsoft.EntityFrameworkCore;


namespace KaiDns.Server
{
    internal class Startup
    {
        private readonly IWebHostEnvironment environment; // Используйте IWebHostEnvironment
        private readonly IConfiguration config;

        // Изменил тип параметра с IHostEnvironment на IWebHostEnvironment
        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            this.config = configuration;
            this.environment = environment;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // Add Services
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            var connectionString = config.GetConnectionString("Database_Connection"); // Используйте GetConnectionString
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

            app.UseEndpoints(endpoints => // Используйте UseEndpoints для маршрутизации контроллеров
            {
                endpoints.MapControllers();
            });

            // Удален вызов app.Run(), так как он не нужен в данном контексте
        }
    }
}