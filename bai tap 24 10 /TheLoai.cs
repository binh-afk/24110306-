
using System.ComponentModel.DataAnnotations;

namespace QLTV.Models
{
    public class TheLoai
    {
        [Key]
        public int TheLoaiId { get; set; }

        [Required]
        [MaxLength(100)]
        public string TenTheLoai { get; set; } = string.Empty;

        // Một thể loại có nhiều sách
        public ICollection<Sach> Sachs { get; set; }
            = new List<Sach>();
    }
}
