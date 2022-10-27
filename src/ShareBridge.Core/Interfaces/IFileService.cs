using ShareBridge.Domain.Models;

namespace ShareBridge.Core.Interfaces
{
    public interface IFileService
    {
        public FileHeaders GetFileInfo(string path);

        public string GetResoucePath();
    }
}