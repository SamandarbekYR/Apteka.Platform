using Domian.Entities;

namespace DataAccesLayer.Interfaces;

public interface IRepository<TEntity>
        where TEntity : BaseEntity
{
    int Add(TEntity entity);
    int Update(TEntity entity);
    int Remove(TEntity entity);
    TEntity? GetById(Guid id);
    IQueryable<TEntity> GetAll();
}
