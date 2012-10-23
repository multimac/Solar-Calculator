package solarPowerCalculator;

import java.io.IOException;
import java.util.List;

import javax.servlet.http.*;

import com.google.appengine.api.datastore.DatastoreService;
import com.google.appengine.api.datastore.DatastoreServiceFactory;
import com.google.appengine.api.datastore.Entity;
import com.google.appengine.api.datastore.FetchOptions;
import com.google.appengine.api.datastore.Key;
import com.google.appengine.api.datastore.KeyFactory;
import com.google.appengine.api.datastore.Query;

@SuppressWarnings("serial")
public class SolarPowerCalculatorServlet extends HttpServlet {
    @Override
    public void doGet(HttpServletRequest req, HttpServletResponse resp) throws IOException {
    	
    	//Get User Data from header
    	String userAgent = req.getHeader("User-Agent");
    	
    	//If User Data contains Android or iPhone, redirect to mobile version
    	if (userAgent.contains("Android") || userAgent.contains("iPhone")) {
    		//Print Header info, for debugging
    		/*resp.setContentType("text/plain");
        	resp.getWriter().println(req.getHeader("User-Agent"));*/
    		
    		//Redirect to mobile version
    		resp.sendRedirect("indexm.jsp");
    	}
    	else {
    		//Redirect to desktop version
    		resp.sendRedirect("index.jsp");
    	}
    	
    }
    
    @Override
    public void doPost(HttpServletRequest req, HttpServletResponse resp) throws IOException {
    	
    	//Get User Data from header
    	String userAgent = req.getHeader("User-Agent");
    	
    	//If User Data contains Android or iPhone, redirect to mobile version
    	if (userAgent.contains("Android") || userAgent.contains("iPhone")) {
    		//Print Header info, for debugging
    		/*resp.setContentType("text/plain");
        	resp.getWriter().println(req.getHeader("User-Agent"));*/
    		
    		//Redirect to mobile version
    		resp.sendRedirect("indexm.jsp");
    	}
    	else {
    		//Redirect to desktop version
    		resp.sendRedirect("index.jsp");
    	}
    	
    }
}
