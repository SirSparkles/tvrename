//
// Main website for TVRename is http://tvrename.com
//
// Source code available at https://github.com/TV-Rename/tvrename
//
// Copyright (c) TV Rename. This code is released under GPLv3 https://github.com/TV-Rename/tvrename/blob/master/LICENSE.md
//

using System.Collections.Generic;

namespace TVRename;

// ReSharper disable once InconsistentNaming
internal class ShowsTXT : ShowsExporter
{
    public ShowsTXT(List<ShowConfiguration> shows) : base(shows)
    {
    }

    public override bool Active() => TVSettings.Instance.ExportShowsTXT;

    protected override string Location() => TVSettings.Instance.ExportShowsTXTTo;

    protected override void Do()
    {
        using (System.IO.StreamWriter file = new(Location()))
        {
            foreach (ShowConfiguration si in Shows)
            {
                file.WriteLine(si.ShowName);
            }
        }
    }

    protected override string Name() => "Show TXT Exporter";
}
