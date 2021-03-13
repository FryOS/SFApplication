using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using static Task1.Program;

namespace SFApplication.Tests.Tests
{
    [TestFixture]
    class UserRepositoryTests
    {
        [Test]
        public void FindAllMustReturnCorrectValue()
        {
            var list = new List<User> {
              new User() { Name = "Антон" },
              new User() { Name = "Венера" },
              new User() { Name = "Коля" },
              new User() { Name = "Леша" },
            };
            Mock<IUserRepository> mock = new Mock<IUserRepository>();

            mock.Setup(v => v.FindAll()).Returns(list);

            Assert.That(mock.Object.FindAll().Any(user => user.Name == "Антон"));
            Assert.That(mock.Object.FindAll().Any(user => user.Name == "Иван"));
            Assert.That(mock.Object.FindAll().Any(user => user.Name == "Алексей"));
        }
    }
}
