using System.Collections.Generic;

public interface IBaseRepository<T>
{
    ICollection<T> findAll();
}