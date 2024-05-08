using KaiDns.Domain.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;
namespace KaiDns.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
             WebHost.CreateDefaultBuilder(args)
                 .UseStartup<Startup>()     ;
    }
    //    public static void Main(string[] args)
    //    {
    //        var builder = WebApplication.CreateBuilder(args);

    //        // Add services to the container.
    //        string connectionString = ConfigurationManager.ConnectionStrings["YourConnectionStringName"].ConnectionString;
    //        builder.Services.AddControllers();
    //        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    //        builder.Services.AddEndpointsApiExplorer();
    //        builder.Services.AddSwaggerGen();
    //        var t = builder.Configuration.GetConnectionString("Database_Connection");
    //        builder.Services.AddDbContext<Db4660Context>(option =>
    //option.UseSqlServer(t));
    //        var app = builder.Build();

    //        // Configure the HTTP request pipeline.

    //        app.UseSwagger();
    //        app.UseSwaggerUI();


    //        app.UseHttpsRedirection();

    //        app.UseAuthorization();


    //        app.MapControllers();

    //        app.Run();
    //    }

}