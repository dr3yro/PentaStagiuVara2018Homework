using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module02Week01
{
    public class WriteFile : FileManipulator
    {
        public override void fileManipulator(string person)
        {
            string name = person;

            using (StreamWriter writeFile = new StreamWriter("people.txt"))
            {
                    writeFile.WriteLine(name);
            }
        }
    }
}
