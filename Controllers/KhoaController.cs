using DemoInterfaceService.Models.Entities;
using DemoInterfaceService.Repositories.Khoas;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace DemoInterfaceService.Controllers
{
    [Route("api/khoa")]
    [ApiController]
    public class KhoaController : ControllerBase
    {
        private readonly IKhoaRepository<Khoa, Guid> _khoaRepository;
        public KhoaController(IKhoaRepository<Khoa, Guid> khoaRepository)
        {
            _khoaRepository = khoaRepository;
        }

        //GET: /api/khoa
        [HttpGet]
        public async Task<IActionResult> GetAllKhoa()
        {
            return Ok(await _khoaRepository.GetAll());
        }
        //GET: /api/khoa/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetKhoaId(Guid id)
        {
            return Ok(await _khoaRepository.GetById(id));
        }
        //POST: /api/khoa
        [HttpPost]
        public async Task<IActionResult> CreateKhoa(Khoa input)
        {
            return Ok(await _khoaRepository.Create(input));
        }
        //PUT: /api/khoa/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateKhoa(Guid id, Khoa input)
        {
            return Ok(await _khoaRepository.Update(id,input));
        }
        //DELETE: /api/khoa/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKhoa(Guid id)
        {
            return Ok(await _khoaRepository.DeleteById(id));
        }
    }
}
