namespace maui_poc.Repository;

public interface IRepository<T> where T : class
{
    int Insert(T entity);
    void Insert(List<T> entities);
    Boolean Delete(T entity);
    List<T> GetAll();
    T Get(string id);
    
}