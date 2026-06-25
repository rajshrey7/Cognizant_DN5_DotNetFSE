using System.Linq;
using MagicFilesLib;

namespace MagicFilesLib
{
    public class DirectoryExplorer
    {
        private readonly IFileSystem fileSystem;

        public DirectoryExplorer(IFileSystem fileSystem)
        {
            this.fileSystem = fileSystem;
        }

        public int GetTotalFiles(string path)
        {
            return fileSystem.GetFiles(path).Count();
        }
    }
}