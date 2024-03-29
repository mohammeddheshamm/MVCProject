using Demo.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Contexts
{
    public class MVCProjectDbContext :IdentityDbContext<ApplicationUser> 
    {
        // The object is created by clr through the constructor of the context.
        public MVCProjectDbContext(DbContextOptions<MVCProjectDbContext> options):base(options)
        {

        }
        
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    => optionsBuilder.UseSqlServer("Server =. ; Database =MVCProjectDb; Trusted_Connection=true" );

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
		//public DbSet<ApplicationUser> Users { get; set; }
	}
}
