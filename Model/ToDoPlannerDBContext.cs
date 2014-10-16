using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ToDoPlannerDbContext:DbContext
    {
        public ToDoPlannerDbContext():base("ToDoPlanner")
        {
            //Configuration.LazyLoadingEnabled = false;
        }
        
        public DbSet<ToDo> ToDos { get; set; }
        public DbSet<ToDoUser> ToDoUsers { get; set; }
        //public DbSet<ToDoAssignation> ToDoAssignations { get; set; }
    }
}
