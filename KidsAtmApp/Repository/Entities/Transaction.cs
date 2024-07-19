using KidsAtmApp.Repository.Entities;

namespace KidsAtmApp.Entities;

public class Transaction
{
    public int TransactionId { get; set; }
    public int UserId { get; set; }
    public string Description { get; set; }
    public decimal TranctionAmount { get; set; }

    public UserAccount userAccount { get; set; } = null!;
   

}