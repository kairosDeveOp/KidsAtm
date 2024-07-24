using KidsAtmApp.Entities;
using KidsAtmApp.Repository.Entities;
using KidsAtmApp.UI;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace KidsAtmApp.Services;

class MainT
{
    public static string FirstName { get; private set; }

    public static void Main(string[] args)
     {  
         //calling method from AppScreen class
        
       // AppScreen.Welcome();
        //creating an object of the class KidsAtm
        KidsAtm kidsatm = new KidsAtm();//create an object
        kidsatm.InitialData();//call database hardentry
        kidsatm.RunCode();
        
       using(var context = new ApplicationDbContext())
        {
         
         var user = new UserAccount{UserAccountId=1,FirstName = "gigi", LastName = "kirk", AccountNumber = 123456, carDigits=433443, CardPin=123123, AccountBalance=20.00, IsLocked=false}; 
         context.UserAccount.Add(user);
         context.SaveChanges();
        }
        
      
       // AtmUtility.PressEnterToContinue();
        
        //call Welcome method
       // kidsatm.Welcome();
        
       
       // string carDigits = AtmUtility.GetKidsInput("Kids Name");
       // Console.WriteLine($"Kids Name is: {name}");

        // AtmUtility.PressEnterToContinue();
       }
         
}


