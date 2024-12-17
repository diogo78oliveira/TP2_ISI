using GestaoHotelariaAPI.Models;
using GestaoHotelariaAPI.Service.UtilizadorService;
using ISI_WebAPI.Service.UtilizadorService;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace GestaoHotelariaAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddDbContext<GestaoHotelariaContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("GestaoHotelariaContext")));


            builder.Services.AddScoped<IUtilizador, UtilizadorService>();
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}
