namespace maui_poc.Repository;
using maui_poc.Model;
public class ResourceRepository : DatabaseRepository<Resource>
{
  public ResourceRepository()
  {
    Connection.CreateTable<Resource>();
  }
}
