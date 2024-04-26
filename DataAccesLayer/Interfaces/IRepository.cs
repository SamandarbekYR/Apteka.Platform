using Domian.Entities;

namespace DataAccesLayer.Interfaces;

public interface IRepository<TEntity>
        where TEntity : BaseEntity
{
    bool Add(TEntity entity);
    bool Update(TEntity entity);
    bool Remove(TEntity entity);
    TEntity? GetById(Guid id);
    IQueryable<TEntity> GetAll();
}
