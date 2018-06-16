﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module02Week01
{
    public class WriteFile : FileManipulator
    {
        public override void fileManipulator(List<string> persons)
        {
            List<string> names = persons;

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
