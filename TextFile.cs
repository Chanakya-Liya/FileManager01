using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    internal class TextFile : ITextFile
    {
        public void create()
        {            
            Console.Write("File name: ");
            Console.ReadLine();
            //create text file
            Console.WriteLine("Text file created");
        }

        public void delete()
        {
            //delete text file
            Console.WriteLine("Text file deleted");
        }

        public void edit()
        {
            Console.Write("edit: ");
            Console.ReadLine();
            //edit text file
            Console.WriteLine("Text file edited");
        }

        public void read()
        {
            //read text file
            Console.WriteLine("Text file read");
        }

        public void update()
        {
            //update text file
            Console.WriteLine("Text file updated");
        }
    }
}
