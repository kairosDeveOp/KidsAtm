using KidsAtmApp.UI;

namespace KidsAtmApp.Services;

class MainT
{
     public static void Main(string[] args)
     {
       
        //calling method from AppScreen class
        AppScreen.Welcome();
        //creating an object of the class KidsAtm
        KidsAtm kidsAtmApp = new KidsAtm();
        
        //Call method
        KidsAtm.CheckUserCardDigitsAndPin();
        
       
       // string carDigits = AtmUtility.GetKidsInput("Kids Name");
      //  Console.WriteLine($"Kids Name is: {name}");

         AtmUtility.PressEnterToContinue();
         
    }

}
