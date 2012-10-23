
<%@ page contentType="text/xml;charset=ISO-8859-1" %>
<%@ page import="validation.Validator"%>
<%@ page import="java.util.List" %>
<%@ page import="com.google.appengine.api.datastore.DatastoreServiceFactory" %>
<%@ page import="com.google.appengine.api.datastore.DatastoreService" %>
<%@ page import="com.google.appengine.api.datastore.Query" %>
<%@ page import="com.google.appengine.api.datastore.Entity" %>
<%@ page import="com.google.appengine.api.datastore.FetchOptions" %>
<%@ page import="com.google.appengine.api.datastore.Key" %>
<%@ page import="com.google.appengine.api.datastore.KeyFactory" %>
<%@ page import="com.google.appengine.api.datastore.Query.FilterOperator" %>

<%      
/*
        Key appKey = KeyFactory.createKey("SolarPowerCalculator", "SolarPowerCalculator");
        
        DatastoreService datastore = DatastoreServiceFactory.getDatastoreService();
        
        Entity row = new Entity("StateData", appKey);
        row.setProperty("Name", "Brisbane");
        row.setProperty("MeanRoofTempW", "33");
        row.setProperty("MeanRoofTempS", "40");
        row.setProperty("SolarInsolationW", "4.07");
        row.setProperty("SolarInsolationS", "5.85");
        row.setProperty("ImportTariff", "0.25");
        row.setProperty("ExportTariff", "0.14");
        row.setProperty("DaylightHoursW", "7.5");
        row.setProperty("DaylightHoursS", "7.4");
        datastore.put(row);
        
        row = new Entity("StateData", appKey);
        row.setProperty("Name", "Sydney");
        row.setProperty("MeanRoofTempW", "30");
        row.setProperty("MeanRoofTempS", "37");
        row.setProperty("SolarInsolationW", "3.65");
        row.setProperty("SolarInsolationS", "5.69");
        row.setProperty("ImportTariff", "0.27");
        row.setProperty("ExportTariff", "0.13");
        row.setProperty("DaylightHoursW", "6.5");
        row.setProperty("DaylightHoursS", "7");
        datastore.put(row);
        
        row = new Entity("StateData", appKey);
        row.setProperty("Name", "Melbourne");
        row.setProperty("MeanRoofTempW", "27");
        row.setProperty("MeanRoofTempS", "37");
        row.setProperty("SolarInsolationW", "3.08");
        row.setProperty("SolarInsolationS", "5.41");
        row.setProperty("ImportTariff", "0.28");
        row.setProperty("ExportTariff", "0.28");
        row.setProperty("DaylightHoursW", "4.6");
        row.setProperty("DaylightHoursS", "7.3");
        datastore.put(row);
        
        row = new Entity("StateData", appKey);
        row.setProperty("Name", "Adelaide");
        row.setProperty("MeanRoofTempW", "29");
        row.setProperty("MeanRoofTempS", "40");
        row.setProperty("SolarInsolationW", "3.67");
        row.setProperty("SolarInsolationS", "6.15");
        row.setProperty("ImportTariff", "0.38");
        row.setProperty("ExportTariff", "0.16");
        row.setProperty("DaylightHoursW", "6");
        row.setProperty("DaylightHoursS", "9.2");
        datastore.put(row);
        
        row = new Entity("StateData", appKey);
        row.setProperty("Name", "Perth");
        row.setProperty("MeanRoofTempW", "31");
        row.setProperty("MeanRoofTempS", "42");
        row.setProperty("SolarInsolationW", "3.8");
        row.setProperty("SolarInsolationS", "6.31");
        row.setProperty("ImportTariff", "0.26");
        row.setProperty("ExportTariff", "0.13");
        row.setProperty("DaylightHoursW", "4.5");
        row.setProperty("DaylightHoursS", "7");
        datastore.put(row);
        
        row = new Entity("StateData", appKey);
        row.setProperty("Name", "Darwin");
        row.setProperty("MeanRoofTempW", "46");
        row.setProperty("MeanRoofTempS", "46");
        row.setProperty("SolarInsolationW", "5.57");
        row.setProperty("SolarInsolationS", "5.49");
        row.setProperty("ImportTariff", "0.23");
        row.setProperty("ExportTariff", "0.23");
        row.setProperty("DaylightHoursW", "9.8");
        row.setProperty("DaylightHoursS", "7");
        datastore.put(row);
        
        row = new Entity("StateData", appKey);
        row.setProperty("Name", "Canberra");
        row.setProperty("MeanRoofTempW", "26");
        row.setProperty("MeanRoofTempS", "39");
        row.setProperty("SolarInsolationW", "3.71");
        row.setProperty("SolarInsolationS", "6.06");
        row.setProperty("ImportTariff", "0.2");
        row.setProperty("ExportTariff", "0.2");
        row.setProperty("DaylightHoursW", "6");
        row.setProperty("DaylightHoursS", "9.2");
        datastore.put(row);*/
        %>