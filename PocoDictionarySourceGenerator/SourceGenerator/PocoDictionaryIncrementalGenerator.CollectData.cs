using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using Foxy.PocoDictionary.SourceGenerator.Data;
using Foxy.PocoDictionary.SourceGenerator.Helpers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Foxy.PocoDictionary.SourceGenerator;

partial class PocoDictionaryIncrementalGenerator
{
    private static CollectedData? CollectData(
        GeneratorAttributeSyntaxContext context,
        CancellationToken cancel)
    {
        if (context.TargetNode is not TypeDeclarationSyntax ||
            context.TargetSymbol is not INamedTypeSymbol typeSymbol)
        {
            return null;
        }

        if (Validators.HasError(typeSymbol))
        {
            return null;
        }

        var properties = typeSymbol.GetMembers()
            .OfType<IPropertySymbol>()
            .Where(PropertyFilter)
            .Select(property => new CandidatePropertyInfo(property.Name))
            .ToArray();

        var containingNamespace =
            typeSymbol.ContainingNamespace.IsGlobalNamespace
                ? null
                : typeSymbol.ContainingNamespace.ToDisplayString(DisplayFormats.ForFileName);
        return new SuccessfulCollectedData(
            new CandidateTypeInfo(
                TypeName: typeSymbol.Name,
                Namespace: containingNamespace,
                [],
                properties,
                SemanticHelpers.GetTypeKind(typeSymbol)));
        
        bool PropertyFilter(IPropertySymbol property)
        {
            return property is { IsStatic: false, IsIndexer: false } &&
                   (!typeSymbol.IsRecord || property.Name != "EqualityContract");
        }
    }
}
