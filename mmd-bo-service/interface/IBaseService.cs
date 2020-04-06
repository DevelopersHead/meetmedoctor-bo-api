using System.Collections.Generic;
public interface IBaseService<TEntity>{

    ICollection<TEntity> findAll();

}