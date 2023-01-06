namespace BankingOperation;

public delegate double Tax(double balance);

// public delegate void Messege(string msg);

public class Government
{
    public double DeductTax(double balance){
        Console.WriteLine("Balance after tax deduction");
        if(balance>250000){
            balance+=balance*1.15;
            Console.WriteLine("Balance before tax deduction"+balance);
            return balance;
        } 
        Console.WriteLine("Balance before tax deduction"+balance);
        return balance;
    }

    public double ProfessionalTax(double balance){
        Console.WriteLine("Balance after Ptax deduction");
        if(balance>250000){
            balance+=balance*1.10;
            Console.WriteLine("Balance before tax deduction"+balance);
            return balance;
        } 
        Console.WriteLine("Balance before tax deduction"+balance);
        return balance;
    }
}
