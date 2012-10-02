package tests;

import static org.junit.Assert.*;

import org.junit.Test;

import environmentalSpecifications.LocationDetails;
import solarPowerCalculator.CalculatorException;

/**
 * Tests for the LocationDetails Class
 *
 */
@SuppressWarnings("unused")
public class LocationDetailsTests {

	//Test dayLightHours
	
	@Test
	public void initWithGoodDayLightHours() throws CalculatorException {
		LocationDetails testLocation = new LocationDetails(5, 0);
	}

	@Test (expected=CalculatorException.class)
	public void initWithGoodDayLightHoursGreaterThan24()  throws CalculatorException {
		LocationDetails testLocation = new LocationDetails(60, 1);
	}
	
	@Test (expected=CalculatorException.class)
	public void initWithTimeLessThanZeroHours()  throws CalculatorException {
		LocationDetails testLocation = new LocationDetails(-5.0, 0);
		assertEquals(testLocation.getDaylightHours(), -5.0, 0);
	}
	
	
	//Test Monthly Consumption
	
	@Test
	public void initWithSafeConsumption() throws CalculatorException {
		LocationDetails testLocation = new LocationDetails(0, 300);
	}

	@Test (expected=CalculatorException.class)
	public void initWithConsumptionLessThanZero()  throws CalculatorException {
		LocationDetails testLocation = new LocationDetails(0, -20);
	}
	
	

}
