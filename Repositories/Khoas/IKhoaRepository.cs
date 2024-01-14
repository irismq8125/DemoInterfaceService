using DemoInterfaceService.Services.Interfaces;

namespace DemoInterfaceService.Repositories.Khoas
{
    public interface IKhoaRepository<TEntity, TKey> : ICrudService<TEntity, TKey>
    {
    }
}
