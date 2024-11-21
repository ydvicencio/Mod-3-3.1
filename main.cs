using System;

class Program {
  public static void Main (string[] args) 
  {
   //enter message 
  Console.WriteLine ("Please, enter your message");
    string messagetext = Console.ReadLine();

    //enter if else statement
  {
    if (messagetext.Length <= 140)
    {
      Console.WriteLine("Posted");
    }
    else
    {
      Console.WriteLine("Rejected");
    }
  }
  }
}

    

    
