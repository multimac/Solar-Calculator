
var errorMessages = ["Number of panels should be a number between 1 and 50.",
                     "Monthly consumption should be a number between 0 and 1000.",
                     "Panel Output should be a number between 50 and 500.",
                     "Panel Degradation should be a number between 0 and 4.",
                     "Inverter Efficiency should be a number between 1 and 100.",
                     "Daylight Hours should be a number between 1 and 24.",
                     "Roof Temperature should be a number between -40 and 80.",
                     "Export Tariff should be a number between 0.01 and 1.",
                     "Panel Density should be a number between 10 and 1000",
                     "Solar Insolation should be a number between 0 and 20",
                     "Import Tariff should be a number between 0.01 and 1.",
                     "Temperature Coefficient should be a number between -0.01 and -0.001",
                     "Panel Efficiency should be a number between 1 - 25"
                    ];

const errNumPanels = 0;
const errMonthlyConsumption = 1;
const errPanelOutput = 2;
const errPanelDegradation = 3;
const errInverterEfficiency = 4;
const errDaylighthours = 5;
const errTemperature = 6;
const errExportRate = 7;
const errPanelDensity = 8;
const errSolarInsolation = 9;
const errImportTariff = 10;
const errTempCoefficient = 11;
const errPanelEfficiency = 12;

//Main function calling validation rules
function formValidation() {
	
	var inputError = false;
	var errorList = new Array();
	
	if(!validNumPanels()) {
		inputError = true;
		errorList.push("<li>" + errorMessages[errNumPanels] + "</li>");
	}
	
	if(!validMonthlyConsumption(document.output.monthlyconsumptions.value) || !validMonthlyConsumption(document.output.monthlyconsumptionw.value)) {
		inputError = true;
		errorList.push("<li>" + errorMessages[errMonthlyConsumption] + "</li>");
	}
		
	
	if (!validPanelOutput()) {
		inputError = true;
		errorList.push("<li>" + errorMessages[errPanelOutput] + "</li>");
	}
	
	if (!validPanelDensity()) {
		inputError = true;
		errorList.push("<li>" + errorMessages[errPanelDensity] + "</li>")
	}
	
	if (!validInverterEfficiency()) {
		inputError = true;
		errorList.push("<li>" + errorMessages[errInverterEfficiency] + "</li>");
	}
	
	if (!validPanelEfficiency()) {
		inputError = true;
		errorList.push("<li>" + errorMessage[errPanelEfficiency] + "</li>");
	}
	
	if (!validPanelDegrdation()) {
		inputError = true;
		errorList.push("<li>" + errorMessages[errPanelDegradation] + "</li>");
	}
	
	if (!validSolarInsolation(document.output.solarinsolations.value) || !validSolarInsolation(document.output.solarinsolationw.value)) {
		inputError = true;
		errorList.push("<li>" + errorMessage[errSolarInsolation] + "</li>");
	}

	if (!validDaylightHours(document.output.daylighthourss.value) || !validDaylightHours(document.output.daylighthoursw.value)) {
		inputError = true;
		errorList.push("<li>" + errorMessages[errDaylighthours] + "</li>");
	}
	
	if (!validRoofTemperature(document.output.rooftemps.value) || !validRoofTemperature(document.output.rooftempw.value)) {
		inputError = true;
		errorList.push("<li>" + errorMessages[errTemperature] + "</li>");
	}

	
	if (!validExportRate()) {
		inputError = true;
		errorList.push("<li>" + errorMessages[errExportRate] + "</li>");
	}
	
	if (!validImportRate()) {
		inputError = true;
		errorList.push("<li>" + errorMessage[errImportTariff] + "</li>");
	}
	
	if (!validTempCoefficient()) {
		inputError = true;
		errorList.push("<li>" + errorMessage[errTempCoefficient] + "</li>");
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
function validPanelEfficiency() {
	var panelEfficiency = document.output.panelefficiency.value;
	if (panelEfficiency >= 1 && panelEfficiency <= 25 && isNaN(panelEfficiency) == false) {
		return true;
	}
	return false;
}


function validNumPanels() {
	var numPanels = document.output.panelcount.value;
	if ((numPanels > 0) && (numPanels <= 50) && (isNaN(numPanels) == false)) {
		return true;
	}
	return false;
}

function validMonthlyConsumption(MonthlyConsumption) {

	if ((MonthlyConsumption >= 0) && (MonthlyConsumption <= 1000) && (isNaN(MonthlyConsumption) == false)) {
		return true;
	}
	return false;
}

function validTempCoefficient() {
	var temp = document.output.tempcoefficient.value;
	if ((temp >= -0.01) && (temp <= -0.001) && isNaN(temp) == false) {
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

function validPanelDegradation() {
	var panelDegradation = document.output.paneldegradation.value;
	if ((panelDegradation >= 0) && (panelDegradation <= 4) && isNaN(panelDegradation) == false) {
		return true;
	}
	return false;
}

function validPanelDensity() {
	var panelDensity = document.output.paneldensity.value;
	if ((panelDensity >= 10) && (panelDensity <= 1000) && isNaN(panelDensity) == false) {
		return true;
	}
	return false;
}

function validInverterEfficiency() {
	var inverterEfficiency = document.output.inverterefficiency.value;
	if ((inverterEfficiency >= 0) && (inverterEfficiency <= 100) && isNaN(inverterEfficiency) == false) {
		return true;
	}
	return false;
}

function validSolarInsolation(solarInsolation) {
	if ((solarInsolation >= 0) && (solarInsolation <= 20) && isNaN(solarInsolation) == false) {
		return true;
	}
	return false;
}


function validDaylightHours(daylighthours) {

	if ((daylighthours >= 1) && (daylighthours <= 24) && isNaN(daylighthours) == false) {
		return true;
	}
	return false;
}

function validRoofTemperature(temperature) {

	if ((temperature >= -40) && (temperature <= 80) && isNaN(temperature) == false) {
		return true;
	}
	return false;
}



function validExportRate() {
	var exporttariff = document.output.exporttariff.value;
	if ((exporttariff >= 0.01) && (exporttariff <= 1) && isNaN(exporttariff) == false) {
		return true;
	}
	return false;
}

function validImportRate() {
	var importtariff = document.output.importtariff.value;
	if ((importtariff >= 0.01) && (importtariff <= 1) && isNaN(importtariff) == false) {
		return true;
	}
	return false;
}


function validPercentage(value) {
	return (value >= 0 && value <= 100);
}