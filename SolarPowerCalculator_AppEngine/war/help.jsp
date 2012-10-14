<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
<head>
 <title>Solar Output Calculator Help</title>
 <link rel="stylesheet" type="text/css" href="css/mainstyle.css" />
 <script type="text/javascript" src="js/validatesolaroutput.js"></script>
</head>
<body>

<div id="container">
<div id="template">
	<img src="images/TA0.jpg" width="671" height="70" alt=""><img src="images/TB0.jpg" width="185" height="32" alt=""><a class="powercalclink" href="calc.jsp"></a><img src="images/TB1.jpg" width="10" height="32" alt=""><a class="costcalclink" href="help.jsp"></a><img src="images/TB2.jpg" width="10" height="32" alt=""><a class="aboutlink" href="about.jsp"></a><img src="images/TB3.jpg" width="194" height="32" alt=""><img src="images/TC0.jpg" align="top" width="167" height="95" alt="">
	<div class="text">
        <br/>
        <b>Panther-Rabbit Thingy Solar Calculator</b><br/><br/>
        <font style="font-size: 80%">
        	<a href="download/SolarCalculator.zip">Download Desktop Application</a>
        </font>
        <h2>Inputs:</h2>
        <ul>
        	<li>System Configuration
        		<ul>
        			<li>Number of Panels - The number of solar panels in the installation. (a whole number)</li>
        			<li>Monthly Usage (KWh) - The monthly consumption of electricity at your residence in KiolWatt hours</li>
        		</ul>
        	</li>
        	<li>System Statistics
        		<ul>
        			<li>Panel Output (W) - The Watt output of a single panel in your desired (or existing installation)</li>
        			<li>Panel Degradation (%)PA - The rate at which the solar panels become degrade per year in a percentage</li>
        			<li>Inverter Efficiency (%) - The efficiency of the inverter in the installation at converting power from solar panels to usable electricity in a percentage</li>
        		</ul>
        	</li>	
        	<li>Location
        		<ul>
        			<li>State - The state in which your residence is located. This input affects a number of factors include average daylight Hours, temperature and export tariff.</li>
        			<li>Daylight Hours - The average daylight hours received at your residence. a number between 0 and 24.</li>
        			<li>Temperature (C°) - The average daily temperature at your residence in degrees Celsius</li> 
        		</ul>
        	</li>
        	<li>Rates
        		<ul>
        			<li>Export Tariff ($) - The rebate rate for feeding electricity back into the main power grid. Value is calculated at $ per Kilowatt hour. Standard Queensland rate is $0.08 per Kilowatt hour</li>
        		</ul>	
        	</li>
        </ul>
	</div>
</div>
</div>

</body>
</html>
