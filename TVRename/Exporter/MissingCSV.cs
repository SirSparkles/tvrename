using System;

namespace TVRename;

// ReSharper disable once InconsistentNaming
internal class MissingCSV : MissingActionListExporter
{
    public MissingCSV(ItemList theActionList) : base(theActionList)
    {
    }

    public override bool Active() => TVSettings.Instance.ExportMissingCSV;

    protected override string Location() => TVSettings.Instance.ExportMissingCSVTo;
    protected override string Name() => "Missing CSV Exporter";

    protected override void Do()
    {
        using (System.IO.StreamWriter file = new(Location()))
        {
            file.WriteLine("Show Name,Season,Episode,Episode Name,Air Date,Folder,Nice Name,thetvdb.com Code");

            foreach (ShowItemMissing? im in TheActionList.MissingEpisodes)
            {
                ProcessedEpisode pe = im.MissingEpisode;
                DateTime? dt = pe.GetAirDateDt(true);
                file.WriteLine(
                    $"\"{pe.TheCachedSeries.Name}\",{pe.AppropriateSeasonNumber},{pe.EpNumsAsString()},\"{pe.Name}\",{dt:G},\"{im.TargetFolder}\",\"{im.Filename}\",{pe.SeriesId}");
            }
        }
    }
}
