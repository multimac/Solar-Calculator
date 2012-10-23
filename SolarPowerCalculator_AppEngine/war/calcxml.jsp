<?xml version="1.0" ?><%@ page contentType="text/xml;charset=ISO-8859-1" %><%@ page import="powerCalculations.SolarOutput" %><%@ page import="environmentalSpecifications.LocationDetails"%><%@ page import="environmentalSpecifications.SystemConfiguration"%><%@ page import="validation.Validator"%><%
//Input
//System
int panelcount = 2;
int paneloutput = 250;
int paneldensity = 130;
double panelefficiency = 100;
double paneldegradation= 0.5;
double inverterefficiency = 0.96;
double tempcoefficient = -0.005;

//Environment
double daylighthoursw = 7.4f;
double daylighthourss = 7.5f;
int monthlyconsumptionw = 0;
int monthlyconsumptions = 0;
double exporttariff = 0.14;
double importtariff = 0.25;
int rooftempw = 33;
int rooftemps = 50;
double solarinsolationw = 4.07;
double solarinsolations = 5.85;


//Output
double grossMonthlyOutputW = 0;
double grossMonthlyOutputS = 0; 
	
double monlthySavingsW = 0; 
double monlthySavingsS = 0; 
	
double firstYearOutput = 0;
double firstYearFeedIn = 0;
double firstYearSavings = 0;
	
double systemCost = 0;
double revenue = 0;
String breakEvenTime = ""; 


String error = "noerror";
boolean valid = false;

//Validate all input

if (!Validator.IsInteger(request.getParameter("panelcount"))) {
	error = "Number of panels must be a whole number.";
}
else if (!Validator.IsInteger(request.getParameter("paneloutput"))) {
	error = "Panel Output must be a whole number.";
}
else if (!Validator.IsInteger(request.getParameter("paneldensity"))) {
	error = "Panel Density must be a whole number.";
}
else if (!Validator.IsDouble(request.getParameter("panelefficiency"))) {
	error = "Panel Degredation must be a valid number.";
}
else if (!Validator.IsDouble(request.getParameter("paneldegradation"))) {
	error = "Panel Degradation must be a valid number.";
}
else if (!Validator.IsDouble(request.getParameter("inverterefficiency"))) {
	error = "Inverter Efficiency must be a valid number.";
}
else if (!Validator.IsDouble(request.getParameter("tempcoefficient"))) {
	error = "Temp Coefficient must be a valid number.";
}


else if (!Validator.IsDouble(request.getParameter("daylighthoursw"))) {
	error = "Winter Daylight Hours must be valid number.";
}
else if (!Validator.IsDouble(request.getParameter("daylighthourss"))) {
	error = "Summer Daylight Hours must be valid number.";
}

else if (!Validator.IsInteger(request.getParameter("monthlyconsumptionw"))) {
	error = "Winter MonthlyConsumption must be valid whole number.";
}
else if (!Validator.IsInteger(request.getParameter("monthlyconsumptions"))) {
	error = "Summer Monthly Consumption must be valid whole number.";
}


else if (!Validator.IsDouble(request.getParameter("exporttariff"))) {
	error = "Export Tariff must be a valid number.";
}
else if (!Validator.IsDouble(request.getParameter("importtariff"))) {
	error = "Import Tariff must be a valid number.";
}

else if (!Validator.IsInteger(request.getParameter("rooftempw"))) {
	error = "Winter Roof Temp must be a valid number.";
}
else if (!Validator.IsInteger(request.getParameter("rooftemps"))) {
	error = "Summer Roof Temp must be a valid number.";
}

else if (!Validator.IsDouble(request.getParameter("solarinsolations"))) {
	error = "Winter Solar Insolation must be a valid number.";
}
else if (!Validator.IsDouble(request.getParameter("solarinsolations"))) {
	error = "Summer Solar Insolation must be a valid number.";
}

else {

	
	panelcount = Integer.parseInt(request.getParameter("panelcount"));
	paneloutput = Integer.parseInt(request.getParameter("paneloutput"));
	inverterefficiency = Double.parseDouble(request.getParameter("inverterefficiency"));
	paneldensity = Integer.parseInt(request.getParameter("paneldensity"));
	panelefficiency = Double.parseDouble(request.getParameter("panelefficiency"));
	paneldegradation = Double.parseDouble(request.getParameter("paneldegradation"));
	tempcoefficient = Double.parseDouble(request.getParameter("tempcoefficient"));
	
	
	daylighthoursw = Double.parseDouble(request.getParameter("daylighthoursw"));
	daylighthourss = Double.parseDouble(request.getParameter("daylighthourss"));
	monthlyconsumptionw = Integer.parseInt(request.getParameter("monthlyconsumptionw"));
	monthlyconsumptions = Integer.parseInt(request.getParameter("monthlyconsumptions"));
	exporttariff = Double.parseDouble(request.getParameter("exporttariff"));
	importtariff = Double.parseDouble(request.getParameter("importtariff"));
	rooftempw = Integer.parseInt(request.getParameter("rooftempw"));
	rooftemps = Integer.parseInt(request.getParameter("rooftemps"));
	solarinsolationw = Double.parseDouble(request.getParameter("solarinsolationw"));
	solarinsolations = Double.parseDouble(request.getParameter("solarinsolations"));
	
	
	//Create a system, and calculate output
	LocationDetails location = new LocationDetails( daylighthoursw, 
													daylighthourss, 
													monthlyconsumptionw, 
													monthlyconsumptions, 
													exporttariff, 
													importtariff, 
													rooftempw, 
													rooftemps, 
													solarinsolationw, 
													solarinsolations);
	
	SystemConfiguration system = new SystemConfiguration(panelcount, 
														 paneloutput, 
														 inverterefficiency, 
														 paneldensity,
														 panelefficiency, 
														 paneldegradation, 
														 tempcoefficient);
	
	
	//Montlhy is Winter/Summer is 3 months
	
	grossMonthlyOutputW = SolarOutput.getInitialMonthlyWinterOutput(system, location);
	grossMonthlyOutputS = SolarOutput.getInitialMonthlySummerOutput(system, location);
	
	monlthySavingsW = SolarOutput.getInitialMonthlyWinterSavings(system, location);
	monlthySavingsS = SolarOutput.getInitialMonthlySummerSavings(system, location);

	firstYearOutput = SolarOutput.getFristYearOutput(system, location);
	firstYearFeedIn = SolarOutput.getFristYearExport(system, location);
	firstYearSavings = SolarOutput.getFristYearSavings(system, location);
	
	systemCost = SolarOutput.calculateSystemCost(system);
	
	breakEvenTime = SolarOutput.calculateBreakEvenTime(system, location);

	
	//TODO: Round all values to 2 places
	grossMonthlyOutputW = Math.round( grossMonthlyOutputW * 100.0) / 100.0;
	grossMonthlyOutputS = Math.round( grossMonthlyOutputS * 100.0) / 100.0;
	
	monlthySavingsW = Math.round( monlthySavingsW * 100.0) / 100.0;
	monlthySavingsS = Math.round( monlthySavingsS * 100.0) / 100.0;
	
	firstYearOutput = Math.round( firstYearOutput * 100.0) / 100.0;
	firstYearFeedIn =  Math.round( firstYearFeedIn * 100.0) / 100.0;
	firstYearSavings = Math.round( firstYearSavings * 100.0) / 100.0;
	
	systemCost = Math.round( systemCost * 100.0) / 100.0;
	
}

%><solarcalculator>
	<grossmonthlyoutputw><%out.print(grossMonthlyOutputW);%></grossmonthlyoutputw>
	<grossmonthlyoutputs><%out.print(grossMonthlyOutputS);%></grossmonthlyoutputs>
	<monlthysavingsw><%out.print(monlthySavingsW);%></monlthysavingsw>
	<monlthysavingss><%out.print(monlthySavingsS);%></monlthysavingss>
	<firstyearoutput><%out.print(firstYearOutput);%></firstyearoutput>
	<firstyearsavings><%out.print(firstYearSavings);%></firstyearsavings>
	<systemcost><%out.print(systemCost);%></systemcost>
	<breakeventime><%out.print(breakEvenTime);%></breakeventime>
	<error><%out.print(error);%></error>
</solarcalculator>