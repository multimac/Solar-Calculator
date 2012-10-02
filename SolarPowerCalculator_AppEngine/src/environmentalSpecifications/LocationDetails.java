package environmentalSpecifications;

import solarPowerCalculator.CalculatorException;

/**
 * The LocationDetails provides all necessary information regarding a system's location in the world
 * @author Brendon
 *
 */
public class LocationDetails {

	// Class Variables
	private double daylightHours; // Hours
	private double monthlyConsumption; // Killowatt Hours
	private static double hoursInDay = 24; //Hours
	
	/**
	 * Initialises a new instance of location details with specified daylight exposure
	 * @param daylightHours hours of daylight system is exposed to
	 * @throws CalculatorException if daylightHours exceeds hoursInDay
	 */
	public LocationDetails (double daylightHours, double monthlyConsumption) throws CalculatorException {
		if (daylightHours > hoursInDay || daylightHours < 0)
			throw new CalculatorException("daylightHours exceeds limits");
		else
			this.daylightHours = daylightHours;
		
		if (monthlyConsumption < 0)
			throw new CalculatorException("monthlyconsumption cannot be lower than 0");
		else
			this.monthlyConsumption = monthlyConsumption;
	}
	
	/**
	 *  Gets the number of hours of daylight in the day
	 * @return hours of daylight in a day
	 */
	public double getDaylightHours () {
		return daylightHours;
	}
	
	/**
	 *  Gets the number of KWh consumed each day
	 * @return KWh consumed each day
	 */
	public double getMonthlyConsumption () {
		return monthlyConsumption;
	}
	
}
