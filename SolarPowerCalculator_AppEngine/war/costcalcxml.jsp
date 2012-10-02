<?xml version="1.0" ?><%@ page contentType="text/xml;charset=ISO-8859-1" %><%@ page import="powerCalculations.SolarOutput" %><%@ page import="environmentalSpecifications.LocationDetails"%><%@ page import="environmentalSpecifications.SystemConfiguration"%><%@ page import="validation.Validator"%><%
//Process input
double cost = 0;

//Default values, store in database instead
int numpanels = 2;
double daylighthours = 4.5;
int monthlyconsumption = 540;
int paneloutput = 250;
double panelefficiency = 100;
double inverterefficiency = 0.96;

String error = "noerror";
boolean valid = false;

//Validate all input

if (!Validator.IsInteger(request.getParameter("numpanels"))) {
	error = "Number of panels must be a whole number.";
}
else if (!Validator.IsInteger(request.getParameter("paneloutput"))) {
	error = "Panel Output must be a whole number.";
}
else {

	numpanels = Integer.parseInt(request.getParameter("numpanels"));
	paneloutput = Integer.parseInt(request.getParameter("paneloutput"));
	
	//Create a system, and calculate cost
	SystemConfiguration system = new SystemConfiguration(paneloutput, numpanels, inverterefficiency);
	
	cost = SolarOutput.calculateSystemCost(system);
	
	//Round output values
	cost = Math.round(cost * 100.0) / 100.0;

}

%><solorcalculator><cost><%out.print(cost);%></cost><error><%out.print(error);%></error></solorcalculator>