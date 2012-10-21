package environmentalSpecifications;

import solarPowerCalculator.CalculatorException;

/**
 * The LocationDetails provides all necessary information regarding a system's location in the world
 * @author Glen-Andrew
 *
 */
public class LocationDetails {

	// Class Variables
	private double daylightHoursWinter; // Hours of direct sunlight in the cool months
	private double daylightHoursSummer; // Hours of direct sunlight in the warm months
	private int monthlyWinterConsumption; // Killowatt Hours (May-Oct)
	private int monthlySummerConsumption; // Killowatt Hours (Nov-Apr)
	private double exportRate; // Feed in tariff in dollars
	private double importRate; // Import tariff in dollars
	private int roofTempWinter; // Mean temp at 3pm in the cool months from the database
	private int roofTempSummer; // Mean temp at 3pm in the warm months from the database
	private double solarInsolationWinter; // Solar insolation during the cool months
	private double solarInsolationSummer; // solar insolation during the warm months
	
	private static double hoursInDay = 24; //Hours
	private static int maxTemp = 80; // Degrees Celsius
	private static int minTemp = -40; // Degrees Celsius
	
	/**
	 * Initialises a new instance of location details with specified daylight exposure
	 * @param daylightHours hours of daylight system is exposed to
	 * @param exportRate 
	 * @throws CalculatorException if daylightHours exceeds hoursInDay
	 */
	public LocationDetails (double daylightHoursWinter, double daylightHoursSummer, int monthlyWinterConsumption, int monthlySummerConsumption, 
			double exportRate, double importRate, int roofTempWinter, int roofTempSummer, double solarInsolationWinter, double solarInsolationSummer)
					throws CalculatorException {
		if (daylightHoursWinter > hoursInDay || daylightHoursWinter < 0 || daylightHoursSummer > hoursInDay || daylightHoursSummer < 0)
			throw new CalculatorException("daylightHours exceeds limits");
		else
			this.daylightHoursWinter = daylightHoursWinter;
			this.daylightHoursSummer = daylightHoursSummer;
			
		if (roofTempWinter > maxTemp || roofTempWinter < minTemp || roofTempSummer > maxTemp || roofTempWinter < minTemp)
			throw new CalculatorException("roof temprature exceeds limits");
		else
			this.roofTempWinter = roofTempWinter;
			this.roofTempSummer = roofTempSummer;
		
		if (monthlyWinterConsumption < 0)
			throw new CalculatorException("monthlyWinterConsumption cannot be lower than 0");
		else
			this.monthlyWinterConsumption = monthlyWinterConsumption;
		if (monthlySummerConsumption < 0)
			throw new CalculatorException("monthlySummerConsumption cannot be lower than 0");
		else
			this.monthlySummerConsumption = monthlySummerConsumption;
		if (exportRate < 0)
			throw new CalculatorException("export rate must be positive");
		else
			this.exportRate = exportRate;
		if (importRate < 0)
			throw new CalculatorException("import rate must be positive");
		else
			this.importRate = importRate;
		if (solarInsolationWinter < 0 || solarInsolationSummer < 0)
			throw new CalculatorException("solar insolation must be positive");
		else
			this.solarInsolationWinter = solarInsolationWinter;
			this.solarInsolationSummer = solarInsolationSummer;
	}
	
	
	/**
	 *  Gets the average number of hours of sunlight directly hitting the ground
	 * @return average hours of direct sunlight May-Oct
	 */
	public double getDaylightHoursWinter () {
		return daylightHoursWinter;
	}
	
	/**
	 *  Gets the average number of hours of sunlight directly hitting the ground
	 * @return average hours of direct sunlight Nov-Apr
	 */
	public double getDaylightHoursSummer () {
		return daylightHoursSummer;
	}
	
	/**
	 * Gets the average degrees celsius of the roof during Nov-Apr at 3pm
	 * @return average roof temp
	 */
	public int getRoofTempSummer () {
		return roofTempSummer;
	}
	
	/**
	 * Gets the average degrees celsius of the roof during May-Oct at 3pm
	 * @return average roof temp
	 */
	public int getRoofTempWinter () {
		return roofTempWinter;
	}
	
	/**
	 * Get the average amount of solar insolation in KWhs per m2 per day May-Oct
	 * @return solar insolation
	 */
	public double getSolarInsolationWinter () {
		return solarInsolationWinter;
	}
	
	/**
	 * Get the average amount of solar insolation in KWhs per m2 per day Nov-Apr
	 * @return solar insolation
	 */
	public double getSolarInsolationSummer () {
		return solarInsolationSummer;
	}
	
	/**
	 * Gets the import tariff
	 * @return the import tariff in dollars
	 */
	public double getImportRate () {
		return importRate;
	}
	
	
	/**
	 *  Gets the number of KWh consumed each month during the cold months of MAY-OCT inclusive
	 * @return average monthly consumption in KWh
	 */
	public int getMonthlyWinterConsumption () {
		return monthlyWinterConsumption;
	} 
	
	/**
	 *  Gets the number of KWh consumed each month during the warm months of NOV-APR inclusive
	 * @return average monthly consumption in KWh
	 */
	public int getMonthlySummerConsumption () {
		return monthlySummerConsumption;
	}
	
	/**
	 * Gets the export tariff/feed in tariff
	 * @return the export tariff in dollars
	 */
	public double getExportRate () {
		return exportRate;
	}
}
