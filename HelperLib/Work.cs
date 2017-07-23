using System;
using System.Collections.Generic;
using System.Text;

namespace Dy2018CrawlerForJson
{
    public class Work
    {
        public void Start()
        {
            LogHelper.Info("Start crawling");
            LatestMovieInfo.CrawlLatestMovieInfo(100);
            HotMovieInfo.CrawlHotMovie();
            Btdytt520HotClickHelper.CrawlHotClickMovieInfo();
            LogHelper.Info("Finish crawling");
        }
    }
}
