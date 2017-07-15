using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            HorizontalLine lineH = new HorizontalLine(1, 10, 1, '*');
            lineH.Draw();

            VerticalLine lineV = new VerticalLine(1, 10, 1, '*');
            lineV.Draw();
            Console.ReadKey();
        }
    }
}
