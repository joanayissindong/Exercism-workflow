using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        float interest = 0;
        
        if (balance > 0)
        {
            if (balance < 1000) interest = 0.5f;
            else if (balance >= 1000 && balance < 5000) interest = 1.621f;
            else if (balance >= 5000) interest = 2.475f;
        }
        else
        {
            interest = 3.213f;
        }
        return interest;
    }

    public static decimal Interest(decimal balance) => (decimal) InterestRate(balance);

    public static decimal AnnualBalanceUpdate(decimal balance) => balance + (decimal) InterestRate(balance);

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
