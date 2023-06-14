using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    internal class ImageFile : IImageFile
    {
        public void create()
        {
            Console.Write("Name if the image file: ");
            Console.ReadLine();
            //create image file
            Console.WriteLine("Image file created");
        }

        public void delete()
        {
            //delete image file
            Console.WriteLine("Image file deleted");
        }

        public void read()
        {
            //read the image file
            Console.WriteLine("Image file read");
        }

        public void resize()
        {
            Console.Write("height: ");
            Console.ReadLine();
            Console.Write("width: ");
            Console.ReadLine() ;
            //resize the image file
            Console.WriteLine("Image has been resized");
        }

        public void update()
        {
            //update the image file
            Console.WriteLine("Image file updated");
        }
    }
}
