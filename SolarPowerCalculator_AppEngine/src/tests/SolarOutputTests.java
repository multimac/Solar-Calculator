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
		testSystem = new SystemConfiguration(200, 5);
		testLocation = new LocationDetails(5);
	}
	
	@Test public void calculatorHourlyOutputStandardValues() {
		assertEquals(SolarOutput.calculateHourlyOutput(testSystem), 0.96, delta);
	}
	
	@Test public void calculateDailyOutputStandardValues() {
		assertEquals(SolarOutput.calculateDailyOutput(testLocation, testSystem), 4.8, delta);
	}
	
	@Test public void calculateMonthlyOutputStandardValues() {
		assertEquals(SolarOutput.calculateMonthlyOutput(testLocation, testSystem), 144, delta);
	}

}
