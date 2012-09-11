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
	int defaultOutput = 250; //Wh
	int defaultPanelCount = 2; //Amount
	double defaultInverter = 0.96; //Efficiency
	
	SystemConfiguration system;

	@Before
	public void initWithRegularCountAndOutput() throws CalculatorException {
		system = new SystemConfiguration(defaultOutput, defaultPanelCount, defaultInverter);
	}
	
	
	//Test Panels
	@Test (expected=CalculatorException.class)
	public void initWithNegativePanels() throws CalculatorException {
		SystemConfiguration system = new SystemConfiguration(defaultOutput, -5, defaultInverter);
	}
	
	@Test public void getPanelCountTest() throws CalculatorException{
		assertEquals(system.getPanelCount(), defaultPanelCount);
	}
	
	@Test public void getPanelOutputTest() throws CalculatorException{
		assertEquals(system.getPanelOutput(), defaultOutput);
	}
	
	@Test public void multiSystemGetPanelCount() throws CalculatorException {
		SystemConfiguration systemTwo = new SystemConfiguration(300, 3, 0.95);
		assertEquals(system.getPanelCount(), defaultPanelCount);
		assertEquals(systemTwo.getPanelCount(), 3);
	}
	
	
	//Test Output
	@Test (expected=CalculatorException.class)
	public void initWithNegativeOutput() throws CalculatorException {
		SystemConfiguration system = new SystemConfiguration(-200, defaultPanelCount, defaultInverter);
	}
	
	@Test public void multiSystemGetOutput() throws CalculatorException {
		SystemConfiguration systemTwo = new SystemConfiguration(300, 3, 0.95);
		assertEquals(system.getPanelOutput(), defaultOutput);
		assertEquals(systemTwo.getPanelOutput(), 300);
	}
	
	
	//Test Inverter
	@Test (expected=CalculatorException.class)
	public void initWithNegativeInverter() throws CalculatorException {
		SystemConfiguration system = new SystemConfiguration(defaultOutput, defaultPanelCount, -2.0);
	}
	
	@Test (expected=CalculatorException.class)
	public void initWithGreaterInverter() throws CalculatorException {
		SystemConfiguration system = new SystemConfiguration(defaultOutput, defaultPanelCount, 5);
	}
	
	

}
