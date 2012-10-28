



function showInput() {
	return;
	//Check box options

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

function hideAdvancedInput() {
	var hiddenDiv = document.getElementById("hidden");
	var wasNull = false;
	if (hiddenDiv == null) {
		hiddenDiv = document.getElementById("unhidden")
		hiddenDiv.id = "hidden";
		wasNull = true;
	}
	if (hiddenDiv.id == "hidden" && wasNull == false) {
		hiddenDiv.id = "unhidden";
	}
	
	var hiddenDiv2 = document.getElementById("hidden2");
	var wasNull2 = false;
	if (hiddenDiv2 == null) {
		hiddenDiv2 = document.getElementById("unhidden2")
		hiddenDiv2.id = "hidden2";
		wasNull2 = true;
	}
	if (hiddenDiv2.id == "hidden2" && wasNull2 == false) {
		hiddenDiv2.id = "unhidden2";
	}


}