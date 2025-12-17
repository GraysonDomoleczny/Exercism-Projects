class RemoteControlCar
{
    private int _speed;
    private int _batteryDrain;
    private int _metersDriven;
    private int _batteryPercent = 100;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        _speed = speed;
        _batteryDrain = batteryDrain;
    }

    public bool BatteryDrained() =>
        _batteryPercent < _batteryDrain;

    public int DistanceDriven() => _metersDriven;

    public void Drive()
    {
        if (!BatteryDrained())
        {
            _metersDriven += _speed;
            _batteryPercent -= _batteryDrain;  
        }
    }

    public static RemoteControlCar Nitro() =>
        new RemoteControlCar(50, 4);
}

class RaceTrack
{
    private int _distance;

    public RaceTrack(int distance) => _distance = distance;

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained())
            car.Drive();
        
        return car.DistanceDriven() >= _distance;
    }
}
