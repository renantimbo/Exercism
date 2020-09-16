using System;

public class SpaceAge
{
    const double mercury = 0.2408467;
    const double venus = 0.61519726;
    const double mars = 1.8808158;
    const double jupiter = 11.862615;
    const double saturn = 29.447498;
    const double uranus = 84.016846;
    const double neptune = 164.79132;
    double age_in_earth_years;
    double second;

    public SpaceAge(int seconds)
    {
        age_in_earth_years = seconds / 31557600.0;
        second = seconds;

    }

    public double OnEarth()
    {
        return age_in_earth_years;
    }

    public double OnMercury() => age_in_earth_years / mercury;

    public double OnVenus() => age_in_earth_years / venus;

    public double OnMars() => age_in_earth_years / mars;

    public double OnJupiter() => age_in_earth_years / jupiter;

    public double OnSaturn() => age_in_earth_years / saturn;

    public double OnUranus() => age_in_earth_years / uranus;

    public double OnNeptune() => age_in_earth_years / neptune;
}