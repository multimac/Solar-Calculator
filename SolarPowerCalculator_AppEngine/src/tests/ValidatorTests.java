package tests;

import static org.junit.Assert.*;

import org.junit.Test;

import validation.Validator;

public class ValidatorTests {
	
	String ValidInteger = "1337";
	String InValidInteger = "I am an integer, for serious";
	String ValidDouble = "3.1415926535897932384626433832795";
	String InValidDouble = "mmm.pie";
	String ValidIntWithDecimal = "1.0";

	@Test
	public void testIsIntegerTrue() {
		assertEquals(true, Validator.IsInteger(ValidInteger));
	}
	
	@Test
	public void testIsIntegerFalse() {
		assertEquals(false, Validator.IsInteger(InValidInteger));
	}

	@Test
	public void testIsDoubleTrue() {
		assertEquals(true, Validator.IsDouble(ValidDouble));
	}
	
	@Test
	public void testIsDoubleFalse() {
		assertEquals(false, Validator.IsDouble(InValidDouble));
	}
	
	@Test
	public void testIntWithDecimal() {
		assertEquals(true, Validator.IsInteger(ValidIntWithDecimal));
	}
}
