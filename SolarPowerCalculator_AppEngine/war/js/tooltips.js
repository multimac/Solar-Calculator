
function toolTipPopUp(input) {
	
	var toolTipBox = document.getElementById("divtooltip")
	
	//System Configuration ToolTips
	if (input.name == "panelcount") {
		setToolTip("The number of solar panels for the installation. [1-50]");
	}
	else if (input.name == "monthlyconsumptions") {
		setToolTip("The monthly consumption of electricity during Summer in KWhs. [1-1000]");
	}
	else if (input.name == "monthlyconsumptionw") {
		setToolTip("The monthly consumption of electricity during Winter in KWhs. [1-1000]");
	}
	
	//System Statistics ToolTips
	else if (input.name == "paneloutput") {
		setToolTip("The output of each panel for the system in Watts. [50-500]");
	}
	else if (input.name == "paneldensity") {
		setToolTip("The density of each panel in Watts per Metre squared");
	}
	
	else if (input.name == "panelefficiency") {
		setToolTip("The rate at which the panels degrade per year as a %. [0-100]");
	}
	
	else if (input.name == "solarinsolations" || input.name == "solarinsolationw") {
		setToolTip("The amount of energy reaching your solar panels in KiloWatt hours per square meter per day [0-20]");
	}
	else if (input.name == "inverterefficiency") {
		setToolTip("The efficiency of the inverter to convert panel output to usable electricity as a %. [0-100]");
	}
	
	//Location ToolTips
	else if (input.name == "city") {
		setToolTip("The city in which your installation is located in.");
	}
	else if (input.name == "daylighthourss" || input.name == "daylighthoursw") {
		setToolTip("The average hours of daylight. [1-24]");
	}
	else if (input.name == "rooftemps" || input.name == "rooftempw") {
		setToolTip("The average daily temperature in degrees Celsius of the roof at the installation. [-40 - 80]");
	}
	
	//Rates ToolTips
	else if (input.name == "exporttariff") {
		setToolTip("The rebate rate for feeding electricity back into the main power grid in dollars. [0.01-1]");
	}
	
	else if (input.name == "importtariff") {
		setToolTip("The cost for consuming electricity from the main power grid in dollars [0.01 - 1]");
	}
	
}


function toolTipPopDown() {
	setToolTip("");
}



function setToolTip(msg) {
	document.getElementById("divtooltip").innerHTML = msg;
}