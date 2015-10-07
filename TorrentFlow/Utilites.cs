using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TorrentFlow
{  
    public static class Utilites
    {
        private const string unixFileListRegex = 
            @"^" +                          //# Start of line
            @"(?<dir>[\-ld])" +             //# File size          
            @"(?<permission>[\-rwx]{9})" +  //# Whitespace          \n
            @"\s+" +                        //# Whitespace          \n
            @"(?<filecode>\d+)" +
            @"\s+" +                        //# Whitespace          \n
            @"(?<owner>\w+)" +
            @"\s+" +                        //# Whitespace          \n
            @"(?<group>\w+)" +
            @"\s+" +                        //# Whitespace          \n
            @"(?<size>\d+)" +
            @"\s+" +                        //# Whitespace          \n
            @"(?<month>\w{3})" +            //# Month (3 letters)   \n
            @"\s+" +                        //# Whitespace          \n
            @"(?<day>\d{1,2})" +            //# Day (1 or 2 digits) \n
            @"\s+" +                        //# Whitespace          \n
            @"(?<timeyear>[\d:]{4,5})" +    //# Time or year        \n
            @"\s+" +                        //# Whitespace          \n
            @"(?<filename>(.*))" +          //# Filename            \n
            @"$";                           //# End of line
        public static bool IsNullOrEmpty(string s){
            return (s == null || s == "");
        }

        public static GetFileNameFromUnixFormatResponse GetFileNameFromUnixFormat(string unixFormattedFilename)
        {
            var split = new Regex(unixFileListRegex).Match(unixFormattedFilename);
            string dir = split.Groups["dir"].ToString();
            string filename = split.Groups["filename"].ToString();
            bool isDirectory = !string.IsNullOrWhiteSpace(dir) && dir.Equals("d", StringComparison.OrdinalIgnoreCase);

            return new GetFileNameFromUnixFormatResponse{
                filename = filename,
                isDirectory = isDirectory
            };
        }
    }

    public class GetFileNameFromUnixFormatResponse
    {
        public string filename { get; set; }
        public bool isDirectory { get; set; }
    }
}
