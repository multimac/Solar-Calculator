package environmentalSpecifications;

import solarPowerCalculator.CalculatorException;;

/**
 *  SystemConfiguration class specifies all details about the physical set-up of
 *  a solar panel system
 * @author Glen-Andrew
 *
 */
public class SystemConfiguration {
	
	// Class Variables
	private int panelCount; // Whole Number
	private int panelOutput; //  W 
	private double inverterEfficiency; // Percentage
	private int panelDensity; // W per sq. meter
	private double panelEfficiency; // Percentage
	private double panelDegradation; // Percentage p.a.
	private double tempCoefficient; // Efficiency change per degrees C change
	
	
	
	
	/**
	 *  Initialises a new instance of SystemConfiguration
	 * @param panelOutput - The raw output of the panel in W
	 * @param panelCount - The number of panels in the configuration
	 * @param inverterEfficiency - Inverter efficiency 0-1
	 */
	public SystemConfiguration (int panelCount, int panelOutput, double inverterEfficiency, int panelDensity,
			double panelEfficiency, double panelDegradation, double tempCoefficient) throws CalculatorException {
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
		if (panelEfficiency <= 0.0)
			throw new CalculatorException ("Panel efficiency should be greater than 0");
		else if (panelEfficiency > 1.0)
			throw new CalculatorException ("Panel efficiency should be less than than 1");
		else
			this.panelEfficiency = panelEfficiency;
		if (panelDegradation < 0.0)
			throw new CalculatorException ("Panel degradation should be greater than 0");
		else if (panelDegradation > 0.04)
			throw new CalculatorException ("Panel degradation should be less than than 0.04");
		else
			this.panelDegradation = panelDegradation;
		if (tempCoefficient > -0.001 || tempCoefficient < -0.01)
			throw new CalculatorException ("Temprature Coefficient should be between -0.1 and -1");
		else
			this.tempCoefficient = tempCoefficient;
		if (panelDensity > 200 || panelDensity < 50)
			throw new CalculatorException ("panelDensity should not be above 200W or below 50W per square meter");
		else 
			this.panelDensity = panelDensity;
		
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
	 * Gets the panel density of the solar panels
	 * @return panel density of W per square meter
	 */
	public int getPanelDensity () {
		return panelDensity;
	}
	
	/**
	 * Gets the panel efficiency
	 * @return panel efficiency as percentage
	 */
	public double getPanelEfficiency () {
		return panelEfficiency;
	}
	
	/**
	 * Gets the panel degradation
	 * @return panel degradation as percentage per year
	 */
	public double getPanelDegradation () {
		return panelDegradation;
	}
	
	/**
	 * Get the temperature coefficient
	 * @return temperature coefficient expressed as change to efficiency per 1 degree C change in temperature
	 */
	public double getTempCoefficient () {
		return tempCoefficient;
	}
	
	
	/**
	 * Gets the efficiency of the inverter
	 * @return efficiency of the inverter normalised to 0-1
	 */
	public double getInverterEfficiency() {
		return inverterEfficiency;
	}

	
}
