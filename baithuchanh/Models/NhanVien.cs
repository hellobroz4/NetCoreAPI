using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace baithuchanh.Models
{
    [Table("NhanVien")]
    public class NhanVien
    {
        [Key]
        public string Sdt { get; set; }
        public string NhanVienId { get; set; } // Tên khóa chính cho NhanVien
        public string FullName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        // Thêm các trường khác nếu cần
    }
}
