using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module02Week01
{
    public static class AppendToFile
    {
        public static void AppendFileStream(string firstName, string secondName)
        {
            string[] names = new string[]{firstName,secondName};

            using (FileStream appendToFile = new FileStream("people.txt",FileMode.Append,FileAccess.ReadWrite))
            {
                foreach (string name in names)
                {
                    
                }
            }
        }
    }
}
