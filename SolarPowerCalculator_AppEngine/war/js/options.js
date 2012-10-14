



function showInput() {
	//Check box options
	var optionPower = document.getElementsByName("optionpower")[0].checked;
	var optionRevenue = document.getElementsByName("optionrevenue")[0].checked;
	var optionCost = document.getElementsByName("optioncost")[0].checked;
	var optionBreakEven = document.getElementsByName("optionbreakeven")[0].checked;
	
	//Extract form divs to collapse
	var divnumpanels = document.getElementById("divnumpanels");
	var divlighthours = document.getElementById("divlighthours");
	var divmonthlyconsumption = document.getElementById("divmonthlyconsumption");
	
	var paneloutput = document.getElementById("divpaneloutput");
	var panelefficiency = document.getElementById("divpanelefficiency");
	var inverterefficiency = document.getElementById("divinverterefficiency");
	
	//Output
	var divgrossoutput = document.getElementById("divgrossoutput");
	var divnetoutput = document.getElementById("divnetoutput");
	var divcostoutput = document.getElementById("divcostoutput");
	//var divrevenueoutput = document.getElementById("divrevenueoutput");
	var diverroroutput = document.getElementById("diverroroutput");
	var divbreakevenoutput = document.getElementById("divbreakevenoutput");
	
	//Hide all divs
	divnumpanels.style.display = 'none';
	divmonthlyconsumption.style.display = 'none';
	divpaneloutput.style.display = 'none';
	divpanelefficiency.style.display = 'none';
	divinverterefficiency.style.display = 'none';
	divstate.style.display = 'none';
	divlighthours.style.display = 'none';
	divtemperature.style.display = 'none';
	divexportrate.style.display = 'none';
	divbreakevenoutput.style.display = 'none';
	
	//Show divs depending on checkbox options
	
	//System Configuration//
	
	//divnumpanels
	if ((optionPower) || (optionRevenue) || (optionCost) || (optionBreakEven)) {
		divnumpanels.style.display = '';
	}
	
	//divmonthlyconsumption
	if ((optionPower) || (optionRevenue) || (optionBreakEven)) {
		divmonthlyconsumption.style.display = '';
	}
	
	
	
	//System Statistics//
	
	//paneloutput
	if ((optionPower) || (optionRevenue) || (optionCost) || (optionBreakEven)) {
		divpaneloutput.style.display = '';
	}
	
	//panelefficiency
	if (optionPower) {
		divpanelefficiency.style.display = '';
	}
	
	//inverterefficiency
	if (optionPower) {
		divinverterefficiency.style.display = '';
	}
	
	
	
	//Location//
	
	//divstate
	if ((optionRevenue) || (optionBreakEven)) {
		divstate.style.display = '';
	}
	
	//divlighthours
	if ((optionPower) || (optionRevenue) || (optionBreakEven)) {
		divlighthours.style.display = '';
	}
	
	//divtemperature
	if ((optionPower) || (optionRevenue) || (optionBreakEven)) {
		divtemperature.style.display = '';
	}
	
	
	
	//Rates//
	
	//divstate
	if ((optionRevenue) || (optionBreakEven)) {
		divexportrate.style.display = '';
	}
	
	
	
	if (optionPower) {
		divgrossoutput.style.display = '';
		divnetoutput.style.display = '';
	}
	else {
		divgrossoutput.style.display = 'none';
		divnetoutput.style.display = 'none';
	}
	
	if (optionCost) {
		divcostoutput.style.display = '';
	}
	else {
		divcostoutput.style.display = 'none';
	}
	
	if (optionRevenue) {
		divrevenueoutput.style.display = '';
	}
	else {
		divrevenueoutput.style.display = 'none';
	}
	
	if (optionBreakEven) {
		divbreakevenoutput.style.display = '';
	}
	else {
		divbreakevenoutput.style.display = 'none';
	}
}


function hideOuput() {
	
	//Output
	var divgrossoutput = document.getElementById("divgrossoutput");
	var divnetoutput = document.getElementById("divnetoutput");
	var divcostoutput = document.getElementById("divcostoutput");
	//var divrevenueoutput = document.getElementById("divrevenueoutput");
	var diverroroutput = document.getElementById("diverroroutput");
	var divbreakevenoutput = document.getElementById("divbreakevenoutput");
	
	
	divgrossoutput.style.display = 'none';
	divnetoutput.style.display = 'none';
	divcostoutput.style.display = 'none';
	divrevenueoutput.style.display = 'none';
	divbreakevenoutput.style.display = 'none';
}