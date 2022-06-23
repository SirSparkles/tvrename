//
// Main website for TVRename is http://tvrename.com
//
// Source code available at https://github.com/TV-Rename/tvrename
//
// Copyright (c) TV Rename. This code is released under GPLv3 https://github.com/TV-Rename/tvrename/blob/master/LICENSE.md
//

using System;

namespace TVRename;

public class MediaNotFoundException : Exception
{
    public readonly ISeriesSpecifier Media;
    public readonly TVDoc.ProviderType ShowIdProvider;
    public readonly TVDoc.ProviderType ErrorProvider;
    public readonly MediaConfiguration.MediaType SourceType;

    public MediaNotFoundException(ISeriesSpecifier mc, string message, TVDoc.ProviderType showIdProvider, TVDoc.ProviderType errorProvider, MediaConfiguration.MediaType sourceType) : base(message)
    {
        Media = mc;
        ShowIdProvider = showIdProvider;
        ErrorProvider = errorProvider;
        SourceType = sourceType;
    }
}
