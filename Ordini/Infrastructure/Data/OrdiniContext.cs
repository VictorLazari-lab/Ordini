using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Controllers;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class OrdiniContext : DbContext
    {

        public OrdiniContext(DbContextOptions<OrdiniContext> options) : base(options)
        {
        }
        public DbSet<Prodotto> Prodotti { get; set; }
    }
}