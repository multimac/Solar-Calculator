package tests;

import static org.junit.Assert.*;

import org.junit.Before;
import org.junit.Test;

import solarPowerCalculator.CalculatorException;
import powerCalculations.SolarOutput;
import environmentalSpecifications.*;


/**
 * Test Cases for the Solar Output Class
 * @author Brendon
 *
 */
public class SolarOutputTests {

	private SystemConfiguration testSystem;
	private LocationDetails testLocation;
	private double delta = 0;

	@Before
	public void initObjects() throws CalculatorException {
		testSystem = new SystemConfiguration(250, 2, 0.96);
		testLocation = new LocationDetails(4.5, 300);
	}
	
	@Test public void calculateHourlyOutputStandardValues() {
		assertEquals(480, SolarOutput.calculateHourlyOutput(testSystem), delta);
	}
	
	@Test public void calculateDailyOutputStandardValues() {
		assertEquals(2160, SolarOutput.calculateGrossDailyOutput(testLocation, testSystem), delta);
	}
	
	@Test public void calculateMonthlyOutputStandardValues() {
		assertEquals(64800, SolarOutput.calculateMonthlyOutput(testLocation, testSystem), delta);
	}
	
	

}
