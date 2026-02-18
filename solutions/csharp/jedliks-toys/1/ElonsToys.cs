class RemoteControlCar
{
    private int distanceDriven;
    private int batteryPercentage;
    
    // Constructor initialize a new car with full battery and zero distance
    private RemoteControlCar()
    {
        distanceDriven = 0;
        batteryPercentage = 100;
    }
    
    // Static method to buy a new car
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }
    
    // Method to get the distance driven
    public string DistanceDisplay()
    {
        return $"Driven {distanceDriven} meters";
    }

    // Method to get the battery percentage
    public string BatteryDisplay()
    {
        return batteryPercentage > 0 ? $"Battery at {batteryPercentage}%" : "Battery empty";
    }

    // Method to drive the car
    public void Drive()
    {
        if (batteryPercentage > 0)
        {
            batteryPercentage -= 1;
            distanceDriven += 20;
        }
    }
}
