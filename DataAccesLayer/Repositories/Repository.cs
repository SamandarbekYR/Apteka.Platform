using DataAccesLayer.Data;
using DataAccesLayer.Interfaces;
using Domian.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DataAccesLayer.Repositories;

public class Repository<TEntity> : IRepository<TEntity> 
            where TEntity : BaseEntity
{
    private DbSet<TEntity> _dbSet;
    private AppDbContext _appDb;

    public Repository(AppDbContext appDb)
    {
        _dbSet = appDb.Set<TEntity>();
        _appDb = appDb;
    }
    public int Add(TEntity entity)
    {
        _dbSet.Add(entity);

        return _appDb.SaveChanges();
    }
  

    public int Remove(TEntity entity)
    {
        _dbSet.Remove(entity);

        return _appDb.SaveChanges();
    }

    public Task<List<TEntity>> GetAll()
    {
        return _dbSet.ToListAsync();
    }

    public TEntity? GetById(Guid id)
    {
        TEntity? entity = _dbSet.FirstOrDefault(x => x.Id == id);
        if (entity == null)
        {
          return null;
        }

        return entity;
    }

    public int Update(TEntity entity)
    {
        _dbSet.Update(entity);

        return _appDb.SaveChanges();
    }
}
