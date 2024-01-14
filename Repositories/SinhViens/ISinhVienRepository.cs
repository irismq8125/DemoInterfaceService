using DemoInterfaceService.Services.Interfaces;

namespace DemoInterfaceService.Repositories.SinhViens
{
    public interface ISinhVienRepository<TEntity, TKey> : ICrudService<TEntity, TKey>
    {
    }
}
