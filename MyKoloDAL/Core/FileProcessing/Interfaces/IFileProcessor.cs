namespace MyKoloDAL.Core.FileProcessing.Interfaces
{
    public interface IFileProcessor
    {
        bool ReadToFile();
        bool WriteToFile();
    }
}