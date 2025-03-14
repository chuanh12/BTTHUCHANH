using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
namespace MvcMovie.Data 

#pragma warning restore format
{
    public class ApplicationDbcontext :DbContext
    {
        public ApplicationDbcontext( DbContextOptions<ApplicationDbcontext>options):base(options)
        {}
        public DbSet<Persion> Persion{get;set;}
         public DbSet<HeThongPhanPhoi> HeThongPhanPhois { get; set; }
        public DbSet<DaiLy> DaiLys { get; set; }
    }
}
    