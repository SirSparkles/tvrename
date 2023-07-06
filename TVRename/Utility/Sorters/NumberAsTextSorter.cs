//
// Main website for TVRename is http://tvrename.com
//
// Source code available at https://github.com/TV-Rename/tvrename
//
// Copyright (c) TV Rename. This code is released under GPLv3 https://github.com/TV-Rename/tvrename/blob/master/LICENSE.md
//

using System;
using System.Windows.Forms;

namespace TVRename;

public sealed class NumberAsTextSorter : ListViewItemSorter
{
    public NumberAsTextSorter(int column) : base(column)
    {
    }

    protected override int CompareListViewItem(ListViewItem x, ListViewItem y) => ParseAsInt(x) - ParseAsInt(y);

    private int ParseAsInt(ListViewItem cellItem)
    {
        string value = cellItem.SubItems[Col].Text;

        if (!value.HasValue())
        {
            return -1;
        }

        if (value == TVSettings.SpecialsListViewName)
        {
            return 0;
        }

        try
        {
            return Convert.ToInt32(value);
        }
        catch
        {
            return -1;
        }
    }
}
