package controller;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import DAO.teacherDao;

/**
 * Servlet implementation class grade3
 */
@WebServlet("/Grade3.do")
public class grade3 extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public grade3() {
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
		HttpSession session=request.getSession();
		String user=(String) session.getAttribute("user");
		String sno=request.getParameter("sno");
		String cno=request.getParameter("cno");
		String grade=request.getParameter("grade");
		float g=Float.parseFloat(grade);
		float xf=0;
		xf=td.getxf(cno);
		if(td.insertgrade(sno, cno, user, g, xf)) {
			out.println("<script> alert(\"录入成功\");window.location.href='grade3.jsp' </script>");
		}
		else out.println("<script> alert(\"录入失败\");window.location.href='grade3.jsp' </script>");
	}

}
