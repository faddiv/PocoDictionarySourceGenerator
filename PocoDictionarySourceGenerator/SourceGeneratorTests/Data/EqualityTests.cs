using Foxy.PocoDictionary.SourceGenerator.Data;
using Xunit;

namespace SourceGeneratorTests.Data;

public class EqualityTests
{
    [Fact]
    public void Equals_WithSameObject_ShouldReturnTrue()
    {
        // Arrange
        var candidate = new SuccessfulCollectedData()
        {
            TypeInfo = new CandidateTypeInfo()
            {
                TypeName = "TestType",
                Namespace = "TestNamespace",
                InGlobalNamespace = false,
                TypeHierarchy = []
            }
        };

        // Act & Assert
        Assert.True(candidate.Equals(candidate));
    }
}
