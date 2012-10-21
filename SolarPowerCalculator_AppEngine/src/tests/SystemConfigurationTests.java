package tests;

import static org.junit.Assert.*;

import org.junit.Before;
import org.junit.Test;

import environmentalSpecifications.SystemConfiguration;

import solarPowerCalculator.CalculatorException;

/**
 * Testing for the SystemConfiguration Class
 * @author Glen-Andrew
 *
 */
@SuppressWarnings("unused")
public class SystemConfigurationTests {

	//Class Variables
	int defaultPanelCount = 2; //Amount
	int defaultPanelOutput = 250; //Wh
	double defaultInverterEfficiency = 0.96; //Efficiency
	int defaultPanelDensity = 130; // W
	double defaultPanelEfficiency = 0.14; //
	double defaultPanelDegradation = 0.04; // per annum
	double defaultTempCoefficient = -0.005; // per degree celsius
	
	
	SystemConfiguration system;

	@Test
	public void testNormalValues() throws CalculatorException {
		 SystemConfiguration testSystem = new SystemConfiguration(defaultPanelCount, defaultPanelOutput, defaultInverterEfficiency, defaultPanelDensity, defaultPanelEfficiency, defaultPanelDegradation, defaultTempCoefficient);
	}
	
	@Test (expected=CalculatorException.class)
	public void testPanelCountZero() throws CalculatorException {
		 SystemConfiguration testSystem = new SystemConfiguration(0, defaultPanelOutput, defaultInverterEfficiency, defaultPanelDensity, defaultPanelEfficiency, defaultPanelDegradation, defaultTempCoefficient);
	}
	
	@Test (expected=CalculatorException.class)
	public void testPanelCountNegative() throws CalculatorException {
		 SystemConfiguration testSystem = new SystemConfiguration(-1, defaultPanelOutput, defaultInverterEfficiency, defaultPanelDensity, defaultPanelEfficiency, defaultPanelDegradation, defaultTempCoefficient);
	}
	
	@Test (expected=CalculatorException.class)
	public void testPanelOutputZero() throws CalculatorException {
		 SystemConfiguration testSystem = new SystemConfiguration(defaultPanelCount, 0, defaultInverterEfficiency, defaultPanelDensity, defaultPanelEfficiency, defaultPanelDegradation, defaultTempCoefficient);
	}
	
	@Test (expected=CalculatorException.class)
	public void testPanelOutputNegative() throws CalculatorException {
		 SystemConfiguration testSystem = new SystemConfiguration(defaultPanelCount, -1, defaultInverterEfficiency, defaultPanelDensity, defaultPanelEfficiency, defaultPanelDegradation, defaultTempCoefficient);
	}
	
	@Test (expected=CalculatorException.class)
	public void testInverterEfficiencyZero() throws CalculatorException {
		 SystemConfiguration testSystem = new SystemConfiguration(defaultPanelCount, defaultPanelOutput, 0, defaultPanelDensity, defaultPanelEfficiency, defaultPanelDegradation, defaultTempCoefficient);
	}
	
	@Test (expected=CalculatorException.class)
	public void testInverterEfficiencyNegative() throws CalculatorException {
		 SystemConfiguration testSystem = new SystemConfiguration(defaultPanelCount, defaultPanelOutput, -1, defaultPanelDensity, defaultPanelEfficiency, defaultPanelDegradation, defaultTempCoefficient);
	}
	
	@Test 
	public void testInverterEfficiencyOne() throws CalculatorException {
		 SystemConfiguration testSystem = new SystemConfiguration(defaultPanelCount, defaultPanelOutput, 1, defaultPanelDensity, defaultPanelEfficiency, defaultPanelDegradation, defaultTempCoefficient);
	}
	
	@Test (expected=CalculatorException.class)
	public void testInverterEfficiencyAboveOne() throws CalculatorException {
		 SystemConfiguration testSystem = new SystemConfiguration(defaultPanelCount, defaultPanelOutput, 2, defaultPanelDensity, defaultPanelEfficiency, defaultPanelDegradation, defaultTempCoefficient);
	}
	
	@Test (expected=CalculatorException.class)
	public void testPanelDensityBelow50() throws CalculatorException {
		 SystemConfiguration testSystem = new SystemConfiguration(defaultPanelCount, defaultPanelOutput, defaultInverterEfficiency, 49, defaultPanelEfficiency, defaultPanelDegradation, defaultTempCoefficient);
	}
	
	@Test (expected=CalculatorException.class)
	public void testPanelDensityAbove200() throws CalculatorException {
		 SystemConfiguration testSystem = new SystemConfiguration(defaultPanelCount, defaultPanelOutput, defaultInverterEfficiency, 201, defaultPanelEfficiency, defaultPanelDegradation, defaultTempCoefficient);
	}
	
	@Test 
	public void testPanelDensity50() throws CalculatorException {
		 SystemConfiguration testSystem = new SystemConfiguration(defaultPanelCount, defaultPanelOutput, defaultInverterEfficiency, 50, defaultPanelEfficiency, defaultPanelDegradation, defaultTempCoefficient);
	}
	
	@Test 
	public void testPanelDensity200() throws CalculatorException {
		 SystemConfiguration testSystem = new SystemConfiguration(defaultPanelCount, defaultPanelOutput, defaultInverterEfficiency, 200, defaultPanelEfficiency, defaultPanelDegradation, defaultTempCoefficient);
	}
	
	@Test (expected=CalculatorException.class)
	public void testPanelEfficiencyZero() throws CalculatorException {
		 SystemConfiguration testSystem = new SystemConfiguration(defaultPanelCount, defaultPanelOutput, defaultInverterEfficiency, defaultPanelDensity, 0, defaultPanelDegradation, defaultTempCoefficient);
	}
	
	@Test (expected=CalculatorException.class)
	public void testPanelEfficiencyBelowZero() throws CalculatorException {
		 SystemConfiguration testSystem = new SystemConfiguration(defaultPanelCount, defaultPanelOutput, defaultInverterEfficiency, defaultPanelDensity, -1, defaultPanelDegradation, defaultTempCoefficient);
	}
	
	@Test 
	public void testPanelEfficiencyOne() throws CalculatorException {
		 SystemConfiguration testSystem = new SystemConfiguration(defaultPanelCount, defaultPanelOutput, defaultInverterEfficiency, defaultPanelDensity, 1, defaultPanelDegradation, defaultTempCoefficient);
	}
	
	@Test (expected=CalculatorException.class)
	public void testPanelEfficiencyAboveOne() throws CalculatorException {
		 SystemConfiguration testSystem = new SystemConfiguration(defaultPanelCount, defaultPanelOutput, defaultInverterEfficiency, defaultPanelDensity, 2, defaultPanelDegradation, defaultTempCoefficient);
	}
	
	@Test 
	public void testDegradationZero() throws CalculatorException {
		 SystemConfiguration testSystem = new SystemConfiguration(defaultPanelCount, defaultPanelOutput, defaultInverterEfficiency, defaultPanelDensity, defaultPanelEfficiency, 0, defaultTempCoefficient);
	}
	
	@Test (expected=CalculatorException.class)
	public void testPanelDegradationNegative() throws CalculatorException {
		 SystemConfiguration testSystem = new SystemConfiguration(defaultPanelCount, defaultPanelOutput, defaultInverterEfficiency, defaultPanelDensity, defaultPanelEfficiency, -1, defaultTempCoefficient);
	}
	
	@Test 
	public void testPanelDegradationUpperLimit() throws CalculatorException {
		 SystemConfiguration testSystem = new SystemConfiguration(defaultPanelCount, defaultPanelOutput, defaultInverterEfficiency, defaultPanelDensity, defaultPanelEfficiency, 0.04, defaultTempCoefficient);
	}
	
	@Test (expected=CalculatorException.class)
	public void testPanelDegradationAboveLimit() throws CalculatorException {
		 SystemConfiguration testSystem = new SystemConfiguration(defaultPanelCount, defaultPanelOutput, defaultInverterEfficiency, defaultPanelDensity, defaultPanelEfficiency, 0.08, defaultTempCoefficient);
	}
	
	@Test (expected=CalculatorException.class)
	public void testTempCoefficientPositive() throws CalculatorException {
		 SystemConfiguration testSystem = new SystemConfiguration(defaultPanelCount, defaultPanelOutput, defaultInverterEfficiency, defaultPanelDensity, defaultPanelEfficiency, defaultPanelDegradation, 0.01);
	}
	
	@Test (expected=CalculatorException.class)
	public void testTempCoefficientZero() throws CalculatorException {
		 SystemConfiguration testSystem = new SystemConfiguration(defaultPanelCount, defaultPanelOutput, defaultInverterEfficiency, defaultPanelDensity, defaultPanelEfficiency, defaultPanelDegradation, 0);
	}
	
	@Test 
	public void testTempCoefficientLowerLimit() throws CalculatorException {
		 SystemConfiguration testSystem = new SystemConfiguration(defaultPanelCount, defaultPanelOutput, defaultInverterEfficiency, defaultPanelDensity, defaultPanelEfficiency, defaultPanelDegradation, -0.01);
	}
	
	@Test (expected=CalculatorException.class)
	public void testTempCoefficientBelowLimit() throws CalculatorException {
		 SystemConfiguration testSystem = new SystemConfiguration(defaultPanelCount, defaultPanelOutput, defaultInverterEfficiency, defaultPanelDensity, defaultPanelEfficiency, defaultPanelDegradation, -0.02);
	}
	
	@Test 
	public void testTempCoefficientUpperLimit() throws CalculatorException {
		 SystemConfiguration testSystem = new SystemConfiguration(defaultPanelCount, defaultPanelOutput, defaultInverterEfficiency, defaultPanelDensity, defaultPanelEfficiency, defaultPanelDegradation, -0.001);
	}
	
	@Test (expected=CalculatorException.class)
	public void testTempCoefficientAboveLimit() throws CalculatorException {
		 SystemConfiguration testSystem = new SystemConfiguration(defaultPanelCount, defaultPanelOutput, defaultInverterEfficiency, defaultPanelDensity, defaultPanelEfficiency, defaultPanelDegradation, -0.0009);
	}

}
