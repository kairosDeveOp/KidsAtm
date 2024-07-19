using System.Transactions;

namespace KidsAtmApp.Repository.Entities;


public class UserAccount
{
    public int UserId { get; set; }
    public string FirstName { get; set; }//Kid's name
    public string LastName { get; set; } 
    public long AccountNumber { get; set; }//account credit/savi
    public long carDigits { get; set; } //card number from user
    public int CardPin { get; set; } //personal password
    public decimal AccountBalance    { get; set; }//total login
    public int FullLogin {get; set; }
    public bool IsLocked    { get; set; }//lock in out

    //public  Transaction transaction{ get; set; }
    public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

}