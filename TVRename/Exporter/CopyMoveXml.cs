//
// Main website for TVRename is http://tvrename.com
//
// Source code available at https://github.com/TV-Rename/tvrename
//
// Copyright (c) TV Rename. This code is released under GPLv3 https://github.com/TV-Rename/tvrename/blob/master/LICENSE.md
//

using JetBrains.Annotations;

namespace TVRename
{
    internal class CopyMoveXml : ActionListXml
    {
        public CopyMoveXml(ItemList theActionList) : base(theActionList)
        {
        }

        public override bool ApplicableFor(TVSettings.ScanType st) => true;

        protected override bool IsOutput(Item a) => a is ActionCopyMoveRename cmr && cmr.Operation != ActionCopyMoveRename.Op.rename && cmr.Episode != null;

        public override bool Active() => TVSettings.Instance.ExportFOXML;

        protected override string Location() => TVSettings.Instance.ExportFOXMLTo;

        [NotNull]
        protected override string MainXmlElementName() => "FindingAndOrganising";

        [NotNull]
        protected override string Name() => "CopyMove XML Exporter";
    }
}
