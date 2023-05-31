namespace CSharpLearn.WorkingWithFiles
{
    class DirectoryAndDirectoryInfo
    {
        static void Main(string[] args)
        {
            //Getting started with directories
            Directory.CreateDirectory(@"c:\temp\folder1");

            var files = Directory.GetFiles(@"C:\edb\languagepack\v2", "*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            Directory.Exists("");


            //Getting started with directories info
            var directoryInfo = new DirectoryInfo(@"...");
            directoryInfo.Delete();
            directoryInfo.GetDirectories();

        }
    }
}
