using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using GestaoHotelariaAPI.Models;

namespace GestaoHotelariaAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Carregar a string de conexão
            builder.Services.AddDbContext<GestaoHotelariaContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("GestaoHotelariaContext")));

            // Outros serviços
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
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}