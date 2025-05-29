using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication16_EmployeeManagementSystem.Models;

namespace WebApplication16_EmployeeManagementSystem.Data
{
    public class WebApplication16_EmployeeManagementSystemContext : DbContext
    {
        public WebApplication16_EmployeeManagementSystemContext (DbContextOptions<WebApplication16_EmployeeManagementSystemContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication16_EmployeeManagementSystem.Models.Employee> Employee { get; set; } = default!;
    }
}
