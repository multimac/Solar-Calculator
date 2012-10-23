<?xml version="1.0" ?><%@ page contentType="text/xml;charset=ISO-8859-1" %>
<%@ page import="validation.Validator"%>
<%@ page import="java.util.List" %>
<%@ page import="com.google.appengine.api.datastore.DatastoreServiceFactory" %>
<%@ page import="com.google.appengine.api.datastore.DatastoreService" %>
<%@ page import="com.google.appengine.api.datastore.Query" %>
<%@ page import="com.google.appengine.api.datastore.Entity" %>
<%@ page import="com.google.appengine.api.datastore.FetchOptions" %>
<%@ page import="com.google.appengine.api.datastore.Key" %>
<%@ page import="com.google.appengine.api.datastore.KeyFactory" %>
<%@ page import="com.google.appengine.api.datastore.Query.FilterOperator" %><%
//Process input
String Name = "";
int MeanRoofTempW = 0;
int MeanRoofTempS = 0;
double SolarInsolationW = 0;
double SolarInsolationS = 0;
double ImportTariff = 0;
double ExportTariff = 0;
double DaylightHoursW = 0;
double DaylightHoursS = 0;

String error = "noerror";

if ((request.getParameter("name") != "") && (request.getParameter("name") != null)) {
	Name = request.getParameter("name");
	
	Key appKey = KeyFactory.createKey("SolarPowerCalculator", "SolarPowerCalculator");
    DatastoreService datastore = DatastoreServiceFactory.getDatastoreService();
    
	Query query = new Query("StateData", appKey).addFilter("Name", FilterOperator.EQUAL, Name);
    List<Entity> rows = datastore.prepare(query).asList(FetchOptions.Builder.withDefaults());
	
    if (!rows.isEmpty()) {
	    
	    Entity row = rows.get(0);
	    
	    //for (Entity row : rows) {
	    	//row.getProperty("Name");
	    //}
	    
	    MeanRoofTempW = Integer.parseInt(row.getProperty("MeanRoofTempW").toString());
	    MeanRoofTempS = Integer.parseInt(row.getProperty("MeanRoofTempS").toString());
	    SolarInsolationW = Double.parseDouble(row.getProperty("SolarInsolationW").toString());
	    SolarInsolationS = Double.parseDouble(row.getProperty("SolarInsolationS").toString());
	    ImportTariff = Double.parseDouble(row.getProperty("ImportTariff").toString());
	    ExportTariff = Double.parseDouble(row.getProperty("ExportTariff").toString());
	    DaylightHoursW = Double.parseDouble(row.getProperty("DaylightHoursW").toString());
	    DaylightHoursS = Double.parseDouble(row.getProperty("DaylightHoursS").toString());
    
	}
    else {
    	error = "No data for that city: " + Name;
    }
    
}

%><solarcalculator>
	<name><%out.print(Name);%></name>
	<meanrooftempw><%out.print(MeanRoofTempW);%></meanrooftempw>
	<meanrooftemps><%out.print(MeanRoofTempS);%></meanrooftemps>
	<solarinsolationw><%out.print(SolarInsolationW);%></solarinsolationw>
	<solarinsolations><%out.print(SolarInsolationS);%></solarinsolations>
	<importtariff><%out.print(ImportTariff);%></importtariff>
	<exporttariff><%out.print(ExportTariff);%></exporttariff>
	<daylighthoursw><%out.print(DaylightHoursW);%></daylighthoursw>
	<daylighthourss><%out.print(DaylightHoursS);%></daylighthourss>
	<error><%out.print(error);%></error>
</solarcalculator>