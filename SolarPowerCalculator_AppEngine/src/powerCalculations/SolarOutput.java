package powerCalculations;

import java.text.DecimalFormat;

import environmentalSpecifications.*;


/**
 * SolarOutput is responsible for all calculations relating to energy output of a system
 *
 */
public class SolarOutput {	
	
	private static int wattsInKilowatt = 1000;
	private static DecimalFormat decFormat = new DecimalFormat("#.##");
	
	/**
	 * Calculates the hourly output of a system in Wh
	 * 
	 * @param system the solar panel system configuration
	 * @return The hourly output of a system in KWh
	 */
	public static double calculateHourlyOutput(SystemConfiguration system) {
		double output = (((system.getPanelOutput() * system.getPanelCount()) * system.getInverterEfficiency()));
		return output;
	}
	
	/**
	 *  Calculates the gross daily output of a system given its location and set-up
	 *  
	 * @param location LocationDetails details about the location of the set-up
	 * @param system PanelConfiguration the solar panel system configuration
	 * @return The daily of output of the system in KWh
	 */
	public static double calculateGrossDailyOutput(LocationDetails location, SystemConfiguration system) {
		return calculateHourlyOutput(system) * location.getDaylightHours() / wattsInKilowatt;
	}
	
	/**
	 *  Calculates the net daily output of a system given its location and set-up, and hours consumed
	 *  
	 * @param location LocationDetails details about the location of the set-up
	 * @param system PanelConfiguration the solar panel system configuration
	 * @return The daily of output of the system in KWh
	 */
	public static double calculateNetDailyOutput(LocationDetails location, SystemConfiguration system) {
		return calculateGrossDailyOutput(location, system) - (location.getMonthlyConsumption() / 30);
	}
	
	/**
	 *  Calculates the monthly output of a system given its location and set-up
	 * 
	 * @param location LocationDetails details about the location of the set-up
	 * @param system PanelConfiguration the solar panel system configuration
	 * @return The daily of output of the system in KWh
	 */
	public static double calculateMonthlyOutput(LocationDetails location , SystemConfiguration system) {
		return calculateGrossDailyOutput(location, system)*30;
	}
	
	/**
	 * 
	 * Calculates the expected system cost based on the system rating
	 * @param system PanelConfiguration the solar panel system configuration
	 * @return The expected dollar cost of the system
	 */
	public static double calculateSystemCost(SystemConfiguration system) {
		double hourlyRawOutput = system.getPanelCount() * system.getPanelOutput();
		int installCost = 1000;
		double rawCost = hourlyRawOutput + calculateInverterCost(hourlyRawOutput)  + installCost;
		//DecimalFormat decFormat = new DecimalFormat("#.##");
	    return Double.valueOf(decFormat.format(rawCost));
	}

	/**
	 * 
	 * @param systemOutput the Raw output of a system in W
	 * @return expected cost of an inverter to match output
	 */
	private static double calculateInverterCost(double systemOutput) {
		return -0.00004211*(systemOutput *systemOutput) + 1.06954219*systemOutput + 269.44442;
	}
	/**
	 * 
	 * @param system
	 * @param location
	 * @return the dollar value that the system is generating per month
	 */
	public static double calculateOutputValue(SystemConfiguration system, LocationDetails location) {
		//0.08 is the hardwired value of the feed-in rate but should be a user input
		double outputValue = calculateMonthlyOutput(location, system)*0.08;
		return Double.valueOf(decFormat.format(outputValue));
	}

	
}
