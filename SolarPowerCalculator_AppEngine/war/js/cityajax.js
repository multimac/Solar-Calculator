function postCity() {
	
	var url = "http://" + window.location.host + "/cityxml.jsp";
	
	var params = "";
	params += "name=" + encodeURIComponent(document.getElementsByName("city")[0].value);
	params += "&nocache=" + encodeURIComponent(new Date().getTime());
	
	
	var xmlhttp = gethtmlRequest();
	if (xmlhttp != null) {
		xmlhttp.onreadystatechange=function() {
			if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
				
				var xmldata = xmlhttp.responseXML;
				var x = xmldata.getElementsByTagName('solarcalculator');
				var MeanRoofTempW = x[0].getElementsByTagName('meanrooftempw')[0].firstChild.nodeValue;
				var MeanRoofTempS = x[0].getElementsByTagName('meanrooftemps')[0].firstChild.nodeValue;
				var SolarInsolationW = x[0].getElementsByTagName('solarinsolationw')[0].firstChild.nodeValue;
				var SolarInsolationS = x[0].getElementsByTagName('solarinsolations')[0].firstChild.nodeValue;
				var ImportTariff = x[0].getElementsByTagName('importtariff')[0].firstChild.nodeValue;
				var ExportTariff = x[0].getElementsByTagName('exporttariff')[0].firstChild.nodeValue;
				var DaylightHoursW = x[0].getElementsByTagName('daylighthoursw')[0].firstChild.nodeValue;
				var DaylightHoursS = x[0].getElementsByTagName('daylighthourss')[0].firstChild.nodeValue;
				var error = x[0].getElementsByTagName('error')[0].firstChild.nodeValue;
				
				
				if (error == "noerror") {
					document.output.daylighthoursw.value = DaylightHoursW;
					document.output.daylighthourss.value = DaylightHoursS;
					document.output.daylighthoursw.value = DaylightHoursW;
					document.output.daylighthourss.value = DaylightHoursS;
					document.output.rooftemps.value = MeanRoofTempS;
					document.output.rooftempw.value = MeanRoofTempW;
					document.output.importtariff.value = ImportTariff;
					document.output.exporttariff.value = ExportTariff;
				}
				else {
					//alert(error);
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

