using SQLite;

namespace maui_poc.Repository;

public abstract class DatabaseRepository<T> : IRepository<T> where T : class, new()
{
  protected SQLiteConnection _connection;
  protected SQLiteConnection Connection => _connection ??= new SQLiteConnection(
    Path.Combine(FileSystem.AppDataDirectory, "database.db3"
  ), SQLiteOpenFlags.Create | SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.SharedCache);

  public Boolean Delete(T entity)
  {
    throw new NotImplementedException();
  }

  public virtual T Get(string id)
  {
    throw new NotImplementedException();
  }

  public virtual List<T> GetAll()
  {
    return Connection.Table<T>().ToList();
  }

  public int Insert (T entity)
  { 
    return Connection.Insert(entity);
  }
  
  public void Insert (List<T> entities)
  {
    try
    {
      foreach (var entity in entities)
      {
        Insert(entity);
      }
    }
    catch (Exception e)
    {
      Console.WriteLine(e);
      throw;
    }

  }
}