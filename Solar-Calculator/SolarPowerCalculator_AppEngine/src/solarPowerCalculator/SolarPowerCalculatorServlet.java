package solarPowerCalculator;

import java.io.IOException;
import javax.servlet.http.*;

@SuppressWarnings("serial")
public class SolarPowerCalculatorServlet extends HttpServlet {
    @Override
    public void doGet(HttpServletRequest req, HttpServletResponse resp) throws IOException {
		
    	//server up the output file
    	resp.sendRedirect("/output.jsp");
        
    }
    
    @Override
    public void doPost(HttpServletRequest req, HttpServletResponse resp) throws IOException {
    	
    	//Test Code >>
    	resp.setContentType("text/html");
        
        resp.getWriter().println("<html><body>");
        
        //outout all request info
        //resp.getWriter().println(req.toString());
        
        //output field2 (post method)
        resp.getWriter().println("<b>POST</b> parameter field2: " + req.getParameter("field2") + "<br><br>");
        
        //test get and post forms
        resp.getWriter().println("<form method=\"get\"><input type=\"text\" name=\"field1\"><input type=\"submit\"></form>");
        resp.getWriter().println("<form method=\"post\"><input type=\"text\" name=\"field2\"><input type=\"submit\"></form>");
        
        resp.getWriter().println("</body></html>");

    }
}
