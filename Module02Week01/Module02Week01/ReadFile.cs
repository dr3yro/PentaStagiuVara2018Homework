using System;
using System.IO;

namespace Module02Week01
{
    public static class ReadFile
    {
        public static void ReadFileStream()
        {
            try
            {
                using (StreamReader readFile = new StreamReader("people.txt"))
                {
                    string line;
                    int counter = 1;
                    while ((line = readFile.ReadLine()) != null)
                    {
                        Console.WriteLine(counter + ". " + line);
                        counter += 1;
                    }
                }
            }
            catch (Exception e)
            {
                FileManipulator createFile = new WriteFile(List<string>);
                createFile.fileManipulator.a;
                FileManipulator appendFile = new AppendFile();
                appendFile.fileManipulator("Madalina Popa", "Doris Ghergana");
                Console.WriteLine("File could not be located and was therefore created with dummy names!");
                ReadFile.ReadFileStream();
            }
        }
    }
}