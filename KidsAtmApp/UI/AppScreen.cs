
using KidsAtmApp.Repository.Entities;

namespace KidsAtmApp.UI;

public static class AppScreen
{
    //method will be called in Main
    internal static void Welcome() 
    {
     Console.Clear();
        //title of the console window
     Console.Title = "Kids ATM App. ";
     Console.WriteLine("\n\n********************    WELCOME TO kIDS ATM APP!    ********************\n\n");
     Console.WriteLine(" | Follow the Instructions |");
    // Console.ReadLine();
     //Console.WriteLine("Insert your ATM Kid's card:");
     //Console.ReadLine();
     AtmUtility.PressEnterToContinue();
     
     /*
     Console.WriteLine("***********************************************************************"  );
     Console.WriteLine("  |             KIDS :) ALLOWANCE ATM APP MENU                          |");
     Console.WriteLine("  |                                                                     |");
     Console.WriteLine("  |  CHORES:                                                            |");
     Console.WriteLine("  | 1 - Clean out The Car                                     { $2,00 } |");  
     Console.WriteLine("  | 1 - Clean up the bedroom                                  { $2,00 } |");  
     */
    }
    internal static UserAccount  UserLoginform()
    {
         UserAccount tempUserAccount = new UserAccount();
         tempUserAccount.carDigits = InputValidator.Convert<long>("Your Kid's Card Number.");
        //assign temporary kids pin number
         tempUserAccount.CardPin = Convert.ToInt32(AtmUtility.GetPinInput("Enter your PIN Number"));
         return tempUserAccount;

    }

    internal static void Login()//login progress
    {
        Console.WriteLine("\nValidating Card Number and PIN...");
        AtmUtility.Animation();

    }

    //print lock scree message from ATM utility method check card number and pin
    internal static void LockScreenMessage()
    {
        Console.Clear();
        AtmUtility.MessageOutput("Your Account is Locked. Contact Bank for more Information. Thank you!", true);
      //  AtmUtility.PressEnterToContinue();
        Environment.Exit(1);//enviroment terminate

        
    }
    internal static void WelcomeKid(string FirstName, string LastName)//work for login user
      {
         Console.WriteLine($"Welcome back, {FirstName}, {LastName}");
         AtmUtility.PressEnterToContinue();
      }

     internal static void MenuOutput()
     {
        Console.Clear();
        Console.WriteLine("****************     KIDS ATM APP MENUE   ************************");
        Console.WriteLine("  |                                                              |");
        Console.WriteLine("  | 1 - Account Balance                                          |");
        Console.WriteLine("  | 2 - Cash Deposit                                             |");  
        Console.WriteLine("  | 3 - Withdrawal                                               |");
        Console.WriteLine("  | 4 - Transfer                                                 |");
        Console.WriteLine("  | 5 - Transactions                                             |");
        Console.WriteLine("  | 6 - Logout                                                   |");  
        //Console.WriteLine("  | 1 -                                   { $2,00 } |");  
       

     
     } 

}