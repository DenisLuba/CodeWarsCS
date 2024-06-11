using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars
{
    public class RemoveAnchorFromURL
    {
        //public static string RemoveUrlAnchor(string url) => new Regex(@"(?=.*)#.*").Replace(url, "");

        //public static string RemoveUrlAnchor(string url) => Regex.Match(url, @"[^#]+").Value;

        public static string RemoveUrlAnchor(string url) => url.Split("#")[0];
    }
}
