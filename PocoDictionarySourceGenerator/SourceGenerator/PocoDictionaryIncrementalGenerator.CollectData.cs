using System.Threading;
using Foxy.PocoDictionary.SourceGenerator.Data;
using Microsoft.CodeAnalysis;

namespace Foxy.PocoDictionary.SourceGenerator;

partial class PocoDictionaryIncrementalGenerator
{
    private CollectedData? CollectData(
        GeneratorAttributeSyntaxContext context,
        CancellationToken cancel)
    {
        return new SuccessfulCollectedData
        {
            TypeInfo = new CandidateTypeInfo()
            {
                InGlobalNamespace = false,
                Namespace = "Something",
                TypeName = "Foo",
                TypeHierarchy = [],
            }
        };
    }
}

