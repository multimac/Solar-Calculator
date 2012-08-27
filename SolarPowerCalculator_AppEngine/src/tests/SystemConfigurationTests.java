package tests;

import static org.junit.Assert.*;

import org.junit.Before;
import org.junit.Test;

import environmentalSpecifications.SystemConfiguration;

import solarPowerCalculator.CalculatorException;

/**
 * Testing for the SystemConfiguration Class
 * @author Brendon
 *
 */
@SuppressWarnings("unused")
public class SystemConfigurationTests {

	//Class Variables
	int defaultOutput = 200; //Wh
	int defaultPanelCount = 5; //Amount
	SystemConfiguration system;

	@Before
	public void initWithRegularCountAndOutput() throws CalculatorException {
		system = new SystemConfiguration(defaultOutput, defaultPanelCount);
	}
	
	@Test (expected=CalculatorException.class)
	public void initWithNegativePanels() throws CalculatorException {
		SystemConfiguration system = new SystemConfiguration(200,-5);
	}
	
	@Test (expected=CalculatorException.class)
	public void initWithNegativeOutput() throws CalculatorException {
		SystemConfiguration system = new SystemConfiguration(-200,5);
	}
	
	@Test public void getPanelCountTest() throws CalculatorException{
		assertEquals(system.getPanelCount(), defaultPanelCount);
	}
	
	@Test public void getPanelOutputTest() throws CalculatorException{
		assertEquals(system.getPanelOutput(), defaultOutput);
	}
	
	
	@Test public void multiSystemGetOutput() throws CalculatorException {
		SystemConfiguration systemTwo = new SystemConfiguration(250, 3);
		assertEquals(system.getPanelOutput(), defaultOutput);
		assertEquals(systemTwo.getPanelOutput(), 250);
	}
	
	@Test public void multiSystemGetPanelCount() throws CalculatorException {
		SystemConfiguration systemTwo = new SystemConfiguration(250, 3);
		assertEquals(system.getPanelCount(), defaultPanelCount);
		assertEquals(systemTwo.getPanelCount(), 3);
	}
	

}
