package controller;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import DAO.*;
import DAO.*;

/**
 * Servlet implementation class tzh
 */
@WebServlet("/tzh.do")
public class tzh extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public tzh() {
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
		teacherDao sd=new teacherDao();
		loginDao ld=new loginDao();
		String p0=request.getParameter("p0");
		String p1=request.getParameter("p1");
		String p2=request.getParameter("p2");
		HttpSession session=request.getSession();
		String user=(String)session.getAttribute("user");
		if(ld.checkP(user, p0)) {
		if(!p1.equals(p2)) {
			out.println("<script> alert(\"两次密码不一致\");window.location.href='signup.jsp' </script>");
		}
		else {
			if(sd.xiugai(user, p1))out.println("<script> alert(\"修改成功，请重新登录\");window.location.href='loginout.do' </script>");
			else out.println("<script> alert(\"修改失败，请重试\");window.location.href='signup1.jsp' </script>");
		}
		}
		else out.println("<script> alert(\"密码错误\");window.location.href='signup1.jsp' </script>");
	}

}
