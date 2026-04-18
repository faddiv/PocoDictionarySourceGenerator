using System;

namespace Foxy.PocoDictionary.SourceGenerator.Data;

internal class SuccessfulCollectedData : CollectedData, IEquatable<SuccessfulCollectedData?>
{
    public override bool HasErrors => false;

    public required CandidateTypeInfo TypeInfo { get; init; }

    public bool Equals(SuccessfulCollectedData? other)
    {
        return false;
    }
}

