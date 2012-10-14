//Placeholder file for javascript validation

//Main function calling validation rules
function formValidation() {
	
	var inputError = false;
	var errorList = new Array();
	
	if(!validNumPanels()) {
		inputError = true;
		errorList.push("<li>Number of panels should be a number between 1 and 50.</li>");
	}
	
	if(!validMonthlyConsumption()) {
		inputError = true;
		errorList.push("<li>Monthly consumption should be a number between 0 and 1000.</li>");
	}
	
	
	
	if (!validPanelOutput()) {
		inputError = true;
		errorList.push("<li>Panel Output should be a number between 50 and 500.</li>");
	}
	
	if (!validPercentage(document.output.panelefficiency.value)) {
		inputError = true;
		errorList.push("<li>Panel Degradation should be a number between 0 and 100.</li>");
	}
	
	if (!validPercentage(document.output.inverterefficiency.value)) {
		inputError = true;
		errorList.push("<li>Inverter Efficiency should be a number between 0 and 100.</li>");
	}
	
	
	
	if (!validDaylightHours(document.output.daylighthours.value)) {
		inputError = true;
		errorList.push("<li>Daylight Hours should be a number between 1 and 24.</li>");
	}
	
	if (!validTemperature(document.output.temperature.value)) {
		inputError = true;
		errorList.push("<li>Temperature should be a number between -10 and 50.</li>");
	}
	
	if (!validExportRate(document.output.exportrate.value)) {
		inputError = true;
		errorList.push("<li>Export Tariff should be a number between 0.01 and 1.</li>");
	}
	
	
	// Error Handling: outputs all errors that occured
	if (inputError == true) {
		
		var errorBoxStart = '<div id="error"><h3>The following errors occured during calculation:</h3><ul>';
		var errorBoxEnd = "</ul></div>";
		var errorString = "";
		
		for (errorIndex in errorList) {
		
			errorString += errorList[errorIndex];
		
		}
		document.getElementById("diverroroutput").innerHTML = errorBoxStart + errorString + errorBoxEnd;
		return false;
	}
	else {
	
		return true;

	}
}

//Validation functions

function validNumPanels() {
	var numPanels = document.output.numpanels.value;
	if ((numPanels > 0) && (numPanels <= 50) && (isNaN(numPanels) == false)) {
		return true;
	}
	return false;
}

function validMonthlyConsumption() {
	var MonthlyConsumption = document.output.monthlyconsumption.value;
	if ((MonthlyConsumption >= 0) && (MonthlyConsumption <= 1000) && (isNaN(MonthlyConsumption) == false)) {
		return true;
	}
	return false;
	
}


function validPanelOutput() {
	var panelOutput = document.output.paneloutput.value;
	if ((panelOutput >= 50) && (panelOutput <= 500) && isNaN(panelOutput) == false) {
		return true;
	}
	return false;
}

function validDaylightHours() {
	var daylighthours = document.output.daylighthours.value;
	if ((daylighthours >= 1) && (daylighthours <= 24) && isNaN(daylighthours) == false) {
		return true;
	}
	return false;
}

function validTemperature() {
	var temperature = document.output.temperature.value;
	if ((temperature >= -10) && (temperature <= 50) && isNaN(temperature) == false) {
		return true;
	}
	return false;
}

function validExportRate() {
	var exportrate = document.output.exportrate.value;
	if ((exportrate >= 0.01) && (exportrate <= 1) && isNaN(exportrate) == false) {
		return true;
	}
	return false;
}


function validPercentage(value) {
	return (value >= 0 && value <= 100);
}