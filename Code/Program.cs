using System;
using Dy2018CrawlerForJson;
using Dy2018CrawlerForJson.Models;
using System.Collections.Generic;
using System.IO;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Directory.GetCurrentDirectory().ToString());
            Work _work = new Work();
            _work.Start();
            List<MovieInfo> lstMovie = HotMovieInfo.GetAllMovieInfo();
            foreach (var item in lstMovie)
            {
                Console.WriteLine(item.MovieName.ToString()); 
            }
            
        }
    }
}