<%@ page contentType="text/html" pageEncoding="UTF-8" language="java"%>
<%
//Default values, store in database instead
int numpanels = 5;
double daylighthours = 4.5;
double monthlyconsumption = 540;
int paneloutput = 250;
double panelefficiency = 5;
double inverterefficiency = 0.96;
double exportrate = 0.08;
String state = "QLD";
double temperature = 28.0;
%>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
<head>
 <title>Solar Output Calculator</title>
 <link rel="stylesheet" type="text/css" href="css/mainstyle.css" />
 <script type="text/javascript" src="js/validatesolaroutput.js"></script>
 <script type="text/javascript" src="js/calcajax.js"></script>
 <script type="text/javascript" src="js/options.js"></script>
</head>
<body onload="showInput();">

<div id="container">
<div class="template">
<img src="images/TA0.jpg" width="671" height="70" alt=""><img src="images/TB0.jpg" width="185" height="32" alt=""><a class="powercalclink" href="calc.jsp"></a><img src="images/TB1.jpg" width="10" height="32" alt=""><a class="costcalclink" href="help.jsp"></a><img src="images/TB2.jpg" width="10" height="32" alt=""><a class="aboutlink" href="about.jsp"></a><img src="images/TB3.jpg" width="194" height="32" alt=""><img src="images/TC0.jpg" align="top" width="167" height="95" alt="">
<div class="inputtable">
	<form name="output" action="calc.jsp" method="post" onSubmit="if (formValidation()) {postPowerCalc(); showInput();} else {hideOuput();} return false;">
	
	<div class="systemoptions">
		<div class="inputs">
			<input type="checkbox" name="optionpower" id="optionpower" value="optionpower" class="checkbox" onclick="showInput()" checked/><label for="optionpower" class="label">Power</label>
			<input type="checkbox" name="optioncost" id="optioncost" value="optioncost" class="checkbox" onclick="showInput()" checked/><label for="optioncost">Estimated Cost</label>
			<input type="checkbox" name="optionrevenue" id="optionrevenue" value="optionrevenue" class="checkbox" onclick="showInput()" checked/><label for="optionrevenue">Revenue</label>
			<input type="checkbox" name="optionbreakeven" id="optionbreakeven" value="optionbreakeven" class="checkbox" onclick="showInput()" checked/><label for="optionbreakeven">Break Even</label>
			
			<input type="submit" value="Calculate" class="calc"/>
		</div>
	</div>
	<div class="systemconf">
		<div class="header"><b>System Configuration</b></div>
		<div class="labels">
			<div class="inputs" id="divnumpanels">Number of Panels<input name="numpanels" value="<%=numpanels%>" class="text"/></div>
			<div class="inputs" id="divmonthlyconsumption">Monthly Cons. (KWh)<input name="monthlyconsumption" value="<%=monthlyconsumption%>" class="text"/></div>
		</div>
	</div>
	
	
	<div class="systemstats">
		<div class="header"><b>System Statistics</b></div>
		<div class="labels">
			<div class="inputs" id="divpaneloutput">Panel Output (W)<input name="paneloutput" value="<%=paneloutput%>" class="text"/></div>
			<div class="inputs" id="divpanelefficiency">Panel Degradation (%)PA<input name="panelefficiency" value="<%=panelefficiency%>" class="text"/></div>
			<div class="inputs" id="divinverterefficiency">Inverter Efficiency (%)<input name="inverterefficiency" value="<%=inverterefficiency*100.0%>" class="text"/></div>
		</div>
	</div>
	<div class="location">
		<div class="header"><b>Location</b></div>
		<div class="labels">
			<div class="inputs" id="divstate">State<input name="state" value="<%=state%>" class="text"/></div>
			<div class="inputs" id="divlighthours">Daylight Hours (per day)<input name="daylighthours" value="<%=daylighthours%>" class="text"/></div>
			<div class="inputs" id="divtemperature">Temperature (C&deg;)<input name="temperature" value="<%=temperature%>" class="text"/></div>
		</div>
	</div>
	<div class="rates">
		<div class="header"><b>Rates</b></div>
		<div class="labels">
			<div class="inputs" id="divexportrate">Export Tarrif ($)<input name="exportrate" value="<%=exportrate%>" class="text"/></div>
		</div>
	</div>
	
	<div>
		<div id="diverroroutput"></div>
		<div id="divgrossoutput"></div>
		<div id="divnetoutput"></div>
		<div id="divcostoutput"></div>
		<div id="divrevenueoutput"></div>
		<div id="divbreakevenoutput"></div>
		<div id="diverroroutput"></div>
	</div>
	
	</form>
</div>
</div>
</div>

</body>
</html>