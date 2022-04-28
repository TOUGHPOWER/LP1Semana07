using System;

namespace ColorBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            Color color1 = new Color(50,100,200);
            Color color2 = new Color(50,55,100,150);
            Ball ball1 = new Ball(color1,15);
            Ball ball2 = new Ball(color2,5);
            ball1.Throw();
            ball1.Pop();
            ball1.Throw();
            ball2.Throw();
            ball2.Throw();
            ball2.Pop();

            Console.Write($"Ball 1 has {color1.GetRedValue()} of red |");
            Console.Write($"Ball 1 has {color1.GetGreenValue()} of green |");
            Console.WriteLine($"Ball 1 has {color1.GetBlueValue()} of blue |");
            Console.WriteLine($"Ball 1 has {color1.GetAlphaValue()} of transparency");
            Console.WriteLine($"Ball 1 has been thrown {ball1.GetNumberOfTimesThrown()} times");
            Console.Write($"Ball 2 has {color2.GetRedValue()} of red |");
            Console.Write($"Ball 2 has {color2.GetGreenValue()} of green |");
            Console.Write($"Ball 2 has {color2.GetBlueValue()} of blue |");
            Console.WriteLine($"Ball 2 has {color2.GetAlphaValue()} of transparency");
            Console.WriteLine($"Ball 2 has been thrown {ball2.GetNumberOfTimesThrown()} times");


        }
    }
}
