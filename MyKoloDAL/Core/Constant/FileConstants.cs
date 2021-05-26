using System;
using System.IO;
namespace MyKoloDAL.Core.Constant
{
    public class FileConstants
    {
        public readonly static string DBFOLDER = (Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "MyKolo"));
    }
}