using FluentAssertions;
using global::Core.Entities.Concrete;
using global::Core.Extensions;
using NUnit.Framework;
using Tests.Helpers;

namespace Tests.Core.Extensions
{
    [TestFixture]
    public class CloneExtensionServiceTests
    {
        [Test]
        public void CloneServiceExtensionTest()
        {
            var user = DataHelper.GetUser("murat");

            var cloneUser = user.Clone();

            cloneUser.Should().BeOfType<User>();
            cloneUser.FullName.Should().Be(user.FullName);
        }

    }
}
