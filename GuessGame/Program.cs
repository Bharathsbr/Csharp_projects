using System;
namespace Guess_Game{
    class Game2{
        static void Main(string[] args)
        {
            bool isCorrect=false;
            int number;
            Random random=new Random();
            Console.WriteLine();
            Console.WriteLine("Welcome to the game!");
            Console.WriteLine("A number between 1 to 10 should be guessed");
            Console.WriteLine("Let's Start");
            number=random.Next(1,10);
            while(!isCorrect){
                Console.WriteLine("Enter your guess");
                int guess=Convert.ToInt32(Console.ReadLine());
                System.Threading.Thread.Sleep(1000);
                if(guess>number){
                    Console.WriteLine("Your guess is too high");
                }else if(guess<number){
                    Console.WriteLine("Your guess is too low");
                }else{
                    Console.WriteLine("Correct");
                    isCorrect=true;
                }
            }
            Console.WriteLine("Congratulations!");
            Console.ReadKey();

        }
    }
}