using System;

static class AssemblyLine
{
    // Calculate the successRate value depending on the speed value and return the successRate value
    public static double SuccessRate(int speed)
    {
        int speed = 0;
        double successRate = 0.0;

        if (speed >= 1 && speed <= 4)
        {
            successRate = 1.0;
        }
        else if (speed >= 5 && speed <= 8)
        {
            successRate = 0.9;
        }
        else if (speed == 9)
        {
            successRate = 0.8;
        }
        else if (speed == 10)
        {
            successRate = 0.77;
        }
        else // If the speed value is not between 1 and 10, the successRate value is 0.0
        {
            successRate = 0.0;
        }
        return successRate;
    }

    // Calculate the productionRatePerHour value depending on the speed value and return the productionRatePerHour value
    public static double ProductionRatePerHour(int speed)
    {
        int speed = 0;
        double productionRatePerHour = 0.0;

        // The numberOfCarsPerHour value depending on the speed value and the number of cars produced per hour
        if (speed > 0 || speed < 10)
        {
            int numberOfCarsPerHour = speed * 221;
        }
        else
        {
            int numberOfCarsPerHour = 0;
        }

        // The productionRatePerHour value take into account the successRate value and the numberOfCarsPerHour value

        productionRatePerHour = numberOfCarsPerHour * successRate(speed);

        return productionRatePerHour;
    }

    // Calculate the WorkingItemsPerMinute value depending on the speed value and return the WorkingItemsPerMinute value
    public static int WorkingItemsPerMinute(int speed)
    {
        int speed = 0;
        int workingItemsPerMinute = 0;

        if (speed > 0 || speed < 10)
        {
           return workingItemsPerMinute = (int)Math.Floor(ProductionRatePerHour(speed) / 60);
        }
        else
        {
           return workingItemsPerMinute = 0;
        }

    }
}