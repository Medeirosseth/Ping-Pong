using System;



   class PingPong
  {

    static void Main()
    {
      Console.WriteLine("Would you like to play Ping-Pong? ['Y' for yes, 'Enter' for no]  ");
      string answer = Console.ReadLine();
      if(answer == "Y" || answer == "y")
      {
         PlayGame(); 
      }
      else
      {
        Console.WriteLine("Welp nevermind then");
      }

    }

    static void PlayGame()
    {
            Console.WriteLine("Enter a number from 1-30");
      string stringUserInput = Console.ReadLine();
      int userInput = int.Parse(stringUserInput);
      for( int number = 0; number <= userInput; number++)
        if( number % 3 == 0 && number % 5 == 0){
        Console.WriteLine("Ping");
      }
      else if ( number % 3 == 0)
      {
        Console.WriteLine("Pong");
      }
      else if ( number % 5 == 0)
      {
        Console.WriteLine("Ping Pong");
      }
      else 
      {
        Console.WriteLine(number);
      }


    } 


} 
