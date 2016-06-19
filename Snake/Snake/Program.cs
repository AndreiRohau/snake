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
            //ОТРИСОВКА РАМОЧКИ
            HorizontalLine upLine = new HorizontalLine(0, Console.BufferWidth - 1, 0, 'X');
            HorizontalLine downLine = new HorizontalLine(0, Console.BufferWidth - 1, 28, 'X');
            VerticalLine leftLine = new VerticalLine(0, 28, 0, 'X');
            VerticalLine rightLine = new VerticalLine(0, 28, Console.BufferWidth - 1, 'X');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();


            //Отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake( p, 4, Direction.RIGHT);


            Console.ReadLine();
        }
    }
}
