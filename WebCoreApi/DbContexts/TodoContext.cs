using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using WebCoreApi.Models;

namespace WebCoreApi.DbContexts
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
           
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
