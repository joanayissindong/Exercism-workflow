using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        BirdCount birdCount = new BirdCount(new int[] { 0, 2, 5, 3, 7, 8, 4 });
        return birdCount;
    }

    public int Today()
    {
        if (birdsPerDay.Length == 0)
        {
            return 0;
        }
        return birdsPerDay[birdsPerDay.Length - 1];
    }

    public void IncrementTodaysCount()
    {
        if (birdsPerDay.Length > 0)
        {
            birdsPerDay[birdsPerDay.Length - 1]++;
        }
    }

    public bool HasDayWithoutBirds()
    {
        foreach (int birds in birdsPerDay)
        {
            if (birds == 0)
            {
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
       int total = 0;
        int daysToCount = Math.Min(numberOfDays, birdsPerDay.Length);
        for (int i = 0; i < daysToCount; i++)
        {
            total += birdsPerDay[i];
        }
        return total;
    }

    public int BusyDays()
    {
       int busyDays = 0;
        foreach (int birds in birdsPerDay)
        {
            if (birds >= 5)
            {
                busyDays++;
            }
        }
        return busyDays;
    }
}
