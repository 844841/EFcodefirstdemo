using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFcodefirstdemo
{
    class EmployeeContext : DbContext   //DbContext interacts with the backend DB nd DBset for coll of entities.
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
