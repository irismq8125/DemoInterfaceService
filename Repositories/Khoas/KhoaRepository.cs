using DemoInterfaceService.Models.Entities;

namespace DemoInterfaceService.Repositories.Khoas
{
    public class KhoaRepository : IKhoaRepository<Khoa, Guid>
    {
        private readonly DemoDbContext _demoDbContext;
        public KhoaRepository(DemoDbContext demoDbContext)
        {
            _demoDbContext = demoDbContext;
        }

        public Task<Khoa> Create(Khoa entity)
        {
            throw new NotImplementedException();
        }

        public Task<Khoa> DeleteById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Khoa>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Khoa> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Khoa> Update(Guid id, Khoa entity)
        {
            throw new NotImplementedException();
        }
    }
}
