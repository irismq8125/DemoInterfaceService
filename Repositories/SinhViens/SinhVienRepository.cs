using DemoInterfaceService.Models.Entities;

namespace DemoInterfaceService.Repositories.SinhViens
{
    public class SinhVienRepository : ISinhVienRepository<SinhVien, Guid>
    {
        private readonly DemoDbContext _context;
        public SinhVienRepository(DemoDbContext context)
        {
            _context = context;
        }

        public Task<SinhVien> Create(SinhVien entity)
        {
            throw new NotImplementedException();
        }

        public Task<SinhVien> DeleteById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SinhVien>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<SinhVien> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<SinhVien> Update(Guid id, SinhVien entity)
        {
            throw new NotImplementedException();
        }
    }
}
