<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
	<head>
		<title>Solar Output Calculator</title>
		<link rel="stylesheet" type="text/css" href="css/mainstyle.css" />
	</head>
	<body>
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
				<div class="text">
        <h3>Usage:</h3>
        <div class="instructions">
	        <ul>
	        	<li><b>System Configuration</b>
	        		<ul>
	        			<li><b>Number of Panels</b> - The number of solar panels in the installation. (a whole number)</li><br>
	        			<li><b>Monthly Usage (Nov-Apr)</b> - The average monthly consumption of electricity at your residence in KiloWatt hours for the months November through April</li><br>
	        			<li><b>Monthly Usage (May-Oct)</b> - The average monthly consumption of electricity at your residence in KiloWatt hours for the months May through October</li><br>
	        		</ul>
	        	</li>
	        	<li><b>System Statistics</b>
	        		<ul>
	        			<li><b>Panel Output (W)</b> - The rated maximum output of a single panel, in Watts.</li><br>
	        			<li><b>Panel Density (W/m^2)</b> - This is a common statistic used to evaluate the performance of solar panels. It is defined as the rated output in Watts divided by the area of the panel in squared meters. If you know your panel density in square feet you can multiply it by 10.76 to convert to meters. If you are unsure of this, leave it as the default value.</li><br>
	        			<li><b>Panel Efficiency (%)</b> - This is the percent of sunlight that the panels are able to convert to power. This should be in the 12%-16% range but may be outside this range for non standard panels. The highest ever recorded was 27%. If you are unsure about this value, leave it as the default value.</li><br>
	        			<li><b>Panel Degradation (%)PA</b> - The rate at which the panels efficiency degrades over time in % per annum. This should be between 0 and 4. If you are unsure of this, leave it as the default value.</li><br>
	        			<li><b>Temperature  Coefficient</b> - This is a common statistic used to evaluate the performance of solar panels in different temperatures. Its defined as the change in efficiency for each degrees celsius change in temperature. As an industry standard efficiency is normalised to 25 degree but this may not always be the case, you may have to check with the installer or manufacturer of your panels. Sometimes the spec sheet of solar panels will include several temperature coefficients, for simplicity we require only the main coefficient known as the alpha coefficient. If you are unsure about this, leave it as the default value.</li><br> 
	        			<li><b>Inverter Efficiency (%)</b> - The average efficiency of the inverter in the installation at converting power from solar panels to usable electricity in a percentage. You may wish to include efficiency that is lost due to wiring and batteries in this value. To do this multiply the efficiencies together. If you are unsure of this, leave it as the default value.</li><br>
	        		</ul>
	        	</li>	
	        	<li><b>Location</b>
	        		<ul>
	        			<li><b>City</b> - The city in which your residence is closest to. If you live far outside of any of the listed cities the result you get may not be accurate. This input affects a number of factors include average daylight Hours, temperature and the tariffs.</li><br>
	        			<li><b>Daylight Hours (Nov-Apr)</b> - The average daylight hours received at your residence in the months November through April. This only includes direct sunlight that hits the ground, unaffected by cloud cover. You may find out this value simply by calling your nearest weather station. You may alternatively use the default value for the selected city.</li><br>
	        			<li><b>Daylight Hours (May-Oct)</b> - The average daylight hours received at your residence in the months May through October. This only includes direct sunlight that hits the ground, unaffected by cloud cover. You may find out this value simply by calling your nearest weather station. You may alternatively use the default value for the selected city.</li><br>
	        			<li><b>Average Roof Temperature (Nov-Apr) (C°)</b> - The average temperature in direct sunlight at 3pm in the months November through April. If you are unsure leave this as the default value for your city.</li><br>
	        			<li><b>Average Roof Temperature (May-Oct) (C°)</b> - The average temperature in direct sunlight at 3pm in the months May through October. If you are unsure leave this as the default value for your city.</li><br> 
	        		</ul>
	        	</li>
	        	<li><b>Rates</b>
	        		<ul>
	        			<li><b>Fed-In (Export) Tariff ($)</b> - The rebate rate for feeding electricity back into the main power grid. Value is calculated at $ per Kilowatt hour. The Government regulated minimums do not reflect real world values, you should check with your power supplier or leave this as the default value for your city.</li>
	        			<li><b>Supply (Import) Tariff ($)</b> - The rate at which your electricity provider charges per KWh. You may have multiple supply tariffs such as peak and off peak and may wish to use your average cost per KWh here. You can get this value by checking your latest power bill or calling your provider. If you are unsure about this, leave it as the default value for your city.</li>
	        		</ul>	
	        	</li>
	        </ul>
        </div>
        
        <br/>
        
        <h3>Desktop Version</h3>
        	<a href="download/SolarCalculator.zip">Download Desktop Application</a> (WinXP/Vista/7)
	</div>
		    </div>
		</div>
	</body>
</html>