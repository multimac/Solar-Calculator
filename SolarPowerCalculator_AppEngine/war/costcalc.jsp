
<%@ page contentType="text/html" pageEncoding="UTF-8" language="java"%>
<%
//Default values, store in database instead
int numpanels = 2;
int paneloutput = 250;
%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
<head>
 <title>Solar Output Calculator</title>
 <link rel="stylesheet" type="text/css" href="css/mainstyle.css" />
 <script type="text/javascript" src="js/validatesolaroutput.js"></script>
 <script type="text/javascript" src="js/ajax.js"></script>
</head>
<body>

<div id="container">
<div id="template">
<img src="images/TA0.jpg" width="671" height="70" alt=""><img src="images/TB0.jpg" width="185" height="32" alt=""><a class="powercalclink" href="powercalc.jsp"></a><img src="images/TB1.jpg" width="10" height="32" alt=""><a class="costcalclink" href="costcalc.jsp"></a><img src="images/TB2.jpg" width="10" height="32" alt=""><a class="aboutlink" href="about.jsp"></a><img src="images/TB3.jpg" width="194" height="32" alt=""><img src="images/TC0.jpg" align="top" width="167" height="95" alt="">
<div class="inputtable">
<form name="output" action="costcalc.jsp" method="post" onSubmit="if (true) {postCostCalc();} return false;"> 
	<div class="systemconf">
		<div class="header"><b>System Configuration</b></div>
		<div class="labels">
			<span class="inputs">Number of Panels<input name="numpanels" value="<%=numpanels%>" /></span>
		</div>
	</div>
	<div class="systemstats">
		<div class="header"><b>System Statistics</b></div>
		<div class="labels">
			<span class="inputs">Panel Output W<input name="paneloutput" value="<%=paneloutput%>" /></span>
		</div>
	</div>
	<input type="submit" value="Calculate" class="calc"/>
	<div id="errorBox"></div>
	<div id="cost"></div>
	</form>
</div>
</div>
</div>

</body>
</html>