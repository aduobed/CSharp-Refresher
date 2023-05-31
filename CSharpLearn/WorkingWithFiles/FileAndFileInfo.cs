using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn.WorkingWithFiles
{
    class FileAndFileInfo
    {
        static void Main(string[] args)
        {
            //Getting started with Files. These are static class which does checks once invoked

            var path = @"c:\somefile.txt";

            File.Copy(@"c:\sourceFile.txt", @"c:\destinationFile.txt");
            File.Delete(path);
            if (File.Exists(path))
            {
                // do something here
            }

            var getFIleContent = File.ReadAllText(path);
            

            //Getting started with FileInfo
            //Ceate an instance once and reuse all methods with no checks
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("someDestinationPath");
            fileInfo.Delete();

            if (fileInfo.Exists)
            {
                //do something here
            }
            
        }
    }
}