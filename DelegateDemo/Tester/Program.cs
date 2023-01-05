using BankingOperation;

Government govt = new Government();

Account acct = new Account(7500);


Tax taxation = new Tax(govt.DeductTax);
Tax iTaxation = new Tax(govt.ProfessionalTax);




acct.overBalance+=taxation;
acct.overBalance+=iTaxation;

Console.WriteLine("Enter Amount to be deposited");
double amount=double.Parse(Console.ReadLine());
acct.Deposite(amount);
Console.WriteLine(acct);


acct.ProcessTax();
Console.WriteLine("Balance before tax deduction"+acct);
Console.WriteLine(acct);









