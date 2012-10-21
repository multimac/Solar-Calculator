package tests;

import static org.junit.Assert.*;

import org.junit.Test;

import environmentalSpecifications.LocationDetails;
import solarPowerCalculator.CalculatorException;

/**
 * Tests for the LocationDetails Class
 * @author Glen-Andrew
 */
@SuppressWarnings("unused")
public class LocationDetailsTests {

	//Test dayLightHours
	
	@Test (expected=CalculatorException.class)
	public void testDaylightHoursWinterLessThanZero() throws CalculatorException {
		LocationDetails testLocation = new LocationDetails(-2, 5 , 540, 540, 0.14, 0.24, 35, 45, 5, 5);
	}
	
	@Test (expected=CalculatorException.class)
	public void testDaylightHoursWinterGreaterThan24() throws CalculatorException {
		LocationDetails testLocation = new LocationDetails(25, 5 , 540, 540, 0.14, 0.24, 35, 45, 5, 5);
	}
	
	@Test (expected=CalculatorException.class)
	public void testDaylightHoursSummerLessThanZero() throws CalculatorException {
		LocationDetails testLocation = new LocationDetails(5, -1 , 540, 540, 0.14, 0.24, 35, 45, 5, 5);
	}
	
	@Test (expected=CalculatorException.class)
	public void testDaylightHoursSummerGreaterThan24() throws CalculatorException {
		LocationDetails testLocation = new LocationDetails(4, 26 , 540, 540, 0.14, 0.24, 35, 45, 5, 5);
	}

	@Test (expected=CalculatorException.class)
	public void testMonthlyWinterConsumptionLessThanZero() throws CalculatorException {
		LocationDetails testLocation = new LocationDetails(5, 5 , -1, 540, 0.14, 0.24, 35, 45, 5, 5);
	}
	
	@Test (expected=CalculatorException.class)
	public void testMonthlySummerConsumptionLessThanZero() throws CalculatorException {
		LocationDetails testLocation = new LocationDetails(5, 5 , 540, -20, 0.14, 0.24, 35, 45, 5, 5);
	}
	
	@Test (expected=CalculatorException.class)
	public void testExportRateLessThanZero() throws CalculatorException {
		LocationDetails testLocation = new LocationDetails(5, 5 , 540, 540, -0.14, 0.24, 35, 45, 5, 5);
	}
	
	@Test (expected=CalculatorException.class)
	public void testImportRateLessThanZero() throws CalculatorException {
		LocationDetails testLocation = new LocationDetails(5, 5 , 540, 540, 0.14, -0.24, 35, 45, 5, 5);
	}
	
	@Test (expected=CalculatorException.class)
	public void testInsolationWinterLessThanZero() throws CalculatorException {
		LocationDetails testLocation = new LocationDetails(5, 5 , 540, 540, 0.14, 0.24, 35, 45, -5, 5);
	}
	
	@Test (expected=CalculatorException.class)
	public void testInsolationSummerLessThanZero() throws CalculatorException {
		LocationDetails testLocation = new LocationDetails(5, 5 , 540, 540, 0.14, 0.24, 35, 45, 5, -5);
	}
	
	@Test
	public void testEverythingNormal() throws CalculatorException {
		LocationDetails testLocation = new LocationDetails(5, 5 , 540, 540, 0.14, 0.24, 35, 45, 5, 5);
	}
	
	@Test 
	public void testDaylightWinter24() throws CalculatorException {
		LocationDetails testLocation = new LocationDetails(24, 5 , 540, 540, 0.14, 0.24, 35, 45, 5, 5);
	}
	
	@Test 
	public void testDaylightWinterZero() throws CalculatorException {
		LocationDetails testLocation = new LocationDetails(0, 5 , 540, 540, 0.14, 0.24, 35, 45, 5, 5);
	}
	
	@Test 
	public void testDaylightSummer24() throws CalculatorException {
		LocationDetails testLocation = new LocationDetails(5, 24 , 540, 540, 0.14, 0.24, 35, 45, 5, 5);
	}
	
	@Test 
	public void testDaylightSummerZero() throws CalculatorException {
		LocationDetails testLocation = new LocationDetails(5, 0 , 540, 540, 0.14, 0.24, 35, 45, 5, 5);
	}
	
	@Test 
	public void testWinterConsumptionZero() throws CalculatorException {
		LocationDetails testLocation = new LocationDetails(5, 5 , 0, 540, 0.14, 0.24, 35, 45, 5, 5);
	}
	
	@Test 
	public void testSummerConsumptionZero() throws CalculatorException {
		LocationDetails testLocation = new LocationDetails(5, 5 , 540, 0, 0.14, 0.24, 35, 45, 5, 5);
	}
	
	@Test 
	public void testExportZero() throws CalculatorException {
		LocationDetails testLocation = new LocationDetails(5, 5 , 540, 540, 0, 0.24, 35, 45, 5, 5);
	}
	
	@Test 
	public void testImportZero() throws CalculatorException {
		LocationDetails testLocation = new LocationDetails(5, 5 , 540, 540, 0.14, 0, 35, 45, 5, 5);
	}
	
	@Test 
	public void testInsolationWinterZero() throws CalculatorException {
		LocationDetails testLocation = new LocationDetails(5, 5 , 540, 540, 0.14, 0.24, 35, 45, 0, 5);
	}
	
	@Test 
	public void testInsolationSummerZero() throws CalculatorException {
		LocationDetails testLocation = new LocationDetails(5, 5 , 540, 540, 0.14, 0.24, 35, 45, 5, 0);
	}

	
	

}
