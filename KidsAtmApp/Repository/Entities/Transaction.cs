//using KidsAtmApp.Repository.Entities;


namespace KidsAtmApp.Repository.Entities;

public class Transaction
{
    
    public int TransactionId { get; set; }
   // public int UserId { get; set; }
    public string Description { get; set; }
    public double TranctionAmount { get; set; }
    public TransactioType TransactioType{get; set;}

    //public int userId { get; set; } //Fk

    public required UserAccount UserAccount { get; set; } //navigation property
   

}

public enum TransactioType
{
    CashDeposit,
    CashWithdrawal,
    ThirdPartyTransfer
}
 