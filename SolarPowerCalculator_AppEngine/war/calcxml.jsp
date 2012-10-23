<?xml version="1.0" ?><%@ page contentType="text/xml;charset=ISO-8859-1" %><%@ page import="powerCalculations.SolarOutput" %><%@ page import="environmentalSpecifications.LocationDetails"%><%@ page import="environmentalSpecifications.SystemConfiguration"%><%@ page import="validation.Validator"%><%
//Process input

//UPDATE THESE
double grossMonthlyOutputW;
double netMonthlyOutputW;
	
double GrossMonthlyOutputS; 
double netMonthlyOutputS; 
	
double monlthySavingsW; 
double monlthySavingsS; 
	
double firstYearOutpu;
double firstYearSavings; 
	
double systemCost; 
double revenue;
String breakEvenTime; 

//System
int panelcount = 2;
int paneloutput = 250;
double inverterefficiency = 0.96;
int paneldensity = 130;
double panelefficiency = 100; 
double paneldegradation= 0.5; 
double tempcoefficient = -0.005;

//Environment
double daylighthoursw = 7.4;
double daylighthourss = 7.5;
int monthlyconsumptionw = 0;
int monthlyconsumptions = 0;
double exportrate = 0.14;
double importrate = 0.25;
int rooftempw = 33;
int rooftemps = 50;
double solarinsolationw = 4.07;
double solarinsolations = 5.85;

String error = "noerror";
boolean valid = false;

//Validate all input

if (!Validator.IsInteger(request.getParameter("numpanels"))) {
	error = "Number of panels must be a whole number.";
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


else if (!Validator.IsDouble(request.getParameter("exportrate"))) {
	error = "Export Rate must be a valid number." + request.getParameter("exportrate");
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
	daylighthourss = Double.parseDouble(request.getParameter("daylightHourss"));
	monthlyconsumptionw = Integer.parseInt(request.getParameter("monthlyconsumptionw"));
	monthlyconsumptions = Integer.parseInt(request.getParameter("monthlyconsumptions"));
	exportrate = Double.parseDouble(request.getParameter("exportrate"));
	importrate = Double.parseDouble(request.getParameter("importrate"));
	rooftempw = Integer.parseInt(request.getParameter("rooftempw"));
	rooftemps = Integer.parseInt(request.getParameter("rooftemps"));
	solarinsolationw = Double.parseDouble(request.getParameter("solarinsolationw"));
	solarinsolations = Double.parseDouble(request.getParameter("solarinsolations"));
	
	

	//Create a system, and calculate output
	LocationDetails location = new LocationDetails( daylighthoursw, 
													daylighthourss, 
													monthlyconsumptionw, 
													monthlyconsumptions, 
													exportrate, 
													importrate, 
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
	
	
	grossMonthlyOutputW = 
	netMonthlyOutputW =
	
	GrossMonthlyOutputS = 
	netMonthlyOutputS = 
	
	monlthySavingsW = SolarOutput.getInitialMonthlyWinterSavings(system, location);
	monlthySavingsS = SolarOutput.getInitialMonthlySummerSavings(system, location);
	
	firstYearOutput =
	firstYearSavings = 
	
	systemCost = SolarOutput.calculateInstallCost();
	
	revenue = (???)
	
	breakEvenTime = SolarOutput.calculateBreakEvenTime(system, location);

	
	//TODO: Round all values to 2 places
	//Math.round( [VALUE] *100.0)/100.0;
	
}

%><solarcalculator>
	<grossmonthlyoutputw><%out.print(grossMonthlyOutputW);%></grossmonthlyoutputw>
	<netmonthlyoutputw><%out.print(netMonthlyOutputW);%></netmonthlyoutputw>
	<grossmonthlyoutputs><%out.print(GrossMonthlyOutputS);%></grossmonthlyoutputs>
	<netmonthlyoutputs><%out.print(netMonthlyOutputS);%></netmonthlyoutputs>
	<monlthysavingsw><%out.print(monlthySavingsW);%></monlthysavingsw>
	<monlthysavingss><%out.print(monlthySavingsS);%></monlthysavingss>
	<firstyearoutput><%out.print(firstYearOutput);%></firstyearoutput>
	<firstyearsavings><%out.print(firstYearSavings);%></firstyearsavings>
	<systemcost><%out.print(systemCost);%></systemcost>
	<revenue><%out.print(revenue);%></revenue>
	<breakeventime><%out.print(breakEvenTime);%></breakeventime>
	<error><%out.print(error);%></error>
</solarcalculator>