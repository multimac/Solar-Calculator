function postPowerCalc() {
	var url = "http://" + window.location.host + "/powercalcxml.jsp";
	
	var params = "";
	params += "numpanels=" + encodeURIComponent(document.getElementsByName("numpanels")[0].value);
	params += "&daylighthours=" + encodeURIComponent(document.getElementsByName("daylighthours")[0].value);
	params += "&hourlyusage=" + encodeURIComponent(document.getElementsByName("hourlyusage")[0].value);
	params += "&paneloutput=" + encodeURIComponent(document.getElementsByName("paneloutput")[0].value);
	params += "&panelefficiency=" + encodeURIComponent(document.getElementsByName("panelefficiency")[0].value);
	params += "&inverterefficiency=" + encodeURIComponent(document.getElementsByName("inverterefficiency")[0].value);
	params += "&nocache=" + encodeURIComponent(new Date().getTime());
	
	var xmlhttp = gethtmlRequest();
	if (xmlhttp != null) {
		xmlhttp.onreadystatechange=function() {
			if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
				var xmldata = xmlhttp.responseXML;
				var x = xmldata.getElementsByTagName('solorcalculator');
				
				var grossOutput = x[0].getElementsByTagName('grossoutput')[0].firstChild.nodeValue;
				var netOutput = x[0].getElementsByTagName('netoutput')[0].firstChild.nodeValue;
				var error = x[0].getElementsByTagName('error')[0].firstChild.nodeValue;
				
				document.getElementById("grossoutput").innerHTML = "<b>Gross Daily Output: </b>" + grossOutput + " Kwh";
				document.getElementById("netoutput").innerHTML = "<b>Net Daily Output: </b>" + netOutput + " Kwh";
				
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

function postCostCalc() {
	var url = "http://" + window.location.host + "/costcalcxml.jsp";
	
	var params = "";
	params += "numpanels=" + encodeURIComponent(document.getElementsByName("numpanels")[0].value);
	params += "&paneloutput=" + encodeURIComponent(document.getElementsByName("paneloutput")[0].value);
	params += "&nocache=" + encodeURIComponent(new Date().getTime());
	
	var xmlhttp = gethtmlRequest();
	if (xmlhttp != null) {
		xmlhttp.onreadystatechange=function() {
			if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
				var xmldata = xmlhttp.responseXML;
				var x = xmldata.getElementsByTagName('solorcalculator');
				
				var cost = x[0].getElementsByTagName('cost')[0].firstChild.nodeValue;
				
				document.getElementById("cost").innerHTML = "<b>Cost: </b>$" + cost;
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

