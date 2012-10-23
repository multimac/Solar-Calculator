function postPowerCalc() {
	
	var url = "http://" + window.location.host + "/calcxml.jsp";
	
	var params = "";
	params += "panelcount=" + encodeURIComponent(document.getElementsByName("panelcount")[0].value);
	params += "paneloutput=" + encodeURIComponent(document.getElementsByName("paneloutput")[0].value);
	params += "paneldensity=" + encodeURIComponent(document.getElementsByName("paneldensity")[0].value);
	params += "panelefficiency=" + encodeURIComponent(document.getElementsByName("panelefficiency")[0].value);
	params += "inverterefficiency=" + encodeURIComponent(document.getElementsByName("inverterefficiency")[0].value);
	
	params += "daylighthoursw=" + encodeURIComponent(document.getElementsByName("daylighthoursw")[0].value);
	params += "daylighthourss=" + encodeURIComponent(document.getElementsByName("daylighthourss")[0].value);
	
	params += "monthlyconsumptionw=" + encodeURIComponent(document.getElementsByName("monthlyconsumptionw")[0].value);
	params += "monthlyconsumptions=" + encodeURIComponent(document.getElementsByName("monthlyconsumptions")[0].value);
	
	params += "exporttariff=" + encodeURIComponent(document.getElementsByName("exporttariff")[0].value);
	params += "importtariff=" + encodeURIComponent(document.getElementsByName("importtariff")[0].value);
	
	params += "rooftempw=" + encodeURIComponent(document.getElementsByName("rooftempw")[0].value);
	params += "rooftemps=" + encodeURIComponent(document.getElementsByName("rooftemps")[0].value);
	
	params += "solarinsolationw=" + encodeURIComponent(document.getElementsByName("solarinsolationw")[0].value);
	params += "solarinsolations=" + encodeURIComponent(document.getElementsByName("solarinsolations")[0].value);
	
	params += "&nocache=" + encodeURIComponent(new Date().getTime());
	
	
	var xmlhttp = gethtmlRequest();
	if (xmlhttp != null) {
		xmlhttp.onreadystatechange=function() {
			if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
				alert("a");
				var xmldata = xmlhttp.responseXML;
				var x = xmldata.getElementsByTagName('solarcalculator');
				
				
				var grossmonthlyoutputw = x[0].getElementsByTagName('grossmonthlyoutputw')[0].firstChild.nodeValue;
				var grossmonthlyoutputs = x[0].getElementsByTagName('grossmonthlyoutputs')[0].firstChild.nodeValue;
				var monlthysavingsw = x[0].getElementsByTagName('monlthysavingsw')[0].firstChild.nodeValue;
				var monlthysavingss = x[0].getElementsByTagName('monlthysavingss')[0].firstChild.nodeValue;
				var firstyearoutput = x[0].getElementsByTagName('firstyearoutput')[0].firstChild.nodeValue;
				var firstyearsavings = x[0].getElementsByTagName('firstyearsavings')[0].firstChild.nodeValue;
				var systemcost = x[0].getElementsByTagName('systemcost')[0].firstChild.nodeValue;
				var breakeventime = x[0].getElementsByTagName('breakeventime')[0].firstChild.nodeValue;
				var error = x[0].getElementsByTagName('error')[0].firstChild.nodeValue;
				
				if (error == "noerror") {
					
					//Check box options
					var optionPower = document.getElementsByName("optionpower")[0].checked;
					var optionRevenue = document.getElementsByName("optionrevenue")[0].checked;
					var optionCost = document.getElementsByName("optioncost")[0].checked;
					var optionBreakEven = document.getElementsByName("optionbreakeven")[0].checked;
					
					
					
					
					
					
					
					/*
					if (optionPower) {
						document.getElementById("divgrossoutput").innerHTML = "<b>Gross Monthly Generation: </b>" + grossOutput + " (Kwh)";
						document.getElementById("divnetoutput").innerHTML = "<b>Monthly Excess Generated: </b>" + netOutput + " (Kwh)";
					}
					
					if (optionCost) {
						document.getElementById("divcostoutput").innerHTML = "<b>Cost: </b>$" + cost;
					}
					
					if (optionRevenue) {
						document.getElementById("divrevenueoutput").innerHTML = "<b>Revenue: </b>$" + revenue + " mo";
					}
					if (optionBreakEven) {
						document.getElementById("divbreakevenoutput").innerHTML = "<b>Break Even: </b> " + breakEven;
					}*/
					
					document.getElementById("diverroroutput").innerHTML = "";
				}
				else {
					document.getElementById("divgrossoutput").innerHTML = "";
					document.getElementById("divgrossoutput").innerHTML = "";
					document.getElementById("divcostoutput").innerHTML = "";
					document.getElementById("divrevenueoutput").innerHTML = "";
					document.getElementById("diverroroutput").innerHTML = "<b>The following errors occured during calculation: </b><br/>" + error;
				}
			}
		}
		
		xmlhttp.open("POST", url, true);
		
		xmlhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
		xmlhttp.setRequestHeader("Content-length", params.length);
		xmlhttp.setRequestHeader("Connection", "close");
		
		xmlhttp.send(params);
	}
	
	return false;
}



function gethtmlRequest() {
	if (window.XMLHttpRequest) {
		return new XMLHttpRequest();
	}
	else {//IE6, IE5
		return new ActiveXObject("Microsoft.XMLHTTP");
	}
	return null;
}

