using System;
using System.Linq;
using System.Web;

namespace Clean.Core.Helpers
{
    public static class VideoUrlHelper
    {
        public static string GetVideoId(string youtubeUrl)
        {
            Uri uri;
            if (Uri.TryCreate(youtubeUrl, UriKind.Absolute, out uri))
            {
                if (uri.Host.Equals("www.youtube.com", StringComparison.OrdinalIgnoreCase)
                    || uri.Host.Equals("youtube.com", StringComparison.OrdinalIgnoreCase))
                {
                    var query = HttpUtility.ParseQueryString(uri.Query);
                    if (query.AllKeys.Contains("v"))
                    {
                        return query["v"];
                    }
                }
                else if (uri.Host.Equals("youtu.be", StringComparison.OrdinalIgnoreCase))
                {
                    return uri.Segments.LastOrDefault();
                }
            }

            return null; // If the URL is not a valid YouTube video URL or doesn't contain the video ID.
        }
    }
}
