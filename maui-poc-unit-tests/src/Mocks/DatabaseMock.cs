namespace maui_poc_unit_tests.Mocks;
using Moq;
using maui_poc.Repository;
using maui_poc.Model;

internal static class DatabaseMock {
  public static Mock<ResourceRepository> GetMock() {
    var mock = new Mock<ResourceRepository>();
    mock.Setup(x => x.GetAll()).Returns(new List<Resource>());
    mock.Setup(x => x.Get(It.IsAny<string>())).Returns(new Resource());
    return mock;
  }
}