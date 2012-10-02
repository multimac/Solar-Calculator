package environmentalSpecifications;

import solarPowerCalculator.CalculatorException;;

/**
 *  SystemConfiguration class specifies all details about the physical set-up of
 *  a solar panel system
 * @author Brendon
 *
 */
public class SystemConfiguration {
	
	// Class Variables
	private int panelCount; // Whole Number
	private int panelOutput; //  W 
	private double inverterEfficiency; // Percentage
	
	/**
	 *  Initialises a new instance of SystemConfiguration
	 * @param panelOutput - The raw output of the panel in W
	 * @param panelCount - The number of panels in the configuration
	 * @param inverterEfficiency - Inverter efficiency 0-1
	 */
	public SystemConfiguration (int panelOutput, int panelCount, double inverterEfficiency) throws CalculatorException {
		if (panelCount <= 0)
			throw new CalculatorException ("Panel count should be greater than 0");
		else
			this.panelCount = panelCount;
		
		if (panelOutput <= 0)
			throw new CalculatorException ("Panel output should be greater than 0");
		else
			this.panelOutput = panelOutput;
		
		if (inverterEfficiency <= 0.0)
			throw new CalculatorException ("Inverter efficiency should be greater than 0");
		else if (inverterEfficiency > 1.0)
			throw new CalculatorException ("Inverter efficiency should be less than than 1");
		else
			this.inverterEfficiency = inverterEfficiency;
	}
	
	/**
	 * gets the total number of panels in the system
	 * @return the total number of panels in the system
	 */
	public int getPanelCount () {
		return panelCount;
	}
	
	/**
	 * Gets the output of a single solar panel in the system
	 * @return The specified panel output in W
	 */
	public int getPanelOutput () {
		return panelOutput;
	}
	
	
	/**
	 * Gets the efficiency of the inverter
	 * @return efficiency of the inverter normalised to 0-1
	 */
	public double getInverterEfficiency() {
		return inverterEfficiency;
	}
	
}
