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
                this.dbFile = WorkBook.Create(ExcelFileFormat.XLS);
                dbFile.Metadata.Author = "SBSC";

                //Add a blank WorkSheet
                WorkSheet savingsTable = dbFile.CreateWorkSheet("Saving");
                WorkSheet expenseTable = dbFile.CreateWorkSheet("Expense");

                //Add data and styles to the new worksheet
                savingsTable["A1"].Value = "Id";
                savingsTable["B1"].Value = "CreatedAt";
                savingsTable["C1"].Value = "Amount";
                savingsTable["D1"].Value = "Description";

                expenseTable["A1"].Value = "Id";
                expenseTable["B1"].Value = "CreatedAt";
                expenseTable["C1"].Value = "Amount";
                expenseTable["D1"].Value = "Description";
                

                //Save the excel file
                dbFile.SaveAs(Path.Combine(folderName, dbFileName));

           }

        }
        public bool ReadFromFile()
        {
            throw new System.NotImplementedException();
        }

        public bool WriteToFile()
        {
            throw new System.NotImplementedException();
        }
    }
}