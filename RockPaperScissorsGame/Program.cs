using System;
namespace RockPaperScissors{
    class Game4{
        public static void Main(string[] args)
        {
            int pscore=0;
            int escore=0;
            int highscore=3;
            Random random=new Random();
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            Console.WriteLine("-----------------------");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Press any key to start");
            Console.ReadKey();
            while(pscore!=highscore && escore!=highscore){ 
               Console.WriteLine("-----------------------");
               System.Threading.Thread.Sleep(2000);
               Console.WriteLine("Player score  :  {0}   ;  Enemy score  :  {1}  ",pscore,escore);  
               Console.WriteLine("-----------------------");
               System.Threading.Thread.Sleep(1000);
               Console.WriteLine("Press 'R' for rock or 'P' for paper or 'any key' for scissors.");
               Console.WriteLine("-----------------------");
               char pchoice=Console.ReadLine()[0];
               System.Threading.Thread.Sleep(1000);
               int echoice=random.Next(0,3);
               if(echoice==0){
                switch(pchoice){
                    case 'R':
                    Console.WriteLine("You played 'Rock'.");
                    pscore+=0;
                    escore+=0;
                    break;
                    case 'P':
                    Console.WriteLine("You played 'Paper'.");
                    pscore+=1;
                    break;
                    default:
                    Console.WriteLine("You palyed 'Scissors'.");
                    escore+=1;
                    break;
                    }
                    Console.WriteLine("-----------------------");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Enemy palyed 'Rock'.");
                }else if(echoice==1){
                    switch(pchoice){
                    case 'R':
                    Console.WriteLine("You played 'Rock'.");
                    escore+=1;
                    break;
                    case 'P':
                    Console.WriteLine("You played 'Paper'.");
                    pscore+=0;
                    escore+=0;
                    break;
                    default:
                    Console.WriteLine("You palyed 'Scissors'.");
                    pscore+=1;
                    break;
                    }
                    Console.WriteLine("-----------------------");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Enemy palyed 'Paper'.");
                }else{
                    switch(pchoice){
                    case 'R':
                    Console.WriteLine("You played 'Rock'.");
                    pscore+=1;
                    break;
                    case 'P':
                    Console.WriteLine("You played 'Paper'.");
                    escore+=1;
                    break;
                    default:
                    Console.WriteLine("You palyed 'Scissors'.");
                    pscore+=0;
                    escore+=0;
                    break;
                    }
                    Console.WriteLine("-----------------------");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Enemy palyed 'Scissors'.");
               }
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine("Player score  :  {0}   ;  Enemy score  :  {1}  ",pscore,escore); 
            Console.WriteLine("-----------------------");
            System.Threading.Thread.Sleep(3000);
            if(pscore==highscore){
                Console.WriteLine("Player Won");
            }else{
                Console.WriteLine("Enemy Won");   
            }
            Console.ReadKey();
            
        }
    }
}