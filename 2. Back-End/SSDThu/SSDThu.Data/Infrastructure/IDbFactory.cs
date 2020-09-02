using SSDThu.Data;
using System;

namespace uStora.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        SSDThuDbContext Init();
    }
}