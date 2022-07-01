using Microsoft.EntityFrameworkCore;
using PureGame.Entity;

namespace PureGame
{
    public class ApplicationContext : DbContext
    {
        readonly string _connectionString;
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            /*Database.EnsureCreated();  *///подключение к БД
        }
        public ApplicationContext() : base()
        { }
        public ApplicationContext(string connectionString) : base()
        {
            _connectionString = connectionString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=PureGame;Trusted_Connection=True;");
            }
        }
    }
}
