using System.Collections.Generic;
using mmd.bo.domain.entity;

public class MenuItemService:BaseService<MenuItem>
{
    public MenuItemService(IBaseRepository<MenuItem> repo):base(repo){
        
    }
}