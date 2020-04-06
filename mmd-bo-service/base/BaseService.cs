using System.Collections.Generic;
using mmd.bo.domain.intf;

public abstract class BaseService<TEntity> : IBaseService<TEntity> 
where TEntity:class,IEntity
{
    private readonly IBaseRepository<TEntity> repository;

    public BaseService(IBaseRepository<TEntity> paramRepository)
    {
        this.repository = paramRepository;
    }

    public ICollection<TEntity> findAll(){
        return this.repository.findAll();
    }
}