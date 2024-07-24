using KidsAtmApp.UI;
using KidsAtmApp.Repository.Entities;
using KidsAtmApp.Repository.Interfaces;
using Microsoft.Identity.Client;
using System.Diagnostics;
using KidsAtmApp.Entities;

namespace KidsAtmApp;

//implement this class as interface.. 
//[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public class KidsAtm : IUserLogin
{
   //chagne it later this is just check testing database for useraccaount(Kids app)
    private List<UserAccount>? userAccountList;
    private UserAccount? selectedAccount; //hokd selected account
  
    public void RunCode()
    {
      
      AppScreen.Welcome();
      CheckUserCardDigitsAndPin();
      AppScreen.WelcomeKid(selectedAccount!.FirstName, selectedAccount.LastName);
      AppScreen.MenuOutput();
      
    }

    public void InitialData()
    {
      userAccountList = new List<UserAccount>
      {
        new UserAccount{UserAccountId=1, FirstName = "gigi", LastName = "kirk", AccountNumber = 123456, carDigits=433443, CardPin=123123, AccountBalance=20.00, IsLocked=false},
        new UserAccount{UserAccountId=2, FirstName = "junior", LastName = "klian", AccountNumber = 123456, carDigits=433444, CardPin=111111, AccountBalance=10.00, IsLocked=false},
        new UserAccount{UserAccountId=3, FirstName = "Lili", LastName = "cocoa", AccountNumber = 123456, carDigits=433442,CardPin=121212, AccountBalance=50.00, IsLocked=true},
  
      };
      //listOfTransactionS = new List<Transaction>();
    }
     public void CheckUserCardDigitsAndPin()
     {   
        bool isCorrectLogin = false;
        while(isCorrectLogin == false)
        {
           UserAccount inputAccount = AppScreen.UserLoginform();
           AppScreen.Login();
           foreach(UserAccount account in userAccountList)
           {
              selectedAccount = account;
              if(inputAccount.carDigits.Equals(selectedAccount.carDigits))
              {
                 selectedAccount.FullLogin++;

                 if(inputAccount.CardPin.Equals(selectedAccount.CardPin))
                 {
                    selectedAccount = account;

                    if(selectedAccount.IsLocked || selectedAccount.FullLogin > 3)
                    {
                      //display locked account
                      AppScreen.LockScreenMessage();
                    }
                    else
                    {
                      selectedAccount.FullLogin = 0;
                      isCorrectLogin = true;
                       break;
                   }
                }
              }
           
              if(isCorrectLogin == false)
              {
                AtmUtility.MessageOutput("\nInvalid card Digits or PIN.", false);
                selectedAccount.IsLocked = selectedAccount.FullLogin == 3;
                if(selectedAccount.IsLocked)
                {
                   AppScreen.LockScreenMessage();
                }
              }
               Console.Clear();
           }   
        }
     }

     private void MenuChoices()//select choice
     {
      

     }
} 

//internal interface IUserLogin
//{
//}


/*internal interface IUserLogin
{
}*/