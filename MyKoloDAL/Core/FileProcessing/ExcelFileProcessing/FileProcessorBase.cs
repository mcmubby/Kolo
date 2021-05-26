using System.IO;
using MyKoloDAL.Core.Constant;

namespace MyKoloDAL.Core.FileProcessing.ExcelFileProcessing
{
    public class FileProcessorBase
    {
        protected string folderName = FileConstants.DBFOLDER;
        public FileProcessorBase()
        {
            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }
        }
    }
}