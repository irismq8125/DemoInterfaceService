﻿using DemoInterfaceService.Models.Entities;
using Microsoft.EntityFrameworkCore;

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

        public async Task<IEnumerable<Khoa>> GetAll()
        {
            return await _demoDbContext.khoas.ToListAsync();
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
