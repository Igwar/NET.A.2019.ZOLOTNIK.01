using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using file;
namespace testfile
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting great = new Greeting();
            Farewell far = new Farewell();
            great.Hello();
            far.Goodbye();
        }
    }
}
