using System.Collections.Generic;

namespace MagicFilesLib
{
    public interface IFileSystem
    {
        string[] GetFiles(string path);
    }
}