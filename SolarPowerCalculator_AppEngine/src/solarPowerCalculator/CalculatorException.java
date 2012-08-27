package solarPowerCalculator;

/**
 * Class for displaying of errors occuring within the SolarPanelCalculator
 * 
 * @author Brendon Park
 * 
 */
@SuppressWarnings("serial") // We're not interested in binary i/o here
public class CalculatorException extends Exception {
	
	/**
	 * Creates a new instance of CalculatorException.
	 * 
	 * @param message supply a message about the problem
	 */
	public CalculatorException(String message) {
		super("Solar Power Calculator Exception: " + message);
	}
}
