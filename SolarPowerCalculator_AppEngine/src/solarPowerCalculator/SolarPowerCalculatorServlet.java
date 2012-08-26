package solarPowerCalculator;

import java.io.IOException;
import javax.servlet.http.*;

@SuppressWarnings("serial")
public class SolarPowerCalculatorServlet extends HttpServlet {
    @Override
    public void doGet(HttpServletRequest req, HttpServletResponse resp) throws IOException {
		
        resp.setContentType("text/html");//html all over that bitch
        
        resp.getWriter().println("<html><body>");
        
        //outout all request info yo
        //resp.getWriter().println(req.toString());
   
        //Output field1 (get method)
        resp.getWriter().println("<b>GET</b> parameter field1: " + req.getParameter("field1") + "<br><br>");
        
        //test get and post forms
        resp.getWriter().println("<form method=\"get\"><input type=\"text\" name=\"field1\"><input type=\"submit\"></form>");
        resp.getWriter().println("<form method=\"post\"><input type=\"text\" name=\"field2\"><input type=\"submit\"></form>");
        
        resp.getWriter().println("</body></html>");
        
    }
    
    @Override
    public void doPost(HttpServletRequest req, HttpServletResponse resp) throws IOException {
    	
    	resp.setContentType("text/html");//html all over that bitch
        
        resp.getWriter().println("<html><body>");
        
        //outout all request info yo
        //resp.getWriter().println(req.toString());
        
        //output field2 (post method)
        resp.getWriter().println("<b>POST</b> parameter field2: " + req.getParameter("field2") + "<br><br>");
        
        //test get and post forms
        resp.getWriter().println("<form method=\"get\"><input type=\"text\" name=\"field1\"><input type=\"submit\"></form>");
        resp.getWriter().println("<form method=\"post\"><input type=\"text\" name=\"field2\"><input type=\"submit\"></form>");
        
        resp.getWriter().println("</body></html>");

    }
}
