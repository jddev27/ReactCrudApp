using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Models
{
    public class DonationsDBContext: DbContext
    {
        public DonationsDBContext(DbContextOptions<DonationsDBContext> options): base(options)
        {
            
        }

        public DbSet<DCandidate> Candidates { get; set; }
    }
}
