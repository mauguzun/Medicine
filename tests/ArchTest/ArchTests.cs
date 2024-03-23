using NetArchTest.Rules;

namespace ArchTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Entity_ShouldNotHaveRefernce_ToOtherProjects()
        {
            var assembly = typeof(Medicine.Entities.Models.Base.Entity).Assembly;

            var otherProjects =
                new[] { "Medicine.Application" };

            var result = Types.InAssembly(assembly)
                  .ShouldNot()
                  .HaveDependencyOnAll(
                    otherProjects
                  )
                  .GetResult();

            Assert.True(result.IsSuccessful);
        }
    }
}