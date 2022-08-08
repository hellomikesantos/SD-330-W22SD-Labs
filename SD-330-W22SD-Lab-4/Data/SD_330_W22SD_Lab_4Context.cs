using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SD_330_W22SD_Lab_4.Models;

namespace SD_330_W22SD_Lab_4.Data
{
    public class SD_330_W22SD_Lab_4Context : DbContext
    {
        public SD_330_W22SD_Lab_4Context (DbContextOptions<SD_330_W22SD_Lab_4Context> options)
            : base(options)
        {
        }

        public DbSet<SD_330_W22SD_Lab_4.Models.Customer> Customer { get; set; } = default!;

        public DbSet<SD_330_W22SD_Lab_4.Models.Address>? Address { get; set; }
    }
}
