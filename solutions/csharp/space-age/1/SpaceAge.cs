using System;

public class SpaceAge
{
    private readonly int _ageInSeconds; // age in seconds
    private const double _secondsInEarthYear = 31557600; // age in seconds in earth year
    public SpaceAge(int seconds)
    {
        int _ageInSeconds = seconds; // initialisation: age in seconds
    }

    public double OnEarth() => Math.Round((_ageInSeconds / _secondsInEarthYear), 2);

    public double OnMercury() => Math.Round((_ageInSeconds / (_secondsInEarthYear * 0.2408467)), 2);

    public double OnVenus() => Math.Round((_ageInSeconds / (_secondsInEarthYear * 0.61519726)), 2);

    public double OnMars() => Math.Round((_ageInSeconds / (_secondsInEarthYear * 1.8808158)));

    public double OnJupiter() => Math.Round((_ageInSeconds / (_secondsInEarthYear * 11.862615)));

    public double OnSaturn() => Math.Round((_ageInSeconds / (_secondsInEarthYear * 29.447498)));

    public double OnUranus() => Math.Round((_ageInSeconds / (_secondsInEarthYear * 84.016846)));

    public double OnNeptune() => Math.Round((_ageInSeconds / (_secondsInEarthYear * 164.79132)));
}