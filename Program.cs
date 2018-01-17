using System;

namespace yash
{

    class entity 
    {

      public int random_response()
      {
            Random rnd = new Random();
            int c_choice = rnd.Next(0,3);

             Console.WriteLine("CPU's Choice : ");
             if (c_choice == 0) Console.WriteLine("Rock");
             else if (c_choice == 1) Console.WriteLine("Paper");
             else Console.WriteLine("Scissor");

            return c_choice;
      }
      public int manual_input()
      {
            Console.WriteLine("User's Choice : ");
            string u_choice_string = Console.ReadLine();
            int u_choice;
            if(u_choice_string.Contains("Rock"))
               u_choice = 0;
            else if(u_choice_string.Contains("Paper"))
               u_choice = 1;
            else if(u_choice_string.Contains("Scissors"))
               u_choice = 2;
            else { Console.WriteLine("Invalid Input"); return -1; }

            return u_choice;
      }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string[,] result2D = new string[3,3]{ 
                {"tie", "CPU Wins", "User Wins"}, 
                {"User Wins", "tie", "CPU Wins"}, 
                {"CPU Wins", "User Wins", "tie"} 
                };
             //the columns represents CPU Actions as ROCK-PAPER-SCISSOR
             //the rows represents User Actions as ROCK-PAPER-SCISSOR                                    
           
            Console.WriteLine("_____Rock____Paper____Scissors____");

            ///////////////////////////////////////////////////////

             entity player = new entity();
             entity CPU = new entity();

             char response = 'a';

             do {
             Console.WriteLine();

             int u_choice = player.manual_input();
             int c_choice = CPU.random_response();
             string result = "\0";
             if((u_choice >=0) && (u_choice <= 2))
             {
              result = result2D[u_choice, c_choice];
              Console.WriteLine("------"+result+"------");
             }
             else  Console.WriteLine("------exiting this trial------");

             Console.WriteLine("Press 'Y' to play again or 'N' to quit :");
             response = Convert.ToChar(Console.ReadLine());
             } while(response == 'Y');
        }
    }
}