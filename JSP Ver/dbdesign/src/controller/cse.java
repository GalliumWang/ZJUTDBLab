package controller;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import DAO.teacherDao;
import model.cours;

/**
 * Servlet implementation class cse
 */
@WebServlet("/cse.do")
public class cse extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public cse() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		response.getWriter().append("Served at: ").append(request.getContextPath());
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		request.setCharacterEncoding("UTF-8");
		response.setCharacterEncoding("UTF-8");
		response.setContentType("text/html;charset=utf-8");
		PrintWriter out=response.getWriter();
		teacherDao td=new teacherDao();
		String cno=request.getParameter("cno");
		String cname=request.getParameter("cname");
		String credit=request.getParameter("credit");
		String time=request.getParameter("time");
		String xq=request.getParameter("xq");
		String type=request.getParameter("type");
		int t=Integer.parseInt(type);
		float cre=Float.parseFloat(credit);
		float tim=Float.parseFloat(time);
		cours c=new cours();
		c.setCname(cname);
		c.setCno(cno);
		c.setCredit(cre);
		c.setTime(tim);
		c.setType(t);
		c.setXq(xq);
		if(td.incourse(c)) {
			out.println("<script> alert(\"添加成功\");window.location.href='signup3.jsp' </script>");
		}
		else out.println("<script> alert(\"添加失败\");window.location.href='signup3.jsp' </script>");
	}

}
