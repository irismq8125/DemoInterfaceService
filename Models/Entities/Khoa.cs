using System.ComponentModel.DataAnnotations;

namespace DemoInterfaceService.Models.Entities
{
    public class Khoa
    {
        [Key]
        public Guid Id { get; set; }
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public string SDT { get; set; }
    }
}
