package solarPowerCalculator;

import java.io.IOException;

import javax.servlet.http.*;

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
