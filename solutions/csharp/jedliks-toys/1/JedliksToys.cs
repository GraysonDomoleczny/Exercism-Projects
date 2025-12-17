class RemoteControlCar
{
    private int _metersDriven;
    private int _batteryPercentage = 100;
    
    public static RemoteControlCar Buy() => new();

    public string DistanceDisplay() =>
        $"Driven {_metersDriven} meters";

    public string BatteryDisplay() =>
        (_batteryPercentage == 0) ? "Battery empty" : $"Battery at {_batteryPercentage}%";

    public void Drive()
    {
        if (_batteryPercentage > 0)
        {
            _batteryPercentage -= 1;
            _metersDriven += 20;
        }
    }
}
