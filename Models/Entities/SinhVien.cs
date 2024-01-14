using System.ComponentModel.DataAnnotations;

namespace DemoInterfaceService.Models.Entities
{
    public class SinhVien
    {
        [Key]
        public Guid Id { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string GioiTInh { get; set; }
    }
}
