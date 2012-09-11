<%@ page contentType="text/html" pageEncoding="UTF-8" language="java"%>
<%@ page import="powerCalculations.SolarOutput" %>
<%@ page import="environmentalSpecifications.LocationDetails"%>
<%@ page import="environmentalSpecifications.SystemConfiguration"%>


<%
//Process input

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
            <b>INB372 Agile Software Development</b><br/>
            Solar Power Calculator Assignment 2012 sem2<br/><br/>
            
            <b>Panther-Rabbit Thingy</b><br/>
            Brendon Park - 0400667842<br/>
			David Symons - N8444427<br/>
			Glen-Andrew Thomson - N7207999<br/>
			Sean Burnett - N8102210<br/>
			Kierren Small - N8101621<br/>
			            
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