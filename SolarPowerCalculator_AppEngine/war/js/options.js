



function showInput() {
	return;
	//Check box options
	var optionPower = document.getElementsByName("optionpower")[0].checked;
	var optionRevenue = document.getElementsByName("optionrevenue")[0].checked;
	var optionCost = document.getElementsByName("optioncost")[0].checked;
	var optionBreakEven = document.getElementsByName("optionbreakeven")[0].checked;
	
	//Extract form divs to collapse
	var divnumpanels = document.getElementById("panelcount");
	var divdaylighthourss = document.getElementById("divdaylighthourss");
	var divdaylighthoursw = document.getElementById("divdaylighthoursw");
	var divmonthlyconsumptions = document.getElementById("divmonthlyconsumptions"); //todo
	var divmonthlyconsumptionw = document.getElementById("divmonthlyconsumptionw"); //todo
	
	var paneloutput = document.getElementById("paneloutput");
	var divpaneldensity = document.getElementById("divpaneldensity"); //todo
	var panelefficiency = document.getElementById("divpanelefficiency");
	var divsolarinsolations = document.getElementById("divsolarinsolations"); //todo
	var divsolarinsolationw = document.getElementById("divsolarinsolationw"); //todo
	var inverterefficiency = document.getElementById("divinverterefficiency");
	
	//Location
	var divcity = document.getElementById("divcity");
	var divdaylighthourss = document.getElementById("divdaylighthourss");
	var divdaylighthoursw = document.getElementById("divdaylighthoursw");
	var divrooftemps = document.getElementById("divrooftemps");
	var divrooftempw = document.getElementById("divrooftempw");
	
	//Output
	var divgrossmonthlyoutputw = document.getElementById("divgrossmonthlyoutputw");
	var divgrossmonthlyoutputs = document.getElementById("divgrossmonthlyoutputs");
	var divmonlthysavingsw = document.getElementById("divmonlthysavingsw");
	var divmonlthysavingss = document.getElementById("divmonlthysavingss");
	var divfirstyearoutput = document.getElementById("divfirstyearoutput");
	var divfirstyearsavings = document.getElementById("divfirstyearsavings");
	var divsystemcost = document.getElementById("divsystemcost");
	var divbreakeventime = document.getElementById("divbreakeventime");
	
	//Tariff
	var divimporttariff = document.getElementById("divimporttariff");
	var divexporttariff = document.getElementById("divexporttariff");
	
	//Hide all divs
	divnumpanels.style.display = 'none';
	divdaylighthourss.style.display = 'none';
	divdaylighthoursw.style.display = 'none';
	divmonthlyconsumptions.style.display = 'none';
	divmonthlyconsumptionw.style.display = 'none';
	
	paneloutput.style.display = 'none';
	divpaneldensity.style.display = 'none';
	panelefficiency.style.display = 'none';
	divsolarinsolations.style.display = 'none';
	divsolarinsolationw.style.display = 'none';
	inverterefficiency.style.display = 'none';
	
	//Location
	divcity.style.display = 'none';
	divdaylighthourss.style.display = 'none';
	divdaylighthoursw.style.display = 'none';
	divrooftemps.style.display = 'none';
	divrooftempw.style.display = 'none';
	
	hideOutput();
	
	//Tariffs
	divimporttariff.style.display = 'none';
	divexporttariff.style.display = 'none';
	
	//Show divs depending on checkbox options
	
	//System Configuration//
	
	//divnumpanels
	if ((optionPower) || (optionRevenue) || (optionCost) || (optionBreakEven)) {
		divnumpanels.style.display = '';
	}
	
	//divmonthlyconsumption
	if ((optionPower) || (optionRevenue) || (optionBreakEven)) {
		divmonthlyconsumptions.style.display = '';
		divmonthlyconsumptionw.style.display ='';
	}
	
	
	
	//System Statistics//
	
	//paneloutput
	if ((optionPower) || (optionRevenue) || (optionCost) || (optionBreakEven)) {
		paneloutput.style.display = '';
	}
	
	//panelefficiency
	if (optionPower) {
		panelefficiency.style.display = '';
	}
	
	//inverterefficiency
	if (optionPower) {
		inverterefficiency.style.display = '';
	}
	
	
	
	//Location//
	
	//divcity
	if ((optionRevenue) || (optionBreakEven)) {
		divcity.style.display = '';
	}
	
	//divlighthours
	if ((optionPower) || (optionRevenue) || (optionBreakEven)) {
		divdaylighthourss.style.display = '';
		divdaylighthoursw.style.display = '';
	}
	
	//divtemperature
	if ((optionPower) || (optionRevenue) || (optionBreakEven)) {
		divrooftemps.style.display = '';
		divrooftempw.style.display = '';
	}
	
	
	
	//Rates//
	
	//divtarrifs
	if ((optionRevenue) || (optionBreakEven)) {
		divexporttariff.style.display = '';
		divimporttariff.style.display = '';
	}
	
	
	divgrossmonthlyoutputw.style.display = '';
	divgrossmonthlyoutputs.style.display = '';
	divmonlthysavingsw.style.display = '';
	divmonlthysavingss.style.display = '';
	divfirstyearoutput.style.display = '';
	divfirstyearsavings.style.display = '';
	divsystemcost.style.display = '';
	divbreakeventime.style.display = '';
}


function hideOutput() {
	
	var divgrossmonthlyoutputw = document.getElementById("divgrossmonthlyoutputw");
	var divgrossmonthlyoutputs = document.getElementById("divgrossmonthlyoutputs");
	var divmonlthysavingsw = document.getElementById("divmonlthysavingsw");
	var divmonlthysavingss = document.getElementById("divmonlthysavingss");
	var divfirstyearoutput = document.getElementById("divfirstyearoutput");
	var divfirstyearsavings = document.getElementById("divfirstyearsavings");
	var divsystemcost = document.getElementById("divsystemcost");
	var divbreakeventime = document.getElementById("divbreakeventime");

	divgrossmonthlyoutputw.style.display = 'none';
	divgrossmonthlyoutputs.style.display = 'none';
	divmonlthysavingsw.style.display = 'none';
	divmonlthysavingss.style.display = 'none';
	divfirstyearoutput.style.display = 'none';
	divfirstyearsavings.style.display = 'none';
	divsystemcost.style.display = 'none';
	divbreakeventime.style.display = 'none';
}