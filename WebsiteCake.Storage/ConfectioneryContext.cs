using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebsiteCake.Storage.Entities;

namespace WebsiteCake.Storage
{
    public class ConfectioneryContext : DbContext
    {
        public ConfectioneryContext(DbContextOptions<ConfectioneryContext> options) : base(options)
        {

        }
        public DbSet<Cake> Cakes { get; set; }
        public DbSet<Сategory> Categories { get; set; }

        public DbSet<Client> Clients { get; set; }
        
        public DbSet<Filling> Fillings { get; set; }    

        public DbSet<Order> Order { get; set; } 

        public DbSet<CakeOrder> CakeOrders { get; set; }


    }
}
