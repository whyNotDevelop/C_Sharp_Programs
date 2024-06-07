namespace WritingAndReadingFromTextfile
{
    using System.IO;
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Student\\Desktop\\my_project\\Encapsulation.txt";
            if(File.Exists(path))
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine("______________//____________________");
                    writer.WriteLine("True or False");
                    writer.WriteLine("_________________//____________________");
                }
                using (StreamReader sr = new StreamReader(path)) 
                {
                    string content = sr.ReadToEnd();
                    Console.WriteLine(content);
                }
            }
            else
            {
                Console.WriteLine("File(s) do not exist");
            }


        }
    }
}