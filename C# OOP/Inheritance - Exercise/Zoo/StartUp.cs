using System;

namespace Zoo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Lizard lizard = new Lizard("Lizard1");
            Console.WriteLine(lizard.ToString());
            Snake snake = new Snake("Snake1");
            Console.WriteLine(snake.ToString());
            Gorilla gorilla = new Gorilla("Gorilla1");
            Console.WriteLine(gorilla.ToString());
            Bear bear = new Bear("Bear1");
            Console.WriteLine(bear.ToString());

        }
    }
}