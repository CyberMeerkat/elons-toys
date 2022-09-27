using System;

class RemoteControlCar
{
    public static RemoteControlCar Buy() => new();
    public string DistanceDisplay() =>
        $"Driven {_distanceCovered} meters";

    public string BatteryDisplay() =>
        _batteryLife > 0 ? $"Battery at {_batteryLife}%" : "Battery empty";

    public void Drive()
    {
        if (_batteryLife > 0)
        {
            _distanceCovered += 20;
            _batteryLife -= 1;
        }
    }

    private int _distanceCovered = 0;
    private int _batteryLife = 100;
}
