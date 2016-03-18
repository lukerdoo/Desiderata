using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luke_sAdventure
{
    class Program
    {
        
        static int Virtue = 100;
        static int Power = 100;
        static int Health = 100;
        static int Martial = 100;
        static int Mind = 100;
        static int Coin = 0;
        static int Fiatus = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("A man approches you upon the road. He is haggerd and old. His skin glistens in a cold sweat and the moon shines like mercury in the reflection of his eyes.  ");
            Console.WriteLine("The lines run deep in his face and the hair upon his head hints at wisdom untold, or is it the stresses of madness that has taken their color and left them bleached in silver? I wonder if I should talk with the man... Choice A) Excuse me sir, but might I bare your load for a mile? Choice B) Give me all you have! I know that look in one's eye and I trust not your perplexion for it speaks of inner maddness untold! *you raise your fists*")
            Console.WriteLine("Type A or B:");

            string userResponse;
            do
            {
                 userResponse = Console.ReadLine();


            } while (userResponse != "A" || userResponse != "B");




            //if statement to check if its a proper response

            switch (userResponse)
            {
                case "":

                    break;
                case "":

                    break;
                case "":
                    Console.WriteLine("you were stabbed");
                    string  virtue  = Console.ReadLine();

                    if(BattleResult(10,20) == true)
                    {

                    }
                    else
                    {

                    }
                    Virtue = Virtue - 40;
                    DisplayHUD();
                    break;
                case "Opti3o1n":

                    if (BattleResult(23, 20) == true)
                    {

                    }
                    else
                    {

                    }
                    break;
                default:

                    break;
            }
        }

        static void DisplayHUD()
        {
             
        }

        static bool BattleResult(int attackersStrength, int defenderStrength)
        {
            Random r = new Random();
            double randomNumber  = r.NextDouble();

            if (randomNumber < 0.5)
            {
                return true;
            }
            else
            {
                return false;
            }
            

           
        }
    }
}
            

        

        
    

