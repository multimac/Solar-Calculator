<%@ page import="powerCalculations.SolarOutput" %>
<%@ page import="environmentalSpecifications.LocationDetails"%>
<%@ page import="environmentalSpecifications.SystemConfiguration"%>
<%
double output = 0.0;
//ToDo: add validation
if (request.getParameter("numpanels") != null) {
	int numpanels = Integer.parseInt(request.getParameter("numpanels"));
	int daylighthours = Integer.parseInt(request.getParameter("daylighthours"));
	float hourlyusage = Float.parseFloat(request.getParameter("hourlyusage"));
	int paneloutput = Integer.parseInt(request.getParameter("paneloutput"));
	float panelefficiency = Float.parseFloat(request.getParameter("panelefficiency"));
	float inverterefficiency = Float.parseFloat(request.getParameter("inverterefficiency"));
	
	//Create a system, and calculate output
	LocationDetails location = new LocationDetails(daylighthours);
	SystemConfiguration system = new SystemConfiguration(paneloutput, numpanels);
	output = SolarOutput.calculateDailyOutput(location, system);
}
%>
<?xml version="1.0" ?>
<solorcalculator>
 <output><%out.print(output);%></output>
</solorcalculator>
