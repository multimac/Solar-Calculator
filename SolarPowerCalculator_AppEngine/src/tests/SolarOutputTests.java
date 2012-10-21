package tests;

import static org.junit.Assert.*;

import org.junit.Before;
import org.junit.Test;

import solarPowerCalculator.CalculatorException;
import powerCalculations.SolarOutput;
import environmentalSpecifications.*;


/**
 * Test Cases for the Solar Output Class
 * @author Glen-Andrew
 *
 */
public class SolarOutputTests {

	private double delta = 0.01;
	private double smallDelta = 0.0001;
	private SystemConfiguration testSystem;
	private LocationDetails testLocation;

	

	
	@Test public void calculateSystemRating() throws CalculatorException {
		testSystem = new SystemConfiguration(2, 250, 0.96, 130, 0.14, 0.004, -0.005);
		assertEquals(480, SolarOutput.calculateSystemRating(testSystem), delta);
	}
	
	@Test public void calculatePanelArea() throws CalculatorException {
		testSystem = new SystemConfiguration(2, 250, 0.96, 130, 0.14, 0.004, -0.005);
		assertEquals(3.85, SolarOutput.calculatePanelArea(testSystem), delta);
	}
	
	@Test public void calculateSolarExposureWinter() throws CalculatorException {
		testSystem = new SystemConfiguration(2, 250, 0.96, 130, 0.14, 0.004, -0.005);
		testLocation = new LocationDetails(7.5, 8.5, 550, 650, 0.14, 0.24, 35, 45, 4.5, 5.5);
		assertEquals(8.65, SolarOutput.calculateSolarExposureWinter(testSystem, testLocation), delta);
	}
	
	@Test public void calculateSolarExposureSummer() throws CalculatorException {
		testSystem = new SystemConfiguration(2, 250, 0.96, 130, 0.14, 0.004, -0.005);
		testLocation = new LocationDetails(7.5, 8.5, 550, 650, 0.14, 0.24, 35, 45, 4.5, 5.5);
		assertEquals(10.58, SolarOutput.calculateSolarExposureSummer(testSystem, testLocation), delta);
	}
	
	@Test public void calculatePanelEfficiencyWinterFirstYear() throws CalculatorException {
		testSystem = new SystemConfiguration(2, 250, 0.96, 130, 0.14, 0.004, -0.005);
		testLocation = new LocationDetails(7.5, 8.5, 550, 650, 0.14, 0.24, 35, 45, 4.5, 5.5);
		assertEquals(0.09, SolarOutput.calculatePanelEfficiencyWinter(testSystem, testLocation, 0), smallDelta);
	}
	
	@Test public void calculatePanelEfficiencyWinterSecondYear() throws CalculatorException {
		testSystem = new SystemConfiguration(2, 250, 0.96, 130, 0.14, 0.004, -0.005);
		testLocation = new LocationDetails(7.5, 8.5, 550, 650, 0.14, 0.24, 35, 45, 4.5, 5.5);
		assertEquals(0.0896, SolarOutput.calculatePanelEfficiencyWinter(testSystem, testLocation, 1), smallDelta);
	}
	
	@Test public void calculatePanelEfficiencyWinterThirdYear() throws CalculatorException {
		testSystem = new SystemConfiguration(2, 250, 0.96, 130, 0.14, 0.004, -0.005);
		testLocation = new LocationDetails(7.5, 8.5, 550, 650, 0.14, 0.24, 35, 45, 4.5, 5.5);
		assertEquals(0.0893, SolarOutput.calculatePanelEfficiencyWinter(testSystem, testLocation, 2), smallDelta);
	}
	
	@Test public void calculatePanelEfficiencySummerFirstYear() throws CalculatorException {
		testSystem = new SystemConfiguration(2, 250, 0.96, 130, 0.14, 0.004, -0.005);
		testLocation = new LocationDetails(7.5, 8.5, 550, 650, 0.14, 0.24, 35, 45, 4.5, 5.5);
		assertEquals(0.04, SolarOutput.calculatePanelEfficiencySummer(testSystem, testLocation, 0), smallDelta);
	}
	
	@Test public void calculatePanelEfficiencySummerSecondYear() throws CalculatorException {
		testSystem = new SystemConfiguration(2, 250, 0.96, 130, 0.14, 0.004, -0.005);
		testLocation = new LocationDetails(7.5, 8.5, 550, 650, 0.14, 0.24, 35, 45, 4.5, 5.5);
		assertEquals(0.0398, SolarOutput.calculatePanelEfficiencySummer(testSystem, testLocation, 1), smallDelta);
	}
	
	@Test public void calculatePanelEfficiencySummerThridYear() throws CalculatorException {
		testSystem = new SystemConfiguration(2, 250, 0.96, 130, 0.14, 0.004, -0.005);
		testLocation = new LocationDetails(7.5, 8.5, 550, 650, 0.14, 0.24, 35, 45, 4.5, 5.5);
		assertEquals(0.0397, SolarOutput.calculatePanelEfficiencySummer(testSystem, testLocation, 2), smallDelta);
	}
	
	@Test public void calculateMonthlyWinterOutputBelowSystemMax() throws CalculatorException {
		testSystem = new SystemConfiguration(2, 250, 0.96, 130, 0.14, 0.004, -0.005);
		testLocation = new LocationDetails(7.5, 8.5, 550, 650, 0.14, 0.24, 35, 45, 4.5, 5.5);
		assertEquals(23.70, SolarOutput.calculateMonthlyWinterOutput(testSystem, testLocation, 0), delta);
	}
	
	@Test public void calculateMonthlyWinterOutputSystemMax() throws CalculatorException {
		testSystem = new SystemConfiguration(2, 250, 0.96, 130, 0.14, 0.004, -0.005);
		testLocation = new LocationDetails(1, 1, 550, 650, 0.14, 0.24, 35, 45, 4.5, 5.5);
		assertEquals(7.31, SolarOutput.calculateMonthlyWinterOutput(testSystem, testLocation, 0), delta);
	}
	
	@Test public void calculateMonthlyWinterOutputSystemMaxAfterOneYear() throws CalculatorException {
		testSystem = new SystemConfiguration(2, 250, 0.96, 130, 0.14, 0.004, -0.005);
		testLocation = new LocationDetails(1, 1, 550, 650, 0.14, 0.24, 35, 45, 4.5, 5.5);
		assertEquals(7.28, SolarOutput.calculateMonthlyWinterOutput(testSystem, testLocation, 1), delta);
	}
	
	@Test public void calculateMonthlySummerOutputBelowSystemMax() throws CalculatorException {
		testSystem = new SystemConfiguration(2, 250, 0.96, 130, 0.14, 0.004, -0.005);
		testLocation = new LocationDetails(7.5, 8.5, 550, 650, 0.14, 0.24, 35, 45, 4.5, 5.5);
		assertEquals(12.88, SolarOutput.calculateMonthlySummerOutput(testSystem, testLocation, 0), delta);
	}
	
	@Test public void calculateMonthlySummerOutputSystemMax() throws CalculatorException {
		testSystem = new SystemConfiguration(2, 250, 0.96, 130, 0.14, 0.004, -0.005);
		testLocation = new LocationDetails(1, 1, 550, 650, 0.14, 0.24, 35, 45, 4.5, 5.5);
		assertEquals(7.31, SolarOutput.calculateMonthlySummerOutput(testSystem, testLocation, 0), delta);
	}
	
	@Test public void calculateMonthlySummerOutputSystemMaxAfterOneYear() throws CalculatorException {
		testSystem = new SystemConfiguration(2, 250, 0.96, 130, 0.14, 0.004, -0.005);
		testLocation = new LocationDetails(1, 1, 550, 650, 0.14, 0.24, 35, 45, 4.5, 5.5);
		assertEquals(7.28, SolarOutput.calculateMonthlySummerOutput(testSystem, testLocation, 1), delta);
	}
	
	@Test public void calculateAverageMonthlyOutput() throws CalculatorException {
		testSystem = new SystemConfiguration(2, 250, 0.96, 130, 0.14, 0.004, -0.005);
		testLocation = new LocationDetails(7.5, 8.5, 550, 650, 0.14, 0.24, 35, 45, 4.5, 5.5);
		assertEquals(18.29, SolarOutput.calculateAverageMonthlyOutput(testSystem, testLocation, 0), delta);
	}
	
	@Test public void calculateMonthlyWinterSavings() throws CalculatorException {
		testSystem = new SystemConfiguration(2, 250, 0.96, 130, 0.14, 0.004, -0.005);
		testLocation = new LocationDetails(7.5, 8.5, 550, 650, 0.14, 0.24, 35, 45, 4.5, 5.5);
		assertEquals(5.69, SolarOutput.calculateMonthlyWinterSavings(testSystem, testLocation, 0), delta);
	}
	
	@Test public void calculateMonthlySummerSavings() throws CalculatorException {
		testSystem = new SystemConfiguration(2, 250, 0.96, 130, 0.14, 0.004, -0.005);
		testLocation = new LocationDetails(7.5, 8.5, 550, 650, 0.14, 0.24, 35, 45, 4.5, 5.5);
		assertEquals(3.09, SolarOutput.calculateMonthlySummerSavings(testSystem, testLocation, 0), delta);
	}
	
	@Test public void calculateAverageMonthlySavings() throws CalculatorException {
		testSystem = new SystemConfiguration(2, 250, 0.96, 130, 0.14, 0.004, -0.005);
		testLocation = new LocationDetails(7.5, 8.5, 550, 650, 0.14, 0.24, 35, 45, 4.5, 5.5);
		assertEquals(4.39, SolarOutput.calculateAverageMonthlySavings(testSystem, testLocation, 0), delta);
	}
	
	@Test public void calculateBreakEvenTimeNever() throws CalculatorException {
		testSystem = new SystemConfiguration(2, 250, 0.96, 130, 0.14, 0.004, -0.005);
		testLocation = new LocationDetails(7.5, 8.5, 550, 650, 0.01, 0.01, 35, 45, 4.5, 5.5);
		assertEquals("Never!", SolarOutput.calculateBreakEvenTime(testSystem, testLocation));
	}
	
	@Test public void calculateBreakEvenTime() throws CalculatorException {
		testSystem = new SystemConfiguration(20, 250, 0.96, 130, 0.14, 0.004, -0.005);
		testLocation = new LocationDetails(7.5, 8.5, 550, 650, 0.14, 0.24, 35, 45, 4.5, 5.5);
		assertEquals("22 years, 5 months", SolarOutput.calculateBreakEvenTime(testSystem, testLocation));
	}
	
	
	
	
	
	
	
	
	

}
