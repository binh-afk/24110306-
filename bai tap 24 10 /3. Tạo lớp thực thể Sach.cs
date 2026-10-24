
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLTV.Models
{
    public class Sach
    {
        [Key]
        public int SachId { get; set; }

        [Required]
        [MaxLength(200)]
        public string TenSach { get; set; } = string.Empty;

        [MaxLength(100)]
        public string TacGia { get; set; } = string.Empty;

        public int NamXuatBan { get; set; }

        // Khóa ngoại
        public int TheLoaiId { get; set; }

        // Quan hệ với thể loại
        [ForeignKey(nameof(TheLoaiId))]
        public TheLoai TheLoai { get; set; } = null!;
    }
}
