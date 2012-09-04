<%@ page contentType="text/html" pageEncoding="UTF-8" language="java"%>
<%@ page import="powerCalculations.SolarOutput" %>
<%@ page import="environmentalSpecifications.LocationDetails"%>
<%@ page import="environmentalSpecifications.SystemConfiguration"%>


<%
//Process input
double output = 21.384;//placeholder value

//ToDo: add validation
if (request.getParameter("numpanels") != null) {
	int numpanels = Integer.parseInt(request.getParameter("numpanels"));
	double daylighthours = Double.parseDouble(request.getParameter("daylighthours"));
	double hourlyusage = Double.parseDouble(request.getParameter("hourlyusage"));
	int paneloutput = Integer.parseInt(request.getParameter("paneloutput"));
	double panelefficiency = Double.parseDouble(request.getParameter("panelefficiency"));
	double inverterefficiency = Double.parseDouble(request.getParameter("inverterefficiency"));
	
	//Create a system, and calculate output
	LocationDetails location = new LocationDetails(daylighthours);
	SystemConfiguration system = new SystemConfiguration(paneloutput, numpanels);
	
	output = SolarOutput.calculateDailyOutput(location, system);
}
%>


<html>
<head>
 <title>Solar Output Calculator</title>
 <link rel="stylesheet" type="text/css" href="css/mainstyle.css" />
 <script type="text/javascript" src="js/validatesolaroutput.js"></script>
</head>
<body>



<div id="container">
<h1>Electrical Output Calculator</h1>
<form name="output" action="output.jsp" method="get" onSubmit="return validate();">
<table id="inputtable">
 <tr>
 	<td>
    	<table id="systemconf">
         <tr class="header">
            <td colspan="2"><b>System Configuration</b></td>
         </tr>
         <tr>
            <td class="labels">Num Panels</td>
            <td><input name="numpanels" value="1" /></td>
         </tr>
         <tr>
            <td>Daylight Hours</td>
            <td><input name="daylighthours" value="4.5" /></td>
         </tr>
         <tr>
            <td>Daytime Hourly Usage</td>
            <td><input name="hourlyusage" value="1" /></td>
         </tr>
        </table>
    </td>
    <td>
    	<table id="systemstats">
         <tr class="header">
            <td colspan="2"><b>System Statistics</b></td>
         </tr>
         <tr>
            <td class="labels">Panel Output (W/h)</td>
            <td><input name="paneloutput" value="4950" /></td>
         </tr>
         <tr>
            <td>Panel Efficiency</td>
            <td><input name="panelefficiency" value="100" /></td>
         </tr>
         <tr>
            <td>Inverter Efficiency</td>
            <td><input name="inverterefficiency" value="96" /></td>
         </tr>
        </table>
    </td>
 </tr>
 <tr>
 	<td colspan="2"><input type="submit" value="Calculate" class="calc"/></td>
 </tr>
 <tr>
 	<td colspan="2"><b>Output: </b><% out.print(output);%>KWh</td>
 </tr>
</table>
</form>

</div>

</body>
</html>