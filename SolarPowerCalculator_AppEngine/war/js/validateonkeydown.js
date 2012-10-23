
function validateOnKeyDown(input) {
	
	var toolTipBox = document.getElementById("grossoutput")
	
	setToolTipError("");
	
	//System Configuration ToolTips
	if (input.name == "panelcount") {
		if (!validNumPanels()) {
			setToolTipError(errorMessages[errNumPanels]);
		}
	}
	else if (input.name == "monthlyconsumptions" || input.name == "monthlyconsumptionw") {
		if (!validMonthlyConsumption(input.value)) {
			setToolTipError(errorMessages[errMonthlyConsumption]);
		}
	}
	//System Statistics ToolTips
	else if (input.name == "paneloutput") {
		if (!validPanelOutput()) {
			setToolTipError(errorMessages[errPanelOutput]);
		}
	}
	
	else if (input.name == "paneldensity") {
		if (!validPanelDensity()) {
			setToolTipError(errorMessages[errPanelDensity]);
		}
	}
	
	else if (input.name == "solarinsolations" || input.name == "solarinsolationw") {
		if (!validSolarInsolation(input.value)) {
			setToolTipError(errorMessages[errSolarInsolation]);
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

	else if (input.name == "daylighthourss" || input.name == "daylighthoursw") {
		if (!validDaylightHours(input.value)) {
			setToolTipError(errorMessages[errDaylighthours]);
		}
	}
	else if (input.name == "rooftemps" || input.name == "rooftempw") {
		if (!validRoofTemperature(input.value)) {
			setToolTipError(errorMessages[errTemperature]);
		}
	}
	
	//Rates ToolTips
	else if (input.name == "exporttariff") {
		if (!validExportRate()) {
			setToolTipError(errorMessages[errExportRate]);
		}
	}
	
	else if (input.name == "importtariff") {
		if (!validImportRate()) {
			setToolTipError(errorMessages[errImportTariff]);
		}
	}
	
}


function setToolTipError(msg) {
	document.getElementById("divtooltiperror").innerHTML = msg;
}