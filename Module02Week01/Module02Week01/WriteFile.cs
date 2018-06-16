using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module02Week01
{
    public static class WriteFile
    {
        public static void WriteFileStream(string firstUserName, string secondUserName)
        {
            string[] names = new string[] {firstUserName,secondUserName };

            using (StreamWriter writeFile = new StreamWriter("people.txt"))
            {
                foreach (string name in names)
                {
                    writeFile.WriteLine(name);
                }
            }
        }
    }
}
