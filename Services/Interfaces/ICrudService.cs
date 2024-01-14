namespace DemoInterfaceService.Services.Interfaces
{
    public interface ICrudService<TEntity, in TKey>
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(TKey id);
        Task<TEntity> Create(TEntity entity);
        Task<TEntity> Update(TKey id, TEntity entity);
        Task<TEntity> DeleteById(TKey id);
    }
}
