using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Final_Test_Core_Application.Models;

namespace Final_Test_Core_Application.Data
{
    public class Final_Test_Core_ApplicationContext : DbContext
    {
        public Final_Test_Core_ApplicationContext (DbContextOptions<Final_Test_Core_ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Final_Test_Core_Application.Models.Owner> Owner { get; set; }

        public DbSet<Final_Test_Core_Application.Models.Pet> Pet { get; set; }
    }
}
