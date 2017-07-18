using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            //Рамочки
            HorizontalLine lineUp = new HorizontalLine(0, 78, 0, '+');
            lineUp.Draw();
            HorizontalLine lineDown = new HorizontalLine(0, 78, 24, '+');
            lineDown.Draw();
            VerticalLine lineLeft = new VerticalLine(0, 24, 0, '+');
            lineLeft.Draw();
            VerticalLine lineRight = new VerticalLine(0, 24, 78, '+');
            lineRight.Draw();
            
            //Змійка
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            snake.Move();

            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
        }
    }
}
