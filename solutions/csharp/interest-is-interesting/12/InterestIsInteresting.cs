public class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        return (float)(balance switch
        {
            < 0 => 3.213m,
            < 1000 => 0.5m,
            < 5000 => 1.621m,
            _ => 2.475m 
        });
    }

    public static decimal Interest(decimal balance)
    {
        float rate = InterestRate(balance);
        return balance * (decimal)(rate / 100);
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }
    
    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            years++; 
        }
        return years;
    }
}