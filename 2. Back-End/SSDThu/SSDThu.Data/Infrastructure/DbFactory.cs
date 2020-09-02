using SSDThu.Data;

namespace uStora.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private SSDThuDbContext dbContext;

        public SSDThuDbContext Init()
        {
            return dbContext ?? (dbContext = new SSDThuDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}