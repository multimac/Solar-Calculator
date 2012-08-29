package environmentalSpecifications;

import solarPowerCalculator.CalculatorException;

/**
 * The LocationDetails provides all necessary information regarding a system's location in the world
 * @author Brendon
 *
 */
public class LocationDetails {

	// Class Variables
	private int daylightHours; // Hours
	private static int hoursInDay = 24; //Hours
	
	/**
	 * Initializes a new instance of location details with specified daylight exposure
	 * @param daylightHours hours of daylight system is exposed to
	 * @throws CalculatorException if daylightHours exceeds hoursInDay
	 */
	public LocationDetails (int daylightHours) throws CalculatorException{
		
		if (daylightHours > hoursInDay || daylightHours < 0)
			throw new CalculatorException("daylightHours exceeds limits");
		else
			this.daylightHours = daylightHours;
		
	}
	
	/**
	 *  Gets the number of hours of daylight in the day
	 * @return hours of daylight in a day
	 */
	public int getDaylightHours () {
		return daylightHours;
	}
	
}
