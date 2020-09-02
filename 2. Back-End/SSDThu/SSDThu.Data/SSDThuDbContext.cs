using Microsoft.AspNet.Identity.EntityFramework;
using SSDThu.Model.Models;
using System.Data.Entity;


namespace SSDThu.Data
{
    public class SSDThuDbContext : IdentityDbContext<ApplicationUser>
    {
        public SSDThuDbContext() : base("SSDThuConnection")
        {
            this.Configuration.LazyLoadingEnabled = true;
        }

        public static SSDThuDbContext Create()
        {
            return new SSDThuDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
