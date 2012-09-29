<%@ page contentType="text/html" pageEncoding="UTF-8" language="java"%>
<%
//Default values, store in database instead
int numpanels = 2;
double daylighthours = 4.5;
int hourlyusage = 300;
int paneloutput = 250;
double panelefficiency = 100;
double inverterefficiency = 0.96;
%>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
<head>
 <title>Solar Output Calculator</title>
 <link rel="stylesheet" type="text/css" href="css/mainstyle.css" />
 <script type="text/javascript" src="js/validatesolaroutput.js"></script>
 <script type="text/javascript" src="js/ajax.js"></script>
</head>
<body>

<div id="container">
<div class="template">
	<img src="images/TA0.jpg" width="671" height="70" alt=""><img src="images/TB0.jpg" width="185" height="32" alt=""><a class="powercalclink" href="powercalc.jsp"></a><img src="images/TB1.jpg" width="10" height="32" alt=""><a class="costcalclink" href="costcalc.jsp"></a><img src="images/TB2.jpg" width="10" height="32" alt=""><a class="aboutlink" href="about.jsp"></a><img src="images/TB3.jpg" width="194" height="32" alt=""><img src="images/TC0.jpg" align="top" width="167" height="95" alt=""><div class="inputtable">
			<form name="output" action="powercalc.jsp" method="post" onSubmit="if (formValidation()) {postPowerCalc();} return false;">
            <div class="systemconf">
                     <div class="header"><b>System Configuration</b></div>
                     <div class="labels">
						<div class="inputs">Number of Panels<input name="numpanels" value="<%=numpanels%>" /></div>
						<div class="inputs">Daylight Hours<input name="daylighthours" value="<%=daylighthours%>" /></div>
                        <div class="inputs">Daily Usage Wh<input name="hourlyusage" value="<%=hourlyusage%>" /></div>
                    </div>
			</div>
            <div class="systemstats">
                     <div class="header"><b>System Statistics</b></div>
                     <div class="labels">
						<div class="inputs">Panel Output W<input name="paneloutput" value="<%=paneloutput%>" /></div>
						<div class="inputs">Panel Degradation %pa<input name="panelefficiency" value="<%=panelefficiency%>" /></div>
						<div class="inputs">Inverter Efficiency %<input name="inverterefficiency" value="<%=inverterefficiency*100.0%>" /></div>
					 </div>
            </div>
				<input type="submit" value="Calculate" class="calc"/>
				<div id="errorBox"></div>
				<div id="grossoutput"></div>
				<div id="netoutput"></div>
			</form>
            </div>
	<!--
	<img src="images/spacer.gif" width="167" height="1" alt="">
	<img src="images/spacer.gif" width="18" height="1" alt="">
	<img src="images/spacer.gif" width="104" height="1" alt="">
	<img src="images/spacer.gif" width="10" height="1" alt="">
	<img src="images/spacer.gif" width="104" height="1" alt="">
	<img src="images/spacer.gif" width="10" height="1" alt="">
	<img src="images/spacer.gif" width="64" height="1" alt="">
	<img src="images/spacer.gif" width="194" height="1" alt="">
	-->
</div>
</div>

</body>
</html>