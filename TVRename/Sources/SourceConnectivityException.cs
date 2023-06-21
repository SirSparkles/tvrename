//
// Main website for TVRename is http://tvrename.com
//
// Source code available at https://github.com/TV-Rename/tvrename
//
// Copyright (c) TV Rename. This code is released under GPLv3 https://github.com/TV-Rename/tvrename/blob/master/LICENSE.md
//
using System;

namespace TVRename;

public class SourceConnectivityException : Exception
{
    public Exception SourceException { get; }

    public SourceConnectivityException(string message, Exception e) : base(message)
    {
        SourceException = e;
    }

    public SourceConnectivityException(Exception ex) : this (ex.Message, ex)
    {
    }
}
