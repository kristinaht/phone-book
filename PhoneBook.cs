using System;
using System.Collections.Generic;

class PhoneBook
{
  public static Dictionary <string, string> phoneNumbers = new Dictionary <string, string> ();

  static void Main()
  {
    Console.WriteLine("MAIN MENU");
    Console.WriteLine("Would you like to add a person to your phone book? ['Y' for yes, 'Enter' for no]");
    string answer = Console.ReadLine();
    if (answer == "Y" || answer == "y")
    {
      AddContact();
    }
    else
    {
      Console.WriteLine("Would you like to lookup a number in your phone bok? ['Y' for yes, 'Enter' for no]");
      string lookUpAnswer = Console.ReadLine();
      if (lookUpAnswer == "Y" || lookupAnswer == "y") {
       LookUpContact();
      }
      else
      {
        Console.WriteLine("Are you finished with this program? ['Y' for yes, 'Enter' for no]");
        string finishedAnswer = Console.ReadLine();
        if (finishedAnswer == "Y" || finishedAnswer == "y") {
          Console.WriteLine("Goodbye");
        }
        else
        {
          Main();
        }
      }
    }
  }

  static void AddContact()
  {

  }

  static void LookUpContact()
  {

  }
}