using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        return (float)(balance switch
        {
            0 => 0.0m,
            < 0 => 3.213m,
            < 1000 => 0.5m,
            < 5000 => 1.621m,
            _ => 2.475m
        });
    }

    public static decimal Interest(decimal balance) => balance * (decimal)(InterestRate(balance) / 100);

    public static decimal AnnualBalanceUpdate(decimal balance) => balance + (decimal)InterestRate(balance);

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        var yearsBeforeDesiredBalance = 0;
        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            yearsBeforeDesiredBalance++;
        }
        return yearsBeforeDesiredBalance;
    }
}
