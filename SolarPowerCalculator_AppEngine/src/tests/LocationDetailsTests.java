package tests;

import static org.junit.Assert.*;

import org.junit.Test;

import environmentalSpecifications.LocationDetails;
import solarPowerCalculator.CalculatorException;

/**
 * Tests for the LocationDetails Class
 * @author Brendon
 *
 */
@SuppressWarnings("unused")
public class LocationDetailsTests {

	@Test
	public void initWithGoodTime() throws CalculatorException {
		LocationDetails testLocation = new LocationDetails(5);
	}	

	@Test (expected=CalculatorException.class)
	public void initWitTimeGreaterThan24Hours()  throws CalculatorException {
		LocationDetails testLocation = new LocationDetails(60);
	}
	
	@Test (expected=CalculatorException.class)
	public void initWithTimeLessThan24Hours()  throws CalculatorException {
		LocationDetails testLocation = new LocationDetails(-5);
		assertEquals(testLocation.getDaylightHours(), -5);
	}

}
