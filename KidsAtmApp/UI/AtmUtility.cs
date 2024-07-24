using System.Text;

namespace KidsAtmApp.UI;

public static class AtmUtility
{   //will get temp pin input
     public static string GetPinInput(string prompt) //secrete in asteriscs
     {
        bool isPrompt = true;
        string stars = "";

        StringBuilder input = new StringBuilder();
        while(true)
        {
            if(isPrompt )
                 Console.WriteLine(prompt);
                 isPrompt = false;
                 /*ConsoleKeyInfor is returned to the user in response to calling the Console.ReadKey method*/
                 ConsoleKeyInfo inputKey = Console.ReadKey(true);    

                 if(inputKey.Key == ConsoleKey.Enter) //if enter 6 ..good else wrong input length
                 {
                    if(input.Length == 6)
                    {
                        break; //success
                    }
                    else
                    {
                        MessageOutput("\nPlease enter 6 digits." , false);
                        input.Clear();
                        isPrompt = true;
                       // input.Clear();//user start again ...clear state
                        continue;

                    }

                 }
                 if(inputKey.Key == ConsoleKey.Backspace && prompt.Length > 0)
                 {
                    input.Remove(input.Length -1, 1); //will call removeMethod of the string ..remove position index.
                 }
                 else if(inputKey.Key != ConsoleKey.Backspace)
                 {
                    input.Append(inputKey.KeyChar);
                    Console.Write(stars+ "*");//secret pin showing screen as **
                    
                 }
        }
        return  input.ToString(); 
     }
      
      /*Print message interacting with method ForegroundColor.. */
     public static void MessageOutput(string message, bool success = true )//==true
    {
        if(success)//if true success
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        Console.WriteLine(message);
       // Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.White;
        //PressEnterToContinue();
    }

    public static string GetKidsInput(string prompt)
    {
        Console.WriteLine($"Enter {prompt}");//''
        return Console.ReadLine();
    }
    public static void Animation(int timer = 10)
    {
        //timer = 10;
        for(int i = 0; i<timer; i++)
        {
          Console.Write(":)");
          Thread.Sleep(200);
        }
        Console.Clear();
    }
    public static void PressEnterToContinue()
    {
     Console.WriteLine(" | Press Enter to Continue: |");
     Console.ReadLine();
     }
}   

