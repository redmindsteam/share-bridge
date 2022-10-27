using ShareBridge.Core.Interfaces;
using ShareBridge.Domain.Models;

namespace ShareBridge.Core.Services
{
    public class FileService : IFileService
    {
        public FileHeaders GetFileInfo(string path)
        {
            try
            {
                FileHeaders fileHeaders = new FileHeaders();
                FileInfo fileInfo = new FileInfo(path);

                fileHeaders.FileName = fileInfo.Name;
                fileHeaders.Lenth = fileInfo.Length;
                fileHeaders.Extension = fileInfo.Extension;

                return fileHeaders;
            }

            catch
            {
                return new FileHeaders();
            }
            
        }
    }
}