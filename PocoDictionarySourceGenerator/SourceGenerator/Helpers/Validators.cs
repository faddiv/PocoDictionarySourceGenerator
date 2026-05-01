using Microsoft.CodeAnalysis;

namespace Foxy.PocoDictionary.SourceGenerator.Helpers;

internal static class Validators
{
    public static bool HasError(INamedTypeSymbol typeSymbol)
    {
        return typeSymbol is IErrorTypeSymbol;
    }
}
