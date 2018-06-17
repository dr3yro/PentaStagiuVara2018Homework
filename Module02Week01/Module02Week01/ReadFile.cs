using System;
using System.IO;

namespace Module02Week01
{
    public class ReadFile
    {
        public delegate void FileReadEventHandler(object sender, EventArgs e);
        public event FileReadEventHandler FileRead;
        public delegate void FileDoesNotExistEventHandler(object sender, EventArgs e);
        public event FileDoesNotExistEventHandler FileDoesNotExist;

        protected virtual void OnFileRead()
        {
            if(FileRead != null)
            {
                FileRead(this, EventArgs.Empty);
            }
        }

        protected virtual void OnFileDoesNotExist()
        {
            if(FileDoesNotExist != null)
            {
                FileDoesNotExist(this, EventArgs.Empty);
            }
        }

        public void ReadFileStream()
        {
            try
            {
                using (StreamReader readFile = new StreamReader("people.txt"))
                {
                    string line;
                    int counter = 1;
                    OnFileRead();
                    while ((line = readFile.ReadLine()) != null)
                    {
                        Console.WriteLine(counter + ". " + line);
                        counter += 1;
                    }
                }
            }
            catch (Exception e)
            {
                FileManipulator createFile = new WriteFile();
                createFile.fileManipulator("Andrei Kovacs");
                FileManipulator appendFile = new AppendFile();
                appendFile.fileManipulator("Ionut Unguru");
                OnFileDoesNotExist();
                ReadFile readFile = new ReadFile();
                readFile.ReadFileStream();
            }
        }
    }
}