<%@ page contentType="text/html" pageEncoding="UTF-8" language="java"%>
<%@ page import="powerCalculations.SolarOutput" %>
<%@ page import="environmentalSpecifications.LocationDetails"%>
<%@ page import="environmentalSpecifications.SystemConfiguration"%>


<%
//Process input
double output = 21.384;//placeholder value

int numpanels = 1;
double daylighthours = 4.5;
double hourlyusage = 1;
int paneloutput = 4950;
double panelefficiency = 100;
double inverterefficiency = 96;

//ToDo: add validation
if (request.getParameter("numpanels") != null) {
	numpanels = Integer.parseInt(request.getParameter("numpanels"));
	daylighthours = Double.parseDouble(request.getParameter("daylighthours"));
	hourlyusage = Double.parseDouble(request.getParameter("hourlyusage"));
	paneloutput = Integer.parseInt(request.getParameter("paneloutput"));
	panelefficiency = Double.parseDouble(request.getParameter("panelefficiency"));
	inverterefficiency = Double.parseDouble(request.getParameter("inverterefficiency"));
	
	//Create a system, and calculate output
	LocationDetails location = new LocationDetails(daylighthours);
	SystemConfiguration system = new SystemConfiguration(paneloutput, numpanels);
	
	output = SolarOutput.calculateDailyOutput(location, system);
}
%>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
<head>
 <title>Solar Output Calculator</title>
 <link rel="stylesheet" type="text/css" href="css/mainstyle.css" />
 <script type="text/javascript" src="js/validatesolaroutput.js"></script>
</head>
<body>

<div id="container">
<table id="template" cellpadding="0" cellspacing="0">
	<tr>
		<td colspan="9"><img src="images/TA0.jpg" width="671" height="70" alt=""></td></tr>
	<tr>
		<td width="185" colspan="2"><img src="images/TB0.jpg" width="185" height="32" alt=""></td>
		<td width="104"><a class="powercalclink" href="powercalc.jsp"></a></td>
		<td width="10"><img src="images/TB1.jpg" width="10" height="32" alt=""></td>
		<td width="104"><a class="costcalclink" href="costcalc.jsp"></a></td>
		<td width="10"><img src="images/TB2.jpg" width="10" height="32" alt=""></td>
		<td width="64"><a class="aboutlink" href="about.jsp"></a></td>
		<td width="194"><img src="images/TB3.jpg" width="194" height="32" alt=""></td>
        <td width="100%"></td>
	</tr>
	<tr>
		<td style="vertical-align:text-top"><img src="images/TC0.jpg" width="167" height="95" alt=""></td>
		<td colspan="8">
		
			<!-- Page Content -->
        	<br/>
            <form name="output" action="powercalc.jsp" method="get" onSubmit="return validate();">
            <table id="inputtable">
             <tr>
                <td>
                    <table id="systemconf">
                     <tr class="header">
                        <td colspan="2"><b>System Configuration</b></td>
                     </tr>
                     <tr>
                        <td class="labels">Num Panels</td>
                        <td><input name="numpanels" value="<%=numpanels%>" /></td>
                     </tr>
                     <tr>
                        <td>Daylight Hours</td>
                        <td><input name="daylighthours" value="<%=daylighthours%>" /></td>
                     </tr>
                     <tr>
                        <td>Daytime Hourly Usage</td>
                        <td><input name="hourlyusage" value="<%=hourlyusage%>" /></td>
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
                        <td><input name="paneloutput" value="<%=paneloutput%>" /></td>
                     </tr>
                     <tr>
                        <td>Panel Efficiency</td>
                        <td><input name="panelefficiency" value="<%=panelefficiency%>" /></td>
                     </tr>
                     <tr>
                        <td>Inverter Efficiency</td>
                        <td><input name="inverterefficiency" value="<%=inverterefficiency%>" /></td>
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
            <!-- Page Content -->
            
        </td>
	</tr>
	<tr>
		<td><img src="images/spacer.gif" width="167" height="1" alt=""></td>
		<td><img src="images/spacer.gif" width="18" height="1" alt=""></td>
		<td><img src="images/spacer.gif" width="104" height="1" alt=""></td>
		<td><img src="images/spacer.gif" width="10" height="1" alt=""></td>
		<td><img src="images/spacer.gif" width="104" height="1" alt=""></td>
		<td><img src="images/spacer.gif" width="10" height="1" alt=""></td>
		<td><img src="images/spacer.gif" width="64" height="1" alt=""></td>
		<td><img src="images/spacer.gif" width="194" height="1" alt=""></td>
        <td></td>
	</tr>
</table>
</div>

</body>
</html>