//
// Main website for TVRename is http://tvrename.com
//
// Source code available at https://github.com/TV-Rename/tvrename
//
// Copyright (c) TV Rename. This code is released under GPLv3 https://github.com/TV-Rename/tvrename/blob/master/LICENSE.md
//

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace TVRename
{
    using Alphaleonis.Win32.Filesystem;
    using System;

    public class ActionDownloadSeasonImage : ActionDownloadImage
    {
        private readonly int seasonNumber;
        public ActionDownloadSeasonImage(ShowConfiguration si, int snum, FileInfo dest, string path)
            : this(si, snum, dest, path, false)
        {
        }

        public ActionDownloadSeasonImage(ShowConfiguration si, int snum, FileInfo dest, string path, bool shrink)
            : base(si, null, dest, path, shrink)
        {
            seasonNumber = snum;
        }

        public override string SeasonNumber => seasonNumber != 0 ? seasonNumber.ToString() : TVSettings.SpecialsListViewName;
        public override int? SeasonNumberAsInt => seasonNumber;
        public override ShowConfiguration Series => Si as ShowConfiguration;
    }
    public class ActionDownloadTvShowImage : ActionDownloadImage
    {
        public ActionDownloadTvShowImage(ShowConfiguration si,FileInfo dest, string path)
            : this(si,  dest, path, false)
        {
        }

        public ActionDownloadTvShowImage(ShowConfiguration si, FileInfo dest, string path, bool shrink)
            : base(si, null, dest, path, shrink)
        {
        }
        public override ShowConfiguration Series => Si as ShowConfiguration;
    }
    public class ActionDownloadMovieImage : ActionDownloadImage
    {
        public ActionDownloadMovieImage(MovieConfiguration si, FileInfo dest, string path)
            : this(si, dest, path, false)
        {
        }

        public ActionDownloadMovieImage(MovieConfiguration si, FileInfo dest, string path, bool shrink)
            : base(si, null, dest, path, shrink)
        {
        }
    }

    public class ActionDownloadImage : ActionDownload
    {
        private readonly string path;
        private readonly FileInfo destination;
        protected readonly MediaConfiguration Si;
        private readonly bool shrinkLargeMede8ErImage;

        public ActionDownloadImage(MediaConfiguration si, ProcessedEpisode? pe, FileInfo dest, string path) : this(si, pe, dest, path, false)
        {
        }

        public ActionDownloadImage(MediaConfiguration si, ProcessedEpisode? pe, FileInfo dest, string path, bool shrink)
        {
            Episode = pe;
            this.Si = si;
            destination = dest;
            this.path = path;
            shrinkLargeMede8ErImage = shrink;

            if (si is MovieConfiguration m)
            {
                Movie = m;
            }
        }

        #region Action Members

        public override string Name => "Download";

        public override string ProgressText => destination.Name;

        public override string Produces => destination.FullName;

        // 0 to 100
        public override long SizeOfWork => 1000000;

        // http://www.codeproject.com/Articles/2941/Resizing-a-Photographic-image-with-GDI-for-NET
        private static Image MaxSize(Image imgPhoto, int width, int height)
        {
            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;

            float nPercentW = width / (float)sourceWidth;
            float nPercentH = height / (float)sourceHeight;

            int destWidth, destHeight;

            if (nPercentH < nPercentW)
            {
                destHeight = height;
                destWidth = (int)(sourceWidth * nPercentH);
            }
            else
            {
                destHeight = (int)(sourceHeight * nPercentW);
                destWidth = width;
            }

            Bitmap bmPhoto = new(destWidth, destHeight, PixelFormat.Format24bppRgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.Clear(Color.Black);
            grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;

            grPhoto.DrawImage(imgPhoto,
                new Rectangle(0, 0, destWidth, destHeight),
                new Rectangle(0, 0, sourceWidth, sourceHeight),
                GraphicsUnit.Pixel);

            grPhoto.Dispose();
            return bmPhoto;
        }

        public override ActionOutcome Go(TVRenameStats stats)
        {
            try
            {
                byte[]? theData = Si.Provider == TVDoc.ProviderType.TheTVDB
                    ? TheTVDB.LocalCache.Instance.GetTvdbDownload(path)
                    : HttpHelper.Download(path, false);

                if (theData is null || theData.Length == 0)
                {
                    return new ActionOutcome("Unable to download " + path);
                }

                if (shrinkLargeMede8ErImage)
                {
                    theData = ConvertBytes(theData);
                }

                System.IO.FileStream fs = new(destination.FullName, System.IO.FileMode.Create);
                fs.Write(theData, 0, theData.Length);
                fs.Close();
            }
            catch (Exception e)
            {
                return new ActionOutcome(e);
            }

            return ActionOutcome.Success();
        }

        private byte[] ConvertBytes(byte[] theData)
        {
            try
            {
                // shrink images down to a maximum size of 156x232
                Image im = new Bitmap(new System.IO.MemoryStream(theData));
                if (Episode is null)
                {
                    if (im.Width > 156 || im.Height > 232)
                    {
                        im = MaxSize(im, 156, 232);

                        using (System.IO.MemoryStream m = new())
                        {
                            im.Save(m, ImageFormat.Jpeg);
                            theData = m.ToArray();
                        }
                    }
                }
                else
                {
                    if (im.Width > 232 || im.Height > 156)
                    {
                        im = MaxSize(im, 232, 156);

                        using (System.IO.MemoryStream m = new())
                        {
                            im.Save(m, ImageFormat.Jpeg);
                            theData = m.ToArray();
                        }
                    }
                }
            }
            catch (ArgumentException)
            {
            }

            return theData;
        }

        #endregion Action Members

        #region Item Members

        public override bool SameAs(Item o) => o is ActionDownloadImage image && image.destination == destination;

        public override int CompareTo(Item o) => o is not ActionDownloadImage dl ? -1 : string.Compare(destination.FullName, dl.destination.FullName, StringComparison.Ordinal);

        public override int IconNumber => 5;
        public override IgnoreItem? Ignore => GenerateIgnore(destination.FullName);
        public override string SeriesName => Episode != null ? Episode.Show.ShowName : Si.ShowName;
        public override string DestinationFolder => TargetFolder;
        public override string DestinationFile => destination.Name;
        public override string SourceDetails => path;
        public override string ScanListViewGroup => "lvgActionDownload";
        public override string TargetFolder => destination.DirectoryName;

        #endregion Item Members
    }
}
