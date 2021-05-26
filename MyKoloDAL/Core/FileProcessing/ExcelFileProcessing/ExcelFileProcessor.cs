using System.IO;
using IronXL;
using MyKoloDAL.Core.FileProcessing.Interfaces;

namespace MyKoloDAL.Core.FileProcessing.ExcelFileProcessing
{
    public class ExcelFileProcessor : FileProcessorBase, IFileProcessor
    {
        private WorkBook dbFile;
        private string dbFileName = "MyKoloDb.xls";
        public ExcelFileProcessor() : base()
        {
           if (!File.Exists(Path.Combine(folderName, dbFileName)))
           {

                //Create new Excel WorkBook document. 
                //The default file format is XLSX, but we can override that for legacy support
                WorkBook xlsWorkbook = WorkBook.Create(ExcelFileFormat.XLS);
                xlsWorkbook.Metadata.Author = "SBSC";
                //Add a blank WorkSheet
                WorkSheet xlsSheet = xlsWorkbook.CreateWorkSheet("new_sheet");
                //Add data and styles to the new worksheet
                xlsSheet["A1"].Value = "Hello World";
                xlsSheet["A2"].Style.BottomBorder.SetColor("#ff6600");
                xlsSheet["A2"].Style.BottomBorder.Type = IronXL.Styles.BorderType.Double;
                //Save the excel file
                xlsWorkbook.SaveAs("NewExcelFile.xls");

           }

        }
        public bool ReadToFile()
        {
            throw new System.NotImplementedException();
        }

        public bool WriteToFile()
        {
            throw new System.NotImplementedException();
        }
    }
}