
<!--
 Placeholder JSP page for Output Calculator
-->

<html>
<body>

<h1>Output Calculator</h1>

<form action="output.jsp" method="get">
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
            <td><input name="daylighthours" value="4.5" /></td>
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
            <td>System Size (KW)</td>
            <td><input name="systemsize" value="4.95" /></td>
         </tr>
         <tr>
            <td>Penel Efficiency</td>
            <td><input name="penelefficiency" value="100" /></td>
         </tr>
         <tr>
            <td>Inverter Efficiency</td>
            <td><input name="inverterefficiency" value="96" /></td>
         </tr>
        </table>
    </td>
 </tr>
 <tr>
 	<td colspan="2"> <center><input type="submit" value="Submit"/></center></td>
 </tr>
</table>
</form>

<%
if (request.getParameter("numpanels") != null) {
float numpanels = Float.parseFloat(request.getParameter("numpanels"));
float daylighthours = Float.parseFloat(request.getParameter("daylighthours"));
float hourlyusage = Float.parseFloat(request.getParameter("hourlyusage"));
float systemsize = Float.parseFloat(request.getParameter("systemsize"));
float penelefficiency = Float.parseFloat(request.getParameter("penelefficiency"));
float inverterefficiency = Float.parseFloat(request.getParameter("inverterefficiency"));

float sysOutput = (systemsize * numpanels) * (penelefficiency * 0.01f) * (inverterefficiency * 0.01f);

float output = (sysOutput * daylighthours) - (sysOutput * hourlyusage);

out.print("<b>Output: </b>" + output + " kwh per day");
}
%>

<br><br><br><br><br><br><br><br><br><br>
<font size="-1">
sysOutput = (systemsize * numpanels) * (penelefficiency * 0.01f) * (inverterefficiency * 0.01f);
<br>
output = (sysOutput * daylighthours) - (sysOutput * hourlyusage);
</font>

</body>
</html>