using System;
namespace TurnBased{
    class Game3{
        public static void Main(string[] args)
        {
            int phealth=40;
            int ehealth=20;
            int pattack=5;
            int eattack=8;
            int healthrestore=5;
            Random ran=new Random();
            Console.WriteLine("Welcome to the Game!");
            Console.WriteLine("<><><><><><><><><><><><><><><>");
            while((phealth>0 && ehealth>0)){
                Console.WriteLine("*********************");
                Console.WriteLine("Player's turn");
                Console.WriteLine("*********************");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Present health of Player :{0}  ;  Enemy :{1}",phealth,ehealth);
                a:
                Console.WriteLine("*********************");
                Console.WriteLine("Enter 'a' to attack or 'h' to restore health");
                string choice1=Console.ReadLine();
                System.Threading.Thread.Sleep(1000);
                if(choice1=="a"){
                    Console.WriteLine("*********************");
                    Console.WriteLine("Player chose to attack!");
                    ehealth-=pattack;
                    Console.WriteLine("Enemy's health is reduced to "+ehealth);
                    
                }else if(choice1=="h"){
                    Console.WriteLine("*********************");
                    Console.WriteLine("Player chose to restore health!");
                    phealth+=healthrestore;
                    Console.WriteLine("Player's health is restored to "+phealth);
                }else{
                    Console.WriteLine("Please enter a correct option");
                    goto a;
                }
                if(ehealth>0){
                Console.WriteLine("*********************");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Enemy's turn");
                Console.WriteLine("*********************");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Present health of Player :{0}  ;  Enemy :{1}",phealth,ehealth);
                b:
                Console.WriteLine("*********************");
                Console.WriteLine("Enter 0 to attack or 1 to restore health");
                int choice2=ran.Next(0,2);
                System.Threading.Thread.Sleep(1000);
                if(choice2==0){
                    Console.WriteLine("*********************");
                    Console.WriteLine("Enemy chose to attack!");
                    phealth-=eattack;
                    Console.WriteLine("Player's health is reduced to "+phealth);
                }else if(choice2==1){
                    Console.WriteLine("*********************");
                    Console.WriteLine("Enemy chose to restore health!");
                    ehealth+=healthrestore;
                    Console.WriteLine("Enemy's health is restored to "+ehealth);
                }else{
                    Console.WriteLine("Please enter a correct option");
                    goto b;
                }
                }
            }
            System.Threading.Thread.Sleep(3000);
            if(phealth<ehealth){
                Console.WriteLine("*********************");
                Console.WriteLine("Enemy Won");
            }else{
                Console.WriteLine("*********************");
                Console.WriteLine("Player Won");
            }
            Console.ReadKey();   
        }
    }
}