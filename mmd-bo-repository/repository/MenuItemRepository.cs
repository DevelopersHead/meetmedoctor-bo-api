using System.Linq;
using mmd.bo.domain.entity;

public class MenuItemRepository : BaseRepository<MenuItem>
{
    public MenuItemRepository(MmdBoDbContext dbContext):base(dbContext){
        
    }
    
}