<?xml version="1.0" ?><%@ page contentType="text/xml;charset=ISO-8859-1" %><%@ page import="powerCalculations.SolarOutput" %><%@ page import="environmentalSpecifications.LocationDetails"%><%@ page import="environmentalSpecifications.SystemConfiguration"%><%
//Process input
double grossOutput = 0;//placeholder value
double netOutput = 0;//placeholder value

//Default values, store in database instead
int numpanels = 2;
double daylighthours = 4.5;
int hourlyusage = 300;
int paneloutput = 250;
double panelefficiency = 100;
double inverterefficiency = 0.96;

//ToDo: add validation
if (request.getParameter("numpanels") != null) {
	numpanels = Integer.parseInt(request.getParameter("numpanels"));
	daylighthours = Double.parseDouble(request.getParameter("daylighthours"));
	hourlyusage = Integer.parseInt(request.getParameter("hourlyusage"));
	paneloutput = Integer.parseInt(request.getParameter("paneloutput"));
	panelefficiency = Double.parseDouble(request.getParameter("panelefficiency"));
	inverterefficiency = Double.parseDouble(request.getParameter("inverterefficiency")) * 0.01;
}

//Create a system, and calculate output
LocationDetails location = new LocationDetails(daylighthours, hourlyusage);
SystemConfiguration system = new SystemConfiguration(paneloutput, numpanels, inverterefficiency);

grossOutput = SolarOutput.calculateGrossDailyOutput(location, system) / 1000;
netOutput = SolarOutput.calculateNetDailyOutput(location, system) / 1000;
%><solorcalculator><grossoutput><%out.print(grossOutput);%></grossoutput><netoutput><%out.print(netOutput);%></netoutput></solorcalculator>