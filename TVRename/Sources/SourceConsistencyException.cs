using System;

namespace TVRename;

[Serializable]
// ReSharper disable once InconsistentNaming
public class SourceConsistencyException : Exception
{
    // Thrown if an error occurs in the XML when reading TheTVDB.xml
    public SourceConsistencyException(string message, TVDoc.ProviderType provider)
        : base(provider.PrettyPrint() + ": " + message)
    {
    }

    public SourceConsistencyException(string message, TVDoc.ProviderType provider, Exception ex)
        : base(provider.PrettyPrint() + ": " + message,ex)
    {
    }
}
