
function toolTipPopUp(input) {
	
	var toolTipBox = document.getElementById("divtooltip")
	
	//System Configuration ToolTips
	if (input.name == "numpanels") {
		setToolTip("The number of solar panels for the installation. [1-50]");
	}
	else if (input.name == "monthlyconsumption") {
		setToolTip("The monthly consumption of electricity in KWhs. [1-1000]");
	}
	
	//System Statistics ToolTips
	else if (input.name == "paneloutput") {
		setToolTip("The output of each panel for the system in Watts. [50-500]");
	}
	else if (input.name == "panelefficiency") {
		setToolTip("The rate at which the panels degrade per year as a %. [0-100]");
	}
	else if (input.name == "inverterefficiency") {
		setToolTip("The efficiency of the inverter to convert panel output to usable electricity as a %. [0-100]");
	}
	
	//Location ToolTips
	else if (input.name == "state") {
		setToolTip("The state which the system will be installed.");
	}
	else if (input.name == "daylighthours") {
		setToolTip("The average hours of daylight. [1-24]");
	}
	else if (input.name == "temperature") {
		setToolTip("The average daily temperature in degrees Celsius. [-10-50]");
	}
	
	//Rates ToolTips
	else if (input.name == "exportrate") {
		setToolTip("The rebate rate for feeding electricity back into the main power grid in dollars. [0.01-1]");
	}
	
}


function toolTipPopDown() {
	setToolTip("");
}



function setToolTip(msg) {
	document.getElementById("divtooltip").innerHTML = msg;
}