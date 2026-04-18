using System.Threading.Tasks;
using Foxy.PocoDictionary.SourceGenerator;
using Foxy.PocoDictionary.SourceGenerator.Data;
using Xunit;
using SourceGeneratorTests.TestInfrastructure;
using Microsoft.CodeAnalysis;
using SourceGeneratorTests.TestInfrastructure.Verifiers;

namespace SourceGeneratorTests.IntegrationTests;

using VerifyCS = CSharpSourceGeneratorVerifier<PocoDictionaryIncrementalGenerator>;

public class ErrorReportingTests(TestEnvironment testEnvironment)
{
    [Fact]
    public async Task Reports_On___()
    {
        var code = testEnvironment.GetInvalidSource();

        var expected = VerifyCS
            .Diagnostic(DiagnosticReports.InternalError)
            .WithLocation(0)
            .WithArguments();

        await VerifyCS.VerifyGeneratorAsync(code, expected, testEnvironment.DefaultOutput);
    }
}
