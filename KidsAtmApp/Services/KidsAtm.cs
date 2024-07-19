
using KidsAtmApp.UI;
using KidsAtmApp.Repository.Entities;
using Microsoft.Identity.Client;

namespace KidsAtmApp;

//implement this class as interface.. 
class KidsAtm //: IUserLogin
{
   //chagne it later this is just check testing database for useraccaount(Kids app)
    private List<UserAccount> userAccountList;
    public static UserAccount selectedAccount;

    public static IEnumerable<UserAccount> UserAccountList { get; private set; }

    public void InitialData()
    {
      userAccountList = new List<UserAccount>
      {
        new UserAccount{UserId=1, FirstName = "gigi", LastName = "kirk", AccountNumber = 123456, carDigits=433443, CardPin=123123, AccountBalance=20.00m, IsLocked=false},
        new UserAccount{UserId=2, FirstName = "junior", LastName = "klian", AccountNumber = 123456, carDigits=433444, CardPin=111111, AccountBalance=10.00m, IsLocked=false},
        new UserAccount{UserId=3, FirstName = "Lili", LastName = "cocoa", AccountNumber = 123456, carDigits=433442,CardPin=121212, AccountBalance=50.00m, IsLocked=true},
  
      };
    }
     public static void CheckUserCardDigitsAndPin()
    {   
        bool isCorrectLogin = false;
           UserAccount inputAcc = AppScreen.UserLoginform();
           AppScreen.Login();
         /*  foreach(UserAccount uaccount in UserAccountList)
           {
             selectedAccount  = uaccount;
            if(inputAcc.carDigits.Equals(selectedAccount.carDigits))
            {
              selectedAccount.FullLogin++;
              if(inputAcc.CardPin.Equals(selectedAccount.CardPin))
              {
                selectedAccount = uaccount;
                if(selectedAccount.IsLocked || selectedAccount.FullLogin>3)
                {
                  //lock account
                  AppScreen.LockAcreenMessage();

                }
                else
                {
                  selectedAccount.FullLogin = 0;
                  isCorrectLogin = true;
                  break;
                }
              }

            }

           }*/
        }
       // if(isCorrectLogin)
}     
      

/*internal interface IUserLogin
{
}*/