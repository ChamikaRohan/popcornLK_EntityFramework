using System.Xml;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using popcornLK.Models;

public class Contex : DbContext
{
    public DbSet<Customer> Customers { get; set; }

    public DbSet<Ticket> Tickets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMySql("server=127.0.0.1;port=3306;uid=root;pwd=achini123#;database=popcornlk", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.31-mysql"));
        }
    }
}