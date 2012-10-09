<?xml version="1.0" ?><%@ page contentType="text/xml;charset=ISO-8859-1" %><%@ page import="powerCalculations.SolarOutput" %><%@ page import="environmentalSpecifications.LocationDetails"%><%@ page import="environmentalSpecifications.SystemConfiguration"%><%@ page import="validation.Validator"%><%
//Process input
double grossOutput = 0;//placeholder value
double netOutput = 0;//placeholder value
double cost = 0;
double revenue = 0;
String breakEven = "";

//Default values, store in database instead
int numpanels = 2;
double daylighthours = 4.5;
double monthlyconsumption = 18;
int paneloutput = 250;
double panelefficiency = 100;
double inverterefficiency = 0.96;
double exportrate = 0.08;

String error = "noerror";
boolean valid = false;

//Validate all input

if (!Validator.IsInteger(request.getParameter("numpanels"))) {
	error = "Number of panels must be a whole number.";
}
else if (!Validator.IsDouble(request.getParameter("daylighthours"))) {
	error = "Daylight Hours must be valid number.";
}
else if (!Validator.IsDouble(request.getParameter("monthlyconsumption"))) {
	error = "Monthly Consumption must be a valid number.";
}
else if (!Validator.IsInteger(request.getParameter("paneloutput"))) {
	error = "Panel Output must be a whole number.";
}
else if (!Validator.IsDouble(request.getParameter("panelefficiency"))) {
	error = "Panel Degredation must be a valid number.";
}
else if (!Validator.IsDouble(request.getParameter("inverterefficiency"))) {
	error = "Inverter Efficiency must be a valid number.";
}
else if (!Validator.IsDouble(request.getParameter("exportrate"))) {
	error = "Export Rate must be a valid number." + request.getParameter("exportrate");
}
else {
	numpanels = Integer.parseInt(request.getParameter("numpanels"));
	daylighthours = Double.parseDouble(request.getParameter("daylighthours"));
	monthlyconsumption = Double.parseDouble(request.getParameter("monthlyconsumption"));
	paneloutput = Integer.parseInt(request.getParameter("paneloutput"));
	panelefficiency = Double.parseDouble(request.getParameter("panelefficiency"));
	inverterefficiency = Double.parseDouble(request.getParameter("inverterefficiency")) * 0.01;
	exportrate = Double.parseDouble(request.getParameter("exportrate"));

	//Create a system, and calculate output
	LocationDetails location = new LocationDetails(daylighthours, monthlyconsumption, exportrate);
	SystemConfiguration system = new SystemConfiguration(paneloutput, numpanels, inverterefficiency);
	
	grossOutput = SolarOutput.calculateGrossDailyOutput(location, system);
	netOutput = SolarOutput.calculateNetDailyOutput(location, system);
	cost = SolarOutput.calculateSystemCost(system);
	revenue = SolarOutput.calculateMonthlyOutputValue(system, location);
	breakEven = SolarOutput.calculateBreakEven(system, location);
	
	//Round to 2 decimal places
	grossOutput = Math.round(grossOutput*100.0)/100.0;
	netOutput = Math.round(netOutput*100.0)/100.0;
	cost = Math.round(cost * 100.0) / 100.0;
}

%><solarcalculator><grossoutput><%out.print(grossOutput);%></grossoutput><netoutput><%out.print(netOutput);%></netoutput><cost><%out.print(cost);%></cost><revenue><%out.print(revenue);%></revenue><breakeven><%out.print(breakEven);%></breakeven><error><%out.print(error);%></error></solarcalculator>