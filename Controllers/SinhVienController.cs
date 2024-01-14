using DemoInterfaceService.Models.Entities;
using DemoInterfaceService.Repositories.SinhViens;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoInterfaceService.Controllers
{
    [Route("api/sinhvien")]
    [ApiController]
    public class SinhVienController : ControllerBase
    {
        private readonly ISinhVienRepository<SinhVien, Guid> _sinhVienRepository;

        public SinhVienController(ISinhVienRepository<SinhVien, Guid> sinhVienRepository)
        {
            _sinhVienRepository = sinhVienRepository;
        }
        //GET: /api/sinhvien
        [HttpGet]
        public async Task<IActionResult> GetAllSinhVien()
        {
            return Ok(await _sinhVienRepository.GetAll());
        }
        //GET: /api/sinhvien/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSinhVienId(Guid id)
        {
            return Ok(await _sinhVienRepository.GetById(id));
        }
        //POST: /api/sinhvien
        [HttpPost]
        public async Task<IActionResult> CreateSinhVien(SinhVien input)
        {
            return Ok(await _sinhVienRepository.Create(input));
        }
        //PUT: /api/sinhvien/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSinhVien(Guid id, SinhVien input)
        {
            return Ok(await _sinhVienRepository.Update(id, input));
        }
        //DELETE: /api/sinhvien/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSinhVien(Guid id)
        {
            return Ok(await _sinhVienRepository.DeleteById(id));
        }
    }
}
