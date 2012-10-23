<%@ page contentType="text/html" pageEncoding="UTF-8" language="java"%>
<%
//Default values, store in database instead
int panelcount = 5;
int paneloutput = 250;
int paneldensity = 130;
double paneldegradation = 0.007;
double panelefficiency = 0.14;
double tempcoefficient = -0.005;
double inverterefficiency = 0.9;

double daylighthoursw = 7.4;
double daylighthourss = 7.5;
int monthlyconsumptionw = 540;
int monthlyconsumptions = 540;
double exporttariff = 0.14;
double importtariff = 0.25;
int rooftempw = 33;
int rooftemps = 50;
double solarinsolationw = 4.07;
double solarinsolations = 5.85;
%>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
<head>
 <title>Solar Output Calculator</title>
 <link rel="stylesheet" type="text/css" href="css/mainstyle.css" />
 <script type="text/javascript" src="js/validateonsubmit.js"></script>
 <script type="text/javascript" src="js/validateonkeydown.js"></script>
 <script type="text/javascript" src="js/calcajax.js"></script>
 <script type="text/javascript" src="js/cityajax.js"></script>
 <script type="text/javascript" src="js/options.js"></script>
 <script type="text/javascript" src="js/tooltips.js"></script>
</head>
<body onload="showInput();">

<div id="container">
<div class="template">
<img src="images/TA0.jpg" width="671" height="70" alt=""><img src="images/TB0.jpg" width="185" height="32" alt=""><a class="powercalclink" href="calc.jsp"></a><img src="images/TB1.jpg" width="10" height="32" alt=""><a class="costcalclink" href="help.jsp"></a><img src="images/TB2.jpg" width="10" height="32" alt=""><a class="aboutlink" href="about.jsp"></a><img src="images/TB3.jpg" width="194" height="32" alt=""><img src="images/TC0.jpg" align="top" width="167" height="95" alt="">
<div class="inputtable">
	<form name="output" action="calc.jsp" method="post" onSubmit="if (formValidation()) {postPowerCalc(); showInput();} else {hideOutput();} return false;">
	
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
			<div class="inputs" id="divpanelcount">Number of Panels<input name="panelcount" value="<%=panelcount%>" class="text" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();" onkeyup="validateOnKeyDown(this);"/></div>
			<div class="inputs" id="divmonthlyconsumptions">Summer Cons. (KWh/Mo)<input name="monthlyconsumptions" value="<%=monthlyconsumptions%>" class="text" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();" onkeyup="validateOnKeyDown(this);"/></div>
			<div class="inputs" id="divmonthlyconsumptionw">Winter Cons. (KWh/Mo)<input name="monthlyconsumptionw" value="<%=monthlyconsumptionw%>" class="text" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();" onkeyup="validateOnKeyDown(this);"/></div>
		</div>
	</div>
	
	
	<div class="systemstats">
		<div class="header"><b>System Statistics</b></div>
		<div class="labels">
			<div class="inputs" id="divpaneloutput">Panel Output (W)<input name="paneloutput" value="<%=paneloutput%>" class="text" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();" onkeyup="validateOnKeyDown(this);"/></div>
			<div class="inputs" id="divpaneldensity">Panel Density W/m^2<input name="paneldensity" value="<%=paneldensity%>" class="text" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();" onkeyup="validateOnKeyDown(this);"/></div>
			<div class="inputs" id="divpanelpanelefficiency">Panel Efficiency<input name="panelefficiency" value="<%=panelefficiency%>" class="text" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();" onkeyup="validateOnKeyDown(this);"/></div>
			<div class="inputs" id="divpaneldegradation">Panel Degradation (%)PA<input name="paneldegradation" value="<%=paneldegradation%>" class="text" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();" onkeyup="validateOnKeyDown(this);"/></div>
			<div class="inputs" id="divsolarinsolations">Summer Insolation<input name="solarinsolations" value="<%=solarinsolations%>" class="text" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();" onkeyup="validateOnKeyDown(this);"/></div>
			<div class="inputs" id="divsolarinsolationw">Winter Insolation<input name="solarinsolationw" value="<%=solarinsolationw%>" class="text" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();" onkeyup="validateOnKeyDown(this);"/></div>
			<div class="inputs" id="divtempcoefficient">Temperature Coefficient<input name="tempcoefficient" value="<%=tempcoefficient%>" class="text" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();" onkeyup="validateOnKeyDown(this);"/></div>
			<div class="inputs" id="divinverterefficiency">Inverter Efficiency (%)<input name="inverterefficiency" value="<%=inverterefficiency%>" class="text" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();" onkeyup="validateOnKeyDown(this);"/></div>
		</div>
	</div>
	<div class="location">
		<div class="header"><b>Location</b></div>
		<div class="labels">
			<div class="inputs" id="divcity">City<select name="city" class="text" style="width:100px" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();" onchange="postCity()">
														<option value="Brisbane">Brisbane</option>
														<option value="Sydney">Sydney</option>
														<option value="Melbourne">Melbourne</option>
														<option value="Adelaide">Adelaide</option>
														<option value="Perth">Perth</option>
														<option value="Darwin">Darwin</option>
														<option value="Canberra">Canberra</option>
													</select></div>
			<div class="inputs" id="divdaylighthourss">Summer Daylight Hours<input name="daylighthourss" value="<%=daylighthourss%>" class="text" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();"  onkeyup="validateOnKeyDown(this);"/></div>
			<div class="inputs" id="divdaylighthoursw">Winter Daylight Hours<input name="daylighthoursw" value="<%=daylighthoursw%>" class="text" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();"  onkeyup="validateOnKeyDown(this);"/></div>
			<div class="inputs" id="divrooftemps">Summer Roof Temp. (&deg;C)<input name="rooftemps" value="<%=rooftemps%>" class="text" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();"  onkeyup="validateOnKeyDown(this);"/></div>
			<div class="inputs" id="divrooftempw">Winter Roof Temp. (&deg;C)<input name="rooftempw" value="<%=rooftempw%>" class="text" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();"  onkeyup="validateOnKeyDown(this);"/></div>
		</div>
	</div>
	<div class="rates">
		<div class="header"><b>Rates</b></div>
		<div class="labels">
			<div class="inputs" id="divimporttariff">Input Tariff ($)<input name="importtariff" value="<%=importtariff%>" class="text" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();"  onkeyup="validateOnKeyDown(this);"/></div>
			<div class="inputs" id="divexporttariff">Export Tariff ($)<input name="exporttariff" value="<%=exporttariff%>" class="text" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();"  onkeyup="validateOnKeyDown(this);"/></div>
		</div>
	</div>
	
	<div class="output">
		<div id="divgrossmonthlyoutputw"></div>
		<div id="divgrossmonthlyoutputs"></div>
		<div id="divmonlthysavingsw"></div>
		<div id="divmonlthysavingss"></div>
		<div id="divfirstyearoutput"></div>
		<div id="divfirstyearsavings"></div>
		<div id="divsystemcost"></div>
		<div id="divbreakeventime"></div>
	</div>
	
	<div class="info">
		<div id="divtooltip" class="tooltip"></div>
		<div id="divtooltiperror" class="tooltiperror"></div>
		<div id="diverroroutput"></div>
	</div>
	</form>
</div>
</div>
</div>

</body>
</html>