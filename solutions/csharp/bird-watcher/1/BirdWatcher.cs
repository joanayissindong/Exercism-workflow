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
        return birdCount.LastWeek;
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
        for (int i = 0; i < numberOfDays; i++)
        {
            if (birdsPerDay.Length <= i)
            {
                return 0;
            }
        }
        return birdsPerDay[numberOfDays - 1];
    }

    public int BusyDays()
    {
        
    }
}
