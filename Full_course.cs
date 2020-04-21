using System.Text;

namespace test
{

    class Program
    {
        public static void Main()
        {
            var path = @"c:\\temp\\myfile.jpg";
            File.Copy("c:\\temp\\myfile.jpg","d:\\temp\\myfile.jpg", true); //true is for replace file 
            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }
            var contant = File.ReadAllText(path);
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete;


            Console.ReadLine();
        }
     
    }
}
