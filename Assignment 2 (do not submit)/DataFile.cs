using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2__do_not_submit_
{
    internal class DataFile
    {
        private string fileName;
        private DateTime lastUpdateTime;
        private string data;



        public string GetData()
        {
            return this.data;
        }

        public void SetData(string data)
        {
            this.data = data;
        }

        public string GetFileName()
        {
            return this.fileName;
        }

        private bool IsValidName(string name)
        {
            char[] invalid = { '\\', '/', ':', '*', '?', '<', '>', '|', '"' };

            foreach (char x in invalid)
            {
                if (name.Contains(x)) return false;
            }
            return true;

        }

        public void SetFileName()
        {
            string name;
            Console.Write("Please Enter a file name: ");
            name = Console.ReadLine();
            while (!IsValidName(name))
            {
                Console.WriteLine("a file name can't contain any of the following characters: \\/:*?\"<>|");
                name = Console.ReadLine();
            }

        }

        public void SetTime()
        {
            // current date/time based on current system
            lastUpdateTime = DateTime.Now;
        }
        public DateTime GetTime()
        {
            return lastUpdateTime;
        }
    }
}
