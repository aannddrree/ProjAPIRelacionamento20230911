using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjAPIRelacionamento20230911.Models;

namespace ProjAPIRelacionamento20230911.Data
{
    public class ProjAPIRelacionamento20230911Context : DbContext
    {
        public ProjAPIRelacionamento20230911Context (DbContextOptions<ProjAPIRelacionamento20230911Context> options)
            : base(options)
        {
        }

        public DbSet<ProjAPIRelacionamento20230911.Models.Person> Person { get; set; } = default!;
    }
}
