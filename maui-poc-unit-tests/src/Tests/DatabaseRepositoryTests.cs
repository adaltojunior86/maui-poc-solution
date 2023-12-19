
using maui_poc.Model;
using maui_poc.Repository;
using maui_poc_unit_tests.Mocks;

namespace maui_poc_unit_tests;

public class DatabaseRepositoryTests
{
    [Fact]
    public void ShouldGetAllItems()
    {
      var repo = DatabaseMock.GetMock();
      ResourceRepository resourceRepository = new();
      Assert.Collection<Resource>(resourceRepository.GetAll());
    }

}