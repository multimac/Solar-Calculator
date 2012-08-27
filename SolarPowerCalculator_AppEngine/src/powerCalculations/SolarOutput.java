package powerCalculations;

import environmentalSpecifications.*;


/**
 * SolarOutput is responsible for all calculations relating to energy output of a system
 * 
 * @author Brendon
 *
 */
public class SolarOutput {
	
	private static int wattsInKiloWatts = 1000;
	
	
	/**
	 * Calculates the hourly output of a system in KWh
	 * 
	 * @param system the solar panel system configuration
	 * @return The hourly output of a system in KWh
	 */
	public static double calculateHourlyOutput(SystemConfiguration system) {
		
		double output = (((system.getPanelOutput() * system.getPanelCount()) * system.getInverterEfficiency()) / wattsInKiloWatts);
		return output;
	}
	
	/**
	 *  Calculates the daily output of a system given its location and set-up
	 *  
	 * @param location LocationDetails details about the location of the set-up
	 * @param system PanelConfiguration the solar panel system configuration
	 * @return The daily of output of the system in KWh
	 */
	public static double calculateDailyOutput(LocationDetails location, SystemConfiguration system) {
		
		return calculateHourlyOutput(system) * location.getDaylightHours();
	}
	
	/**
	 *  Calculates the monthly output of a system given its location and set-up
	 * 
	 * @param location LocationDetails details about the location of the set-up
	 * @param system PanelConfiguration the solar panel system configuration
	 * @return The daily of output of the system in KWh
	 */
	public static double calculateMonthlyOutput(LocationDetails location , SystemConfiguration system) {
		
		return calculateDailyOutput(location, system)*30;
		
	}

	
}
