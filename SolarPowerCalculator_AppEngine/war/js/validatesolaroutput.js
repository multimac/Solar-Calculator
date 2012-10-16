
var errorMessages = ["Number of panels should be a number between 1 and 50.",
                     "Monthly consumption should be a number between 0 and 1000.",
                     "Panel Output should be a number between 50 and 500.",
                     "Panel Degradation should be a number between 0 and 100.",
                     "Inverter Efficiency should be a number between 1 and 100.",
                     "Daylight Hours should be a number between 1 and 24.",
                     "Temperature should be a number between -10 and 50.",
                     "Export Tariff should be a number between 0.01 and 1."
                    ];

const errNumPanels = 0;
const errMonthlyConsumption = 1;
const errPanelOutput = 2;
const errPanelDegradation = 3;
const errInverterEfficiency = 4;
const errDaylighthours = 5;
const errTemperature = 6;
const errExportRate = 7;

//Main function calling validation rules
function formValidation() {
	
	
	
	
	var inputError = false;
	var errorList = new Array();
	
	if(!validNumPanels()) {
		inputError = true;
		errorList.push("<li>" + errorMessages[errNumPanels] + "</li>");
	}
	
	if(!validMonthlyConsumption()) {
		inputError = true;
		errorList.push("<li>" + errorMessages[errMonthlyConsumption] + "</li>");
	}
	
	
	
	if (!validPanelOutput()) {
		inputError = true;
		errorList.push("<li>" + errorMessages[errPanelOutput] + "</li>");
	}
	
	if (!validPanelDegredation()) {
		inputError = true;
		errorList.push("<li>" + errorMessages[errPanelDegradation] + "</li>");
	}
	
	if (!validInverterEfficiency()) {
		inputError = true;
		errorList.push("<li>" + errorMessages[errInverterEfficiency] + "</li>");
	}
	
	
	
	if (!validDaylightHours()) {
		inputError = true;
		errorList.push("<li>" + errorMessages[errDaylighthours] + "</li>");
	}
	
	if (!validTemperature()) {
		inputError = true;
		errorList.push("<li>" + errorMessages[errTemperature] + "</li>");
	}
	
	if (!validExportRate()) {
		inputError = true;
		errorList.push("<li>" + errorMessages[errExportRate] + "</li>");
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

function validPanelDegredation() {
	var panelDegredation = document.output.panelefficiency.value;
	if ((panelDegredation >= 0) && (panelDegredation <= 100) && isNaN(panelDegredation) == false) {
		return true;
	}
	return false;
}

function validInverterEfficiency() {
	var inverterEfficiency = document.output.inverterefficiency.value;
	if ((inverterEfficiency >= 1) && (inverterEfficiency <= 100) && isNaN(inverterEfficiency) == false) {
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