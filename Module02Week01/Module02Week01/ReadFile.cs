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
                    while ((line = readFile.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                WriteFile.WriteFileStream("Andrei Kovacs", "Ionut Unguru");
                WriteFile.WriteFileStream("Madalina Popa", "Luiza Chirazi");
                Console.WriteLine("File could not be located and was therefore created with dummy names!");
                ReadFile.ReadFileStream();
            }
        }
    }
}