using System;
namespace Dice_Game
{
     class Game1{

        public static void Main(string[] args){
            
            int player,enemy;
            int pscore=0,escore=0;
            Random random=new Random();
            for(int i=0;i<10;i++){
            Console.WriteLine("Press any key to roll the dice");
            Console.WriteLine();
            Console.ReadKey();
            player=random.Next(1,7);
            Console.WriteLine("You rolled "+player);
            Console.WriteLine(".....");
            System.Threading.Thread.Sleep(1000);
            enemy=random.Next(1,7);
            Console.WriteLine("Enemy Ai rolled "+enemy);
            Console.WriteLine();
            if(player>enemy){
                pscore++;
                Console.WriteLine("You won this round");
            }else if(player<enemy){
                escore++;
                Console.WriteLine("Enemy wins this round");
            }else{
                Console.WriteLine("Draw!");
            }
            }
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("The scores are : Player {0} ; Enemy {1}",pscore,escore);
            System.Threading.Thread.Sleep(2000);
            if(pscore>escore){
                Console.WriteLine("You Won");
            }else if(pscore<escore){
                Console.WriteLine("Enemy Won");
            }else{
                Console.WriteLine("Draw!");
            }
            Console.ReadKey();
        } 
    }
}
