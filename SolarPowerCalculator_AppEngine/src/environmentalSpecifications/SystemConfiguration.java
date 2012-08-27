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
	private int panelOutput; //  Wh
	
	private static double inverterEfficiency = 0.96;
	
	/**
	 *  Initializes a new instance of SystemConfiguration
	 * @param panelOutput - The raw output of the panel in Wh
	 * @param panelCount - The number of panels in the configuration
	 */
	public SystemConfiguration (int panelOutput, int panelCount) throws CalculatorException {
		
		if (panelCount <= 0)
			throw new CalculatorException ("Panel count should be greater than 0");
		else
			this.panelCount = panelCount;
		
		if (panelOutput <= 0)
			throw new CalculatorException ("Panel output should be greater than 0");
		else
			this.panelOutput = panelOutput;
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
	 * @return The specified panel output in Wh
	 */
	public int getPanelOutput () {
		return panelOutput;
	}
	
	
	/**
	 * Gets the efficiency of the inverter
	 * @return efficiency of the inverter
	 */
	public double getInverterEfficiency() {
		
		return inverterEfficiency;
		
	}
	
}
