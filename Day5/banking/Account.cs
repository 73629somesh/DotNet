namespace banking;
using notification;
using taxation;

public class Account
{

    public event NotificationOperation underbalance;
    // public event TaxationOperation overbalance;
    public float Balance{get;set;}

    public void deposit(float amount){
        this.Balance+=amount;
        Console.WriteLine("Rs."+amount+" deposited successfully");
        underbalance("Pratik","How are you");
    }

    public void withdraw(float amount){
        this.Balance-=amount;
        Console.WriteLine("Amount deducted successfully");
    }
}
