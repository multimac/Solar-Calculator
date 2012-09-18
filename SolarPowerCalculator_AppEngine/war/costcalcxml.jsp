<?xml version="1.0" ?><%@ page contentType="text/xml;charset=ISO-8859-1" %><%@ page import="powerCalculations.SolarOutput" %><%@ page import="environmentalSpecifications.LocationDetails"%><%@ page import="environmentalSpecifications.SystemConfiguration"%><%
//Process input
double cost = 0;

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
	paneloutput = Integer.parseInt(request.getParameter("paneloutput"));
}

//Create a system, and calculate cost
SystemConfiguration system = new SystemConfiguration(paneloutput, numpanels, inverterefficiency);

cost = SolarOutput.calculateSystemCost(system);

//Round output values
cost = Math.round(cost * 100.0) / 100.0;

%><solorcalculator><cost><%out.print(cost);%></cost></solorcalculator>