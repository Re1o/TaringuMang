
using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {


            /*int userNumber1;
            int userNumber2;
            int userNumber3;
        Console.WriteLine("Kirjutage üks number 1-10");
        userNumber1 = Int32.Parse(Console.ReadLine());

        Console.WriteLine("kirjutage üks number 1-10");
        userNumber2 = Int32.Parse(Console.ReadLine());

        Console.WriteLine("kirjutage üks number 1-10");
            userNumber3 = Int32.Parse(Console.ReadLine());


            if (userNumber1 > userNumber2)
            {
                if (userNumber1 > userNumber3)
                {
                    Console.WriteLine($"{userNumber1} on kõige suurem");

                    if (userNumber2 > userNumber1) ;

                    
                }

            }

         Console.ReadLine();

            







            start: 
            

            Random randomGenerator = new Random();
            int cpuRoll = randomGenerator.Next(1, 7);
            Console.WriteLine("viska täringut");
            int userRoll = int.Parse(Console.ReadLine());
            
            if(userRoll > cpuRoll)
            {
                Console.WriteLine("sina oled võitnud");

            }
            else if(userRoll < cpuRoll)
            {
                Console.WriteLine("sina kaotasid");
            }
            else
            {
                Console.WriteLine("viik");
            }
            goto start;*/



            /*      int userRoll;
                  int cpuRoll;
                  int rolls = 0;
              int userScore = 0;
              int cpuScore = 0;

              Random rnd = new Random();

              while (rolls < 3)
              {
                  userRoll = rnd.Next(1, 7);
                  cpuRoll = rnd.Next(1, 7);

                  Console.WriteLine($"sina viskasid {userRoll}, CPU rolled {cpuRoll}");

                  if (userRoll > cpuRoll)
                  {
                      //userScore = userScore + 1;
                      userScore++;

                  }

                  else if (userRoll < cpuRoll)
                  {
                      cpuScore++;
                  }
                  else
                  {
                      continue;
                  }

                  rolls++;
                  Console.ReadLine();

              }

              if(userScore > cpuScore)
              {
                  Console.WriteLine("sina võitsid!!!!!");
              }
              else if(userScore < cpuScore)
              {
                  Console.WriteLine("sina kaotasid");
              }
              else
              {
                  Console.WriteLine("keegi ei võitnud");

              }
              Console.WriteLine($"sina skoorisid {userScore}, CPU scored {cpuScore}");




              Console.ReadLine();*/

            /*  Random rnd = new Random();
              int randomNumber = rnd.Next(1, 6);
              Console.WriteLine($"CPU generated {randomNumber}");

              switch(randomNumber)
              {
                  case 1:
                      Console.WriteLine("one");
                      break;
                      case 2:
                      Console.WriteLine("two");
                      break;
                      case 3:
                      Console.WriteLine("three");
                      break;
                      case 4:
                      Console.WriteLine("four");
                      break;
                      case 5:
                      Console.WriteLine("five");
                      break;
                  default:
                      Console.WriteLine("CPU greated nothing");
                      break;

              }
              console.writeline("one");*/

            Console.WriteLine("Pick a colour (red, blue, black, pink):");
            string answer = Console.ReadLine();

            switch(answer)
            {
                case "red":
                    Console.WriteLine("you are romantic type");
                    break;
                case "black":
                    Console.WriteLine("you are a loner");
                    break;
                case "blue":
                    Console.WriteLine("you are blue as the sea");
                    break;
                case "pink":
                    Console.WriteLine("hahahah you are in love my dude :D");
                    break;
                default:
                    Console.WriteLine("i can not recognize this color");
                    break;
                    
            }

            Console.ReadLine();


        }
    }
}
