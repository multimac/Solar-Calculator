//Placeholder file for javascript validation

//Main function calling validation rules
function formValidation() {
	
	var inputError = false;
	var errorList = new Array();
	
	if(!validNumPanels()) {
		inputError = true;
		errorList.push("<li>Number of panels should be a number greater than 0.</li>");
	}
	
	if (!validDaylightHours()){
		inputError = true;
		errorList.push("<li>Daylight hours should be a number between 0 and 24.</li>");
	}
	
	if(!validMonthlyConsumption()) {
		inputError = true;
		errorList.push("<li>Monthly consumption should be a number greater than or equal to 0.</li>");
	}
	
	
	if (!validPanelOutput()) {
		inputError = true;
		errorList.push("<li>Panel Output should be a number greather than 0.</li>");
	}
	
	if (!validPercentage(document.output.panelefficiency.value)) {
		inputError = true;
		errorList.push("<li>Panel Efficiency should be a number between 0 and 100.</li>");
	}
	
	if (!validPercentage(document.output.inverterefficiency.value)) {
		inputError = true;
		errorList.push("<li>Inverter Efficiency should be a number between 0 and 100.</li>");
	}
	
	// Error Handling: outputs all errors that occured
	if (inputError == true) {
		
		var errorBoxStart = '<div id="error"><h3>The following errors occured during calculation:</h3><ul>';
		var errorBoxEnd = "</ul></div>";
		var errorString = "";
		
		for (errorIndex in errorList) {
		
			errorString += errorList[errorIndex];
		
		}
		document.getElementById("divrevenueoutput").innerHTML = errorBoxStart + errorString + errorBoxEnd;
		return false;
	}
	else {
	
		return true;

	}
}

//Validation functions
//Function to validate daylight hours, no negatives, between 0 and 24
function validDaylightHours() {
	
	var dlh_val = document.output.daylighthours.value;
	if(isNaN(dlh_val) == false) {
		if ((dlh_val >= 0) || (dlh_val < 24)) {
			return true;
		}
	}
	return false;
}

function validNumPanels() {
	var numPanels = document.output.numpanels.value;
	if (numPanels > 0 && isNaN(numPanels) == false) {
		return true;
	}
	return false;
}

function validMonthlyConsumption() {
	var MonthlyConsumption = document.output.monthlyconsumption.value;
	if (MonthlyConsumption >= 0 && isNaN(MonthlyConsumption) == false) {
		return true;
	}
	return false;
	
}


function validPanelOutput() {
	var panelOutput = document.output.paneloutput.value;
	if (panelOutput > 0 && isNaN(panelOutput) == false) {
		return true;
	}
	return false;
}


function validPercentage(value) {
	
	return (value >= 0 && value <= 100);
}