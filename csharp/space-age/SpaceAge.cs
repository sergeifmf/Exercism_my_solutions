using System;

namespace SpaceAge
{
	/// <summary>
	/// Given an age in seconds, calculate how old someone would be on different planets of Solar system.
	/// </summary>
	public class SpaceAge
	{
		private int _ageInSeconds;
		
		public int AgeInSeconds
		{
			get => _ageInSeconds;
			set => _ageInSeconds = value;
		}

		public SpaceAge(int seconds)
		{
			AgeInSeconds = seconds;
		}

		public double OnEarth()
		{
			const double earthOrbitalPeriod = 1;

			return OnPlanet(earthOrbitalPeriod);
		}

		public double OnMercury()
		{
			const double mercuryOrbitalPeriod = 0.2408467;

			return OnPlanet(mercuryOrbitalPeriod);
		}

		public double OnVenus()
		{
			const double venusOrbitalPeriod = 0.61519726;

			return OnPlanet(venusOrbitalPeriod);
		}

		public double OnMars()
		{
			const double marsOrbitalPeriod = 1.8808158;

			return OnPlanet(marsOrbitalPeriod);
		}

		public double OnJupiter()
		{
			const double jupiterOrbitalPeriod = 11.862615;

			return OnPlanet(jupiterOrbitalPeriod);
		}

		public double OnSaturn()
		{
			const double saturnOrbitalPeriod = 29.447498;

			return OnPlanet(saturnOrbitalPeriod);
		}

		public double OnUranus()
		{
			const double uranOrbitalPeriod = 84.016846;

			return OnPlanet(uranOrbitalPeriod);
		}

		public double OnNeptune()
		{
			const double neptuneOrbitalPeriod = 164.79132;

			return OnPlanet(neptuneOrbitalPeriod);
		}

		public double OnPlanet(double orbitalPeriod)
		{
			const double secondsInHour = 3600;
			const double hoursInDay = 24;
			const double daysInYear = 365.25;

			return AgeInSeconds / (daysInYear * hoursInDay * secondsInHour * orbitalPeriod);
		}
	}
}