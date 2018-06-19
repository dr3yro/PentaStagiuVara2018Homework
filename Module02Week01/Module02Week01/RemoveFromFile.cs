using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module02Week01
{
    class RemoveFromFile
    {
        public void removePersonAt(int index)
        {
            int _index = index;

            using (StreamReader readFile = new StreamReader("people.txt"))
            {
                string line;
                int counter = 1;
                while ((line = readFile.ReadLine()) != null)
                {
                    if (counter == _index)
                    {
                        using (StreamWriter writeFile = new StreamWriter("people.txt"))
                        {
                            writeFile.WriteLine("");
                        }
                    }
                    counter += 1;
                }
            }
        }
    }
}
