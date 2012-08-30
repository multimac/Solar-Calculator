<%@ page contentType="text/html" pageEncoding="UTF-8" language="java"%>
<%@ page import="powerCalculations.SolarOutput" %>
<%@ page import="environmentalSpecifications.LocationDetails"%>
<%@ page import="environmentalSpecifications.SystemConfiguration"%>

<html>
<head>
<title>Solar Output Calculator</title>
<link rel="stylesheet" type="text/css" href="css/mainstyle.css" />
<script type="text/javascript" src="js/validatesolaroutput.js"></script>
</head>
<body>

<h1>Output Calculator</h1>

<form name="output" action="output.jsp" method="get" onsubmit="return validate();">
<table border="0">
 <tr>
 	<td>
    	<table border="1" style="border-collapse:collapse; border-style:solid">
         <tr style="background-color:#CCC">
            <td colspan="2"><b>System Configuration</b></td>
         </tr>
         <tr>
            <td>Num Panels</td>
            <td><input name="numpanels" value="1" /></td>
         </tr>
         <tr>
            <td>Daylight Hours</td>
            <td><input name="daylighthours" value="4" /></td>
         </tr>
         <tr>
            <td>Daytime Hourly Usage</td>
            <td><input name="hourlyusage" value="1" /></td>
         </tr>
        </table>
    </td>
    <td>
    	<table border="1" style="border-collapse:collapse; border-style:solid">
         <tr style="background-color:#CCC">
            <td colspan="2"><b>System Statistics</b></td>
         </tr>
         <tr>
            <td>Panel Output (Wh)</td>
            <td><input name="panelOutput" value="4950" /></td>
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
 	<td colspan="2"><center><input type="submit" value="Submit"/></center></td>
 </tr>
</table>
</form>

<%

//ToDo: add validation
if (request.getParameter("numpanels") != null) {
	int numpanels = Integer.parseInt(request.getParameter("numpanels"));
	int daylighthours = Integer.parseInt(request.getParameter("daylighthours"));
	float hourlyusage = Float.parseFloat(request.getParameter("hourlyusage"));
	int panelOutput = Integer.parseInt(request.getParameter("panelOutput"));
	float panelefficiency = Float.parseFloat(request.getParameter("panelefficiency"));
	float inverterefficiency = Float.parseFloat(request.getParameter("inverterefficiency"));
	
	//Create a system, and calculate output
	LocationDetails location = new LocationDetails(daylighthours);
	SystemConfiguration system = new SystemConfiguration(panelOutput, numpanels);
	double output = SolarOutput.calculateDailyOutput(location, system);
	
	//Print output
	out.print("<b>Output:</b> "+output);
}
%>

</body>
</html>