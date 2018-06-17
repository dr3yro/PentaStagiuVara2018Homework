using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module02Week01
{
    public class AppendFile : FileManipulator
    {

        public override void fileManipulator(string person)
        {
            string name = person;

            using (StreamWriter appendFile = File.AppendText("people.txt"))
            {
                    appendFile.WriteLine(name);
            }
        }
    }
}
