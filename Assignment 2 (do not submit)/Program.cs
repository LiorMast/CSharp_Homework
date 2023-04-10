using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataFile f1 = new DataFile();
            DataFile f2 = new DataFile("test.txt", "Hello World!");
            
            f1.Dir();
            f2.Dir();

            f1.SetFileName("Myfile.txt");
            f1.SetData("This is a text file");
            f1.SetTime();

            f1.Dir();
        }
    }
}
