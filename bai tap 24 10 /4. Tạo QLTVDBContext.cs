
using Microsoft.EntityFrameworkCore;
using QLTV.Models;

namespace QLTV.Data
{
    public class QLTVDBContext : DbContext
    {
        public QLTVDBContext(
            DbContextOptions<QLTVDBContext> options)
            : base(options)
        {
        }

        public DbSet<Sach> Sachs { get; set; }

        public DbSet<TheLoai> TheLoais { get; set; }
    }
}
