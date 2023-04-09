﻿using System;
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

        /////////////////////CONSTRUCTORS/////////////////////

        public DataFile(string filename, string data)
        {
            SetData(data);
            SetFileName(filename);
            SetTime();
        }

        public DataFile() : this("newfile","") { }

        public DataFile(DataFile origin) : this(origin.fileName + " - Copy", origin.data) { }

        /////////////////////GETTERS-SETTERS/////////////////////
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
                if (name.Contains(x) || name == "") return false;
            }
            return true;

        }

        public void SetFileName(string name="")
        {
            while (!IsValidName(name))
            {
                Console.Write("a file name can't be empty or contain any of the following characters: \\/:*?\"<>|\nPlease Enter a file name: ");
                name = Console.ReadLine();
            }
                this.fileName = name;
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

        private int GetSize()
        {
            return this.GetData().Length;
        }

        /////////////////////METHODS/////////////////////

        public void PrintFileInfo()
        {
            Console.WriteLine(this.GetFileName());
            Console.WriteLine(this.GetData());
            Console.WriteLine(this.GetTime());
            Console.WriteLine(this.GetSize());
        }
    }
}