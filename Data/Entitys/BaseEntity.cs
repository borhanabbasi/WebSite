namespace Data.Entitys.Base;

public class BaseEntity<TEntity>:IBaseEntity
{
    public TEntity Id { get; set; }
}
public class BaseEntity: BaseEntity<int>
{
    
}

public interface IBaseEntity 
{
    
}