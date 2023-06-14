using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    internal class PDFFile : IPDFFile
    {
        public void create()
        {
            Console.Write("Name of the file: ");
            Console.ReadLine();
            //create PDF file
            Console.WriteLine("PDF file created");
        }

        public void delete()
        {
            //delete pdf file
            Console.WriteLine("PDF file deleted");
        }

        public void process()
        {
            //process the pdf file
            Console.WriteLine("PDF file processed");
        }

        public void read()
        {
            //read the pdf file
            Console.WriteLine("PDF file read");
        }

        public void update()
        {
            //update the PDF file
            Console.WriteLine("PDF file has been updated");
        }
    }
}
