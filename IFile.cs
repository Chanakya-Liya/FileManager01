using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    interface IFile
    {
        void create();
        void delete();
        void update();
        void read();
    }
}
