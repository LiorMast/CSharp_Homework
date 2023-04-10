using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class DataFile
    {
        // Define private fields of the class.
        private string fileName;
        private DateTime lastUpdateTime;
        private string data;

        /////////////////////CONSTRUCTORS/////////////////////

        // Define constructors for the class.
        // The first constructor takes two parameters: filename and data, and sets the file name, data, and last update time of the file.
        public DataFile(string filename, string data)
        {
            SetData(data);
            SetFileName(filename);
            SetTime();
        }

        public DataFile() : this("newfile", "") { }  // The second constructor creates a new file with default values.

        public DataFile(DataFile origin) : this(origin.fileName + " - Copy", origin.data) { } // The third constructor creates a copy of an existing file with a modified file name.

        /////////////////////GETTERS-SETTERS/////////////////////

        // Define getters and setters for the private fields of the class.
        // The GetData method returns the data of the file.
        public string GetData() => this.data;

        // The SetData method sets the data of the file and updates the last update time.
        public void SetData(string data)
        {
            this.data = data;
            SetTime();
        }

        // The GetFileName method returns the file name of the file.
        public string GetFileName() => this.fileName;

        // The IsValidName method checks if a file name is valid (i.e., it is not empty and does not contain any invalid characters).
        private bool IsValidName(string name)
        {
            char[] invalid = { '\\', '/', ':', '*', '?', '<', '>', '|', '"' };

            foreach (char x in invalid)
            {
                if (name.Contains(x) || name == "") return false;
            }
            return true;

        }

        // The SetFileName method sets the file name of the file.
        // It prompts the user to enter a valid file name if the provided name is not valid.
        public void SetFileName(string name = "")
        {
            while (!IsValidName(name))
            {
                Console.Write("a file name can't be empty or contain any of the following characters: \\/:*?\"<>|\nPlease Enter a file name: ");
                name = Console.ReadLine();
            }
            this.fileName = name;
            SetTime();

        }

        // The SetTime method sets the last update time of the file to the current time.
        public void SetTime() => lastUpdateTime = DateTime.Now;

        public DateTime GetTime() => lastUpdateTime; // The GetTime method returns the last update time of the file.

        private int GetSize() => this.data.Length; // The GetSize method returns the size of the file in bytes.

        /////////////////////METHODS/////////////////////

        private double SizeInKB() => this.GetSize() / 1024.0; // The SizeInKB method returns the size of the file in kilobytes.

        public void Dir() // The Dir method displays information about the file in the console.
        {
            Console.WriteLine($"{this.GetTime()} {Math.Round(this.SizeInKB(), 2)} KB {this.GetFileName()}");
        }
    }
}
