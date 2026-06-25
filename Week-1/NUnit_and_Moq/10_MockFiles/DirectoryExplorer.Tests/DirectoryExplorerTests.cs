using MagicFilesLib;
using Moq;
using NUnit.Framework;

namespace DirectoryExplorer.Tests
{
    [TestFixture]
    public class DirectoryExplorerTests
    {
        [Test]
        public void GetTotalFiles_ReturnsCorrectCount()
        {
            Mock<IFileSystem> mock = new Mock<IFileSystem>();

            mock.Setup(x => x.GetFiles(It.IsAny<string>()))
                .Returns(new string[]
                {
                    "A.txt",
                    "B.txt",
                    "C.txt"
                });

            MagicFilesLib.DirectoryExplorer explorer =
      new MagicFilesLib.DirectoryExplorer(mock.Object);

            int count = explorer.GetTotalFiles("C:\\");

            Assert.AreEqual(3, count);
        }
    }
}