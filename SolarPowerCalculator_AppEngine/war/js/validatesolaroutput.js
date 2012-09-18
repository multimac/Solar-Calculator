//Placeholder file for javascript validation

//Main function calling validation rules
function formValidation() {
	
	var dlh = document.output.daylighthours;
	
	if (!daylight_validation(dlh)){
		return false;
	}
	return true;
}

//Validation functions
//Function to validate daylight hours, no negatives, between 0 and 24
function daylight_validation(dlh) {
	
	var dlh_val = document.output.daylighthours.value;

	if ((dlh_val == 0) || (dlh_val > 24)) {
		alert("Daylight hours must be greater than 0 and less than 24.")
		dlh.focus(); //Give focus to problem
		return false;
	}
	return true;
}