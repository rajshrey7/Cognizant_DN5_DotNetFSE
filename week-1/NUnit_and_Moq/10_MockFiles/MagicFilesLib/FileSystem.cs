using System.IO;

namespace MagicFilesLib
{
    public class FileSystem : IFileSystem
    {
        public string[] GetFiles(string path)
        {
            return Directory.GetFiles(path);
        }
    }
}