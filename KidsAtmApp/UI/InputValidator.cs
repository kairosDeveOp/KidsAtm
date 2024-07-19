using System.ComponentModel;

namespace KidsAtmApp.UI;

public static class InputValidator
{
    //this method is generic T 
    // T is the type input we will use to request the value from user. 
    //Convert() convert types..check c# info
    public static T? Convert<T>(string prompt)
    {
        bool value = false;
        string userInput;

        while(!value)//true
        {
            userInput = AtmUtility.GetKidsInput(prompt);

            try
            {

               var convertion =  TypeDescriptor.GetConverter(typeof(T));
               if(convertion != null)
               {
                    // Converting null literal or possible null value to non-nullable type.
                    return (T)convertion.ConvertFromString(userInput); //if user put different type that is supposed to return error 
                    // Converting null literal or possible null value to non-nullable type.
                }
               else
               {
                return default;//null

               }
            }
            catch
            {
                AtmUtility.MessageOutput("You entered an invalid Input. Try again.", false);//will be red if error display
              
            }
        }
        return default;


    }
}
