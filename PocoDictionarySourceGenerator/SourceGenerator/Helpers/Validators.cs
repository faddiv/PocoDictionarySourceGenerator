using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Foxy.PocoDictionary.SourceGenerator.Helpers;

internal static class Validators
{
    public static bool HasError(INamedTypeSymbol typeSymbol)
    {
        return typeSymbol is IErrorTypeSymbol;
    }
}
