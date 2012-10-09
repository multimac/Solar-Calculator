function postPowerCalc() {

	var url = "http://" + window.location.host + "/calcxml.jsp";
	
	var params = "";
	params += "numpanels=" + encodeURIComponent(document.getElementsByName("numpanels")[0].value);
	params += "&monthlyconsumption=" + encodeURIComponent(document.getElementsByName("monthlyconsumption")[0].value);
	params += "&paneloutput=" + encodeURIComponent(document.getElementsByName("paneloutput")[0].value);
	params += "&panelefficiency=" + encodeURIComponent(document.getElementsByName("panelefficiency")[0].value);
	params += "&inverterefficiency=" + encodeURIComponent(document.getElementsByName("inverterefficiency")[0].value);
	params += "&state=" + encodeURIComponent(document.getElementsByName("state")[0].value);
	params += "&daylighthours=" + encodeURIComponent(document.getElementsByName("daylighthours")[0].value);
	params += "&temperature=" + encodeURIComponent(document.getElementsByName("temperature")[0].value);
	params += "&exportrate=" + encodeURIComponent(document.getElementsByName("exportrate")[0].value);
	params += "&nocache=" + encodeURIComponent(new Date().getTime());
	
	
	var xmlhttp = gethtmlRequest();
	if (xmlhttp != null) {
		xmlhttp.onreadystatechange=function() {
			if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
				
				var xmldata = xmlhttp.responseXML;
				var x = xmldata.getElementsByTagName('solarcalculator');
				
				var grossOutput = x[0].getElementsByTagName('grossoutput')[0].firstChild.nodeValue;
				var netOutput = x[0].getElementsByTagName('netoutput')[0].firstChild.nodeValue;
				var cost = x[0].getElementsByTagName('cost')[0].firstChild.nodeValue;
				var revenue = x[0].getElementsByTagName('revenue')[0].firstChild.nodeValue;
				var breakEven = x[0].getElementsByTagName('breakeven')[0].firstChild.nodeValue;
				var error = x[0].getElementsByTagName('error')[0].firstChild.nodeValue;
				
				if (error == "noerror") {
					//Check box options
					var optionPower = document.getElementsByName("optionpower")[0].checked;
					var optionRevenue = document.getElementsByName("optionrevenue")[0].checked;
					var optionCost = document.getElementsByName("optioncost")[0].checked;
					var optionBreakEven = document.getElementsByName("optionbreakeven")[0].checked;
					
					if (optionPower) {
						document.getElementById("divgrossoutput").innerHTML = "<b>Gross Daily Output: </b>" + grossOutput + " Kwh";
						document.getElementById("divnetoutput").innerHTML = "<b>Net Daily Output: </b>" + netOutput + " Kwh";
					}
					
					if (optionCost) {
						document.getElementById("divcostoutput").innerHTML = "<b>Cost: </b>$" + cost;
					}
					
					if (optionRevenue) {
						document.getElementById("divrevenueoutput").innerHTML = "<b>Revenue: </b>$" + revenue + " mo";
					}
					if (optionBreakEven) {
						document.getElementById("divbreakevenoutput").innerHTML = "<b>Break Even: </b> " + breakEven;
					}
					
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

