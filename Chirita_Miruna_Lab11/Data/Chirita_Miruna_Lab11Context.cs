using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Chirita_Miruna_Lab11.Models;

namespace Chirita_Miruna_Lab11.Data
{
    public class Chirita_Miruna_Lab11Context : DbContext
    {
        public Chirita_Miruna_Lab11Context (DbContextOptions<Chirita_Miruna_Lab11Context> options)
            : base(options)
        {
        }

        public DbSet<Chirita_Miruna_Lab11.Models.ShopList> ShopList { get; set; } = default!;
    }
}
