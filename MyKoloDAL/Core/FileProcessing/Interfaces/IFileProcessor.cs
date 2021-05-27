namespace MyKoloDAL.Core.FileProcessing.Interfaces
{
    public interface IFileProcessor
    {
        bool ReadFromFile();
        bool WriteToFile();
    }
}