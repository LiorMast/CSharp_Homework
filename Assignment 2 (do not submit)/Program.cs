using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2__do_not_submit_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataFile f1 = new DataFile("", "Hello World!");
            f1.PrintFileInfo();
            DataFile f2 = new DataFile(f1);
            f2.PrintFileInfo();

        }
    }
}
