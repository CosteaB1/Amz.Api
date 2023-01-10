using NetArchTest.Rules;

namespace Amz.Architecture.Tests
{
    [TestClass]
    public class ArchitectureTests
    {
        private const string DomainNamespace = "Amz.Domain";
        private const string ApplicationNamespace = "Amz.Application";
        private const string DataAccessNamespace = "Amz.DAL";
        private const string ApiNamespace = "Amz.Api";

        [TestMethod]
        public void Domain_Should_Not_HaveDependencyOnOtherProjects()
        {
            // Arrange 

            var assembly = typeof(Amz.Domain.Models.Category).Assembly;  // how to get Assembly just from Amz.Domain ???
            var otherProjects = new[] {
                ApplicationNamespace, DataAccessNamespace, ApiNamespace
            };
            // Act 

            var testResult = Types.InAssembly(assembly).ShouldNot().HaveDependencyOnAll(otherProjects).GetResult();

            // Assert

            Assert.IsTrue(testResult.IsSuccessful);
        }
    }
}