using Microsoft.EntityFrameworkCore;

namespace GestaoHotelariaAPI.Models
{
    public class GestaoHotelariaContext : DbContext
    {
        public GestaoHotelariaContext(DbContextOptions<GestaoHotelariaContext> options) : base(options)
        {
        }

        public DbSet<Utilizador> Utilizadores{ get; set; }


    }
}

