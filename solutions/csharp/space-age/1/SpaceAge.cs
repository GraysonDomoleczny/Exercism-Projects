public class SpaceAge
{
    private double _seconds;
    
    public SpaceAge(int seconds) => _seconds = seconds;

    public double OnEarth() =>
        _seconds / 31557600;

    public double OnMercury() =>
        _seconds / 31557600 / 0.2408467;

    public double OnVenus() =>
         _seconds / 31557600 / 0.61519726;

    public double OnMars() =>
         _seconds / 31557600 / 1.8808158;

    public double OnJupiter() =>
         _seconds / 31557600 / 11.862615;

    public double OnSaturn() =>
         _seconds / 31557600 / 29.447498;

    public double OnUranus() =>
         _seconds / 31557600 / 84.016846;

    public double OnNeptune() =>
         _seconds / 31557600 / 164.79132;
}