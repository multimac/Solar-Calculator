
function validateOnKeyDown(input) {
	
	var toolTipBox = document.getElementById("grossoutput")
	
	setToolTipError("");
	
	//System Configuration ToolTips
	if (input.name == "numpanels") {
		if (!validNumPanels()) {
			setToolTipError(errorMessages[errNumPanels]);
		}
	}
	else if (input.name == "monthlyconsumption") {
		if (!validMonthlyConsumption()) {
			setToolTipError(errorMessages[errMonthlyConsumption]);
		}
	}
	
	//System Statistics ToolTips
	else if (input.name == "paneloutput") {
		if (!validPanelOutput()) {
			setToolTipError(errorMessages[errPanelOutput]);
		}
	}
	else if (input.name == "panelefficiency") {
		if (!validPanelDegredation()) {
			setToolTipError(errorMessages[errPanelDegradation]);
		}
	}
	else if (input.name == "inverterefficiency") {
		if (!validInverterEfficiency()) {
			setToolTipError(errorMessages[errInverterEfficiency]);
		}
	}
	
	//Location ToolTips
	else if (input.name == "state") {
		//if (!validMonthlyConsumption()) {
			//setToolTipError(errorMessages[errMonthlyConsumption]);
		//}
	}
	else if (input.name == "daylighthours") {
		if (!validDaylightHours()) {
			setToolTipError(errorMessages[errDaylighthours]);
		}
	}
	else if (input.name == "temperature") {
		if (!validTemperature()) {
			setToolTipError(errorMessages[errTemperature]);
		}
	}
	
	//Rates ToolTips
	else if (input.name == "exportrate") {
		if (!validExportRate()) {
			setToolTipError(errorMessages[errExportRate]);
		}
	}
	
	
}


function setToolTipError(msg) {
	document.getElementById("divtooltiperror").innerHTML = msg;
}