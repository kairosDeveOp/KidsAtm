
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

    internal static void Login()
    {
        Console.WriteLine("\nValidating Card Number and PIN...");
        AtmUtility.Animation();

    }
    internal static void LockAcreenMessage()
    {
        Console.Clear();
        AtmUtility.MessageOutput("Your Account is Locked. Contact Bank for more Information.", true);
        AtmUtility.PressEnterToContinue();
        Environment.Exit(1);//enviroment terminate
    }

}