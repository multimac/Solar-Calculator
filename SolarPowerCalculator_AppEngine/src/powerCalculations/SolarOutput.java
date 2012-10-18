package powerCalculations;

import java.text.DecimalFormat;

import environmentalSpecifications.*;


/**
 * SolarOutput is responsible for all calculations relating to energy output of a system
 * @author Glen-Andrew 
 */
public class SolarOutput {	
	
	private static int wattsInKilowatt = 1000;
	private static DecimalFormat moneyDecFormat = new DecimalFormat("#.##");
	private static int installCost = 1000;
	private static double daysInMonth = 30.44;
	

	public static double calculateSystemRating(SystemConfiguration system) {
		return (system.getPanelCount()*system.getPanelOutput()*system.getInverterEfficiency());
	}
	
	public static double calculatePanelArea(SystemConfiguration system) {
		return (calculateSystemRating(system)/system.getPanelDensity());
	}
	
	public static double calculateSolarExposureWinter(SystemConfiguration system, LocationDetails location) {
		double maxExposure = location.getSolarInsolationWinter()*calculatePanelArea(system);
		double likelyExposure = maxExposure/(location.getDaylightHoursWinter()/2);
		return likelyExposure;
	}
	
	public static double calculateSolarExposureSummer(SystemConfiguration system, LocationDetails location) {
		double maxExposure = location.getSolarInsolationSummer()*calculatePanelArea(system);
		double likelyExposure = maxExposure/(location.getDaylightHoursSummer()/2);
		return likelyExposure;
	}
	
	public static double calculatePanelEfficiencyWinter (SystemConfiguration system, LocationDetails location, int year) {
		int tempDifference = location.getRoofTempWinter() - 25;
		double tempAjustment = tempDifference*system.getTempCoefficient();
		double denegration = 1;
		for (int i = 0 ; i < year; i = i + 1) {
			denegration = denegration - ((1 - system.getPanelDegradation())*denegration);
		}
		double ajustedEfficiency = (system.getPanelEfficiency() + tempAjustment) * denegration;
		return ajustedEfficiency;
	}
	
	public static double calculatePanelEfficiencySummer (SystemConfiguration system, LocationDetails location, int year) {
		int tempDifference = location.getRoofTempSummer() - 25;
		double tempAjustment = tempDifference*system.getTempCoefficient();
		double denegration = 1;
		for (int i = 0 ; i < year; i = i + 1) {
			denegration = denegration - ((1 - system.getPanelDegradation())*denegration);
		}
		double ajustedEfficiency = (system.getPanelEfficiency() + tempAjustment) * denegration;
		return ajustedEfficiency;
	}
	
	public static double calculateMonthlyWinterOutput (SystemConfiguration system, LocationDetails location, int year) {
		double maxPossible = calculatePanelEfficiencyWinter(system, location, year)*calculateSolarExposureWinter(system, location);
		if (maxPossible > calculateSystemRating(system)) {
			return (calculateSystemRating(system)*daysInMonth);
		}
		else {
			return maxPossible*daysInMonth;
		}
	}
	
	public static double calculateMonthlySummerOutput (SystemConfiguration system, LocationDetails location, int year) {
		double maxPossible = calculatePanelEfficiencySummer(system, location, year)*calculateSolarExposureSummer(system, location);
		if (maxPossible > calculateSystemRating(system)) {
			return (calculateSystemRating(system)*daysInMonth);
		}
		else {
			return maxPossible*daysInMonth;
		}
	}
	
	public static double calculateAverageMonthlyOutput (SystemConfiguration system, LocationDetails location, int year) {
		return (calculateMonthlyWinterOutput(system, location, year) + calculateMonthlySummerOutput(system, location, year)) / 2;
	}
	
	public static double calculateMonthlyWinterSavings (SystemConfiguration system, LocationDetails location, int year) {
		double monthlyOutput = calculateMonthlyWinterOutput(system, location, year);
		double exportedPower = 0;
		if (monthlyOutput > location.getMonthlyWinterConsumption()) {
			exportedPower = monthlyOutput - location.getMonthlyWinterConsumption();
		}
		return ((monthlyOutput - exportedPower)*location.getImportRate()) + (exportedPower*location.getExportRate());
	}
	
	public static double calculateMonthlySummerSavings (SystemConfiguration system, LocationDetails location, int year) {
		double monthlyOutput = calculateMonthlySummerOutput(system, location, year);
		double exportedPower = 0;
		if (monthlyOutput > location.getMonthlySummerConsumption()) {
			exportedPower = monthlyOutput - location.getMonthlySummerConsumption();
		}
		return ((monthlyOutput - exportedPower)*location.getImportRate()) + (exportedPower*location.getExportRate());
	}
	
	public static double calculateAverageMonthlySavings (SystemConfiguration system, LocationDetails location, int year) {
		return (calculateMonthlyWinterSavings(system, location, year) + calculateMonthlySummerSavings(system, location, year)) / 2;
	}
	
	public static String calculateBreakEvenTime (SystemConfiguration system, LocationDetails location) {
		double cost = calculateSystemCost(system);
		double savings = 0;
		int year = 0;
		int month = 0;
		int finalMonth = 1;
		while (savings < cost) {
			while (month < 12 && savings < cost) {
				savings = savings + calculateAverageMonthlySavings(system, location, year);
				// DATAPOINT FOR CHARTS HERE
				month = month + 1;
				finalMonth = month;
			}
			month = 0;
			year = year + 1;
		}
		return (year-1 + " years, " + finalMonth + " months");
	}
	
	public static double getInitialMonthlySavings (SystemConfiguration system, LocationDetails location) {
		return calculateAverageMonthlySavings(system, location, 0);
	}
	
	public static double getInitialMonthlyOutput (SystemConfiguration system, LocationDetails location) {
		return calculateAverageMonthlyOutput(system, location, 0);
	}
	
	
	
	
	
	
	
	
	
	
	
	
	


	/**
	 * 
	 * Calculates the expected system cost based on the system rating
	 * @param system PanelConfiguration the solar panel system configuration
	 * @return The expected dollar cost of the system
	 */
	public static double calculateSystemCost(SystemConfiguration system) {
		double hourlyRawOutput = system.getPanelOutput()*system.getPanelCount();
		double rawCost = hourlyRawOutput + calculateInverterCost(hourlyRawOutput)  + calculateInstallCost();
	    return Double.valueOf(moneyDecFormat.format(rawCost));
	}

	/**
	 * 
	 * @param systemOutput the Raw output of a system in W
	 * @return expected cost of an inverter to match output
	 */
	public static double calculateInverterCost(double systemOutput) {
		//Calculation should be somthing like this, don't have time to implement and test right now.
		//Say, inverters come in increments of 250 watts, at $200 per increment. With $300 base line.
		//return (Math.ceil(systemOutput / 250))*200 + 300;
		
		return (Math.ceil(systemOutput)) + 300;
		//return 1.06954219*systemOutput + 269.44442;
		//return -0.00004211*(systemOutput *systemOutput) + 1.06954219*systemOutput + 269.44442;
	}
	
	/**
	 * Get the cost of installation for a system
	 * @return current flat install rate of $1000
	 */
	public static double calculateInstallCost() {
		return Double.valueOf(moneyDecFormat.format(installCost));
	}
	
	public static double calculateTotalPanelCost(SystemConfiguration system) {
		return Double.valueOf(moneyDecFormat.format(calculatePanelCost(system) * system.getPanelCount()));
	}
	
	/**
	 * calculate the cost of a panel in a system
	 * Panel cost is currently calculated at $1/watt
	 * @return the cost of a solar panel given its output
	 */
	private static double calculatePanelCost(SystemConfiguration system) {
		return system.getPanelOutput();
	}
	

}
