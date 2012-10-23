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
double MeanRoofTempW = 0;
double MeanRoofTempS = 0;
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
	    
	    MeanRoofTempW = Double.parseDouble(row.getProperty("MeanRoofTempW").toString());
	    MeanRoofTempS = Double.parseDouble(row.getProperty("MeanRoofTempS").toString());
	    SolarInsolationW = Double.parseDouble(row.getProperty("SolarInsolationW").toString());
	    SolarInsolationS = Double.parseDouble(row.getProperty("SolarInsolationS").toString());
	    ImportTariff = Double.parseDouble(row.getProperty("ImportTariff").toString());
	    ExportTariff = Double.parseDouble(row.getProperty("ExportTariff").toString());
	    DaylightHoursW = Double.parseDouble(row.getProperty("DaylightHoursW").toString());
	    DaylightHoursS = Double.parseDouble(row.getProperty("DaylightHoursS").toString());
    
	}
    else {
    	error = "No data for that city";
    }
    
}

%><solarcalculator><name><%out.print(Name);%></name><meanRooftempW><%out.print(MeanRoofTempW);%></meanRooftempW><meanRooftempS><%out.print(MeanRoofTempS);%></meanRooftempS><solarinsolationW><%out.print(SolarInsolationW);%></solarinsolationW><solarinsolationS><%out.print(SolarInsolationS);%></solarinsolationS><importtariff><%out.print(ImportTariff);%></importtariff><ewxporttariff><%out.print(ExportTariff);%></ewxporttariff><daylighthoursW><%out.print(DaylightHoursW);%></daylighthoursW><daylighthoursS><%out.print(DaylightHoursS);%></daylighthoursS><error><%out.print(error);%></error></solarcalculator>