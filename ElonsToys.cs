using System;

class RemoteControlCar
{
    public static RemoteControlCar Buy() => new RemoteControlCar();
    public string DistanceDisplay() =>
        $"Driven {distanceCovered} meters";

    public string BatteryDisplay() =>
        batteryLife > 0 ? $"Battery at {batteryLife}%" : "Battery empty";

    public void Drive()
    {
        if (batteryLife > 0)
        {
            distanceCovered += 20;
            batteryLife -= 1;
            if (batteryLife <= 0)
                BatteryDisplay();
        }
    }

    private int distanceCovered = 0;
    private int batteryLife = 100;
}
