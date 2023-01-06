namespace BankingOperation;

public class Account
{
    public double Balance { get; set; }
    public event Tax overBalance;
    // public event Tax underBalance;

    public Account(double balance)
    {
        this.Balance = balance;
    }

    public void Withdraw(double amount){
        this.Balance-=amount;
    }

    public void Deposite(double amount){
        this.Balance+=amount;
    }

    public override string ToString()
    {
        return base.ToString()+" Balance : "+this.Balance;
    }

    public void ProcessTax(){
        if(this.Balance>=250000){
            this.Balance=overBalance(this.Balance);
        }
        // else if(this.Balance<5000){
        //     underBalance();
        // }
    }


}