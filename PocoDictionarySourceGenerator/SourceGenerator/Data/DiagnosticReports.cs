using Microsoft.CodeAnalysis;

namespace Foxy.PocoDictionary.SourceGenerator.Data;

public class DiagnosticReports
{
    public const string Category = "Foxy.PocoDictionary";

    public static DiagnosticDescriptor InternalError { get; } = new(
        "PD1000",
        "Internal error",
        "Internal error occured during source generation: {0}",
        Category,
        DiagnosticSeverity.Warning,
        isEnabledByDefault: true);
}
