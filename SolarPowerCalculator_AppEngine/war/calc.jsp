<%@ page contentType="text/html" pageEncoding="UTF-8" language="java"%>
<%
//Default values, store in database instead
int panelcount = 5;
int paneloutput = 250;
int paneldensity = 130;
double paneldegradation = 0.7;
double panelefficiency = 14.0;
double tempcoefficient = -0.005;
double inverterefficiency = 90;

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
<body  onload="showInput();">
		<div id="container">
			<div id="header">
				<div id="menuBar">
					<a class="menuItem" href="../calc.jsp">Calculator</a>
					<a class="menuItem" href="../about.jsp">About</a>
					<a class="menuItem" href="../help.jsp">Help</a>
				</div>
			</div>
			<div id="sidebar"></div>
			<div id="content">
				<div class="inputtable">
					<form name="output" action="calc.jsp" method="post" onSubmit="postPowerCalc(); return false;if (formValidation()) {postPowerCalc(); showInput();} else {hideOutput();} return false;">

					
					<div class="systemoptions">
						<div class="inputs">
							<input type="checkbox" name="optionSimpleInput" id=""optionSimpleInput" value=""optionSimpleInput" class="checkbox" onclick="showInput()" checked/><label for="optionSimpleInput" class="label">Simple Inputs</label>
							
							<input type="submit" value="Calculate" class="calc"/>
						</div>
					</div>
					<div class="systemconf">
						<div class="tableHeader"><b>System Configuration</b></div>
						<div class="labels">
							<div class="inputs" id="divpanelcount">Number of Panels<input name="panelcount" value="<%=panelcount%>" class="text" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();" onkeyup="validateOnKeyDown(this);"/></div>
							<div class="inputs" id="divmonthlyconsumptions">Av. Consum. (Nov-Apr) (KWh/Mo)<input name="monthlyconsumptions" value="<%=monthlyconsumptions%>" class="text" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();" onkeyup="validateOnKeyDown(this);"/></div>
							<div class="inputs" id="divmonthlyconsumptionw">Av. Consum (May-Oct) (KWh/Mo)<input name="monthlyconsumptionw" value="<%=monthlyconsumptionw%>" class="text" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();" onkeyup="validateOnKeyDown(this);"/></div>
						</div>
					</div>
					
					
					<div class="systemstats">
						<div class="tableHeader"><b>System Statistics</b></div>
						<div class="labels">
							<div class="inputs" id="divpaneloutput">Panel Output (W)<input name="paneloutput" value="<%=paneloutput%>" class="text" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();" onkeyup="validateOnKeyDown(this);"/></div>
							<div class="inputs" id="divpaneldensity">Panel Density (W/m^2)<input name="paneldensity" value="<%=paneldensity%>" class="text" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();" onkeyup="validateOnKeyDown(this);"/></div>
							<div class="inputs" id="divpanelpanelefficiency">Panel Efficiency (%)<input name="panelefficiency" value="<%=panelefficiency%>" class="text" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();" onkeyup="validateOnKeyDown(this);"/></div>
							<div class="inputs" id="divpaneldegradation">Panel Degradation (%PA)<input name="paneldegradation" value="<%=paneldegradation%>" class="text" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();" onkeyup="validateOnKeyDown(this);"/></div>
							<div class="inputs" id="divsolarinsolations">Av. Insolation (Nov-Apr) (KWh/Day/m^2)<input name="solarinsolations" value="<%=solarinsolations%>" class="text" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();" onkeyup="validateOnKeyDown(this);"/></div>
							<div class="inputs" id="divsolarinsolationw">Av. Insolation (May-Oct) (KWh/Day/m^2)<input name="solarinsolationw" value="<%=solarinsolationw%>" class="text" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();" onkeyup="validateOnKeyDown(this);"/></div>
							<div class="inputs" id="divtempcoefficient">Temperature Coefficient<input name="tempcoefficient" value="<%=tempcoefficient%>" class="text" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();" onkeyup="validateOnKeyDown(this);"/></div>
							<div class="inputs" id="divinverterefficiency">Inverter Efficiency (%)<input name="inverterefficiency" value="<%=inverterefficiency%>" class="text" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();" onkeyup="validateOnKeyDown(this);"/></div>
						</div>
					</div>
					<div class="location">
						<div class="tableHeader"><b>Location</b></div>
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
							<div class="inputs" id="divdaylighthourss">Av. Direct Sunlight (Nov-Apr)<input name="daylighthourss" value="<%=daylighthourss%>" class="text" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();"  onkeyup="validateOnKeyDown(this);"/></div>
							<div class="inputs" id="divdaylighthoursw">Av. Direct Sunlight (May-Oct)<input name="daylighthoursw" value="<%=daylighthoursw%>" class="text" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();"  onkeyup="validateOnKeyDown(this);"/></div>
							<div class="inputs" id="divrooftemps">Roof Temp. (May-Oct)(&deg;C)<input name="rooftemps" value="<%=rooftemps%>" class="text" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();"  onkeyup="validateOnKeyDown(this);"/></div>
							<div class="inputs" id="divrooftempw">Roof Temp. ()(&deg;C)<input name="rooftempw" value="<%=rooftempw%>" class="text" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();"  onkeyup="validateOnKeyDown(this);"/></div>
						</div>
					</div>
					<div class="rates">
						<div class="tableHeader"><b>Rates</b></div>
						<div class="labels">
							<div class="inputs" id="divimporttariff">Supply (Input) Tariff ($)<input name="importtariff" value="<%=importtariff%>" class="text" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();"  onkeyup="validateOnKeyDown(this);"/></div>
							<div class="inputs" id="divexporttariff">Feed-in (Export) Tariff ($)<input name="exporttariff" value="<%=exporttariff%>" class="text" onmouseover="toolTipPopUp(this);" onmouseout="toolTipPopDown();"  onkeyup="validateOnKeyDown(this);"/></div>
						</div>
					</div>
					<div class="splitter"></div>
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
				<div id="contentFooter">
					All values are pure estimates and hold no guaranteed real-world value.
				</div>
			</div>
		</div>
	</body>
</html>