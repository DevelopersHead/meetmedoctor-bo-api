using System.Collections.Generic;
using System.Linq;
using mmd.bo.domain.intf;

public abstract class BaseRepository<TEntity>:IBaseRepository<TEntity>
where TEntity:class,IEntity {
    private readonly MmdBoDbContext dbContext;

    public BaseRepository(MmdBoDbContext paramDbContext)
    {
        this.dbContext = paramDbContext;
    }

    public ICollection<TEntity> findAll()
    {
        return this.dbContext.Set<TEntity>().ToList();
    }
}