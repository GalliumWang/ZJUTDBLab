package controller;
import DAO.*;
import java.io.*;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

/**
 * Servlet implementation class loginServlet
 */
@WebServlet("/login.do")//接受登录请求的API
public class loginServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public loginServlet() {
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
		
		PrintWriter out=response.getWriter();//用于返回结果的alert输出
		
		loginDao ld=new loginDao();
		String user=request.getParameter("user");
		String ps=request.getParameter("password");
		int k=0;k=ld.check(user);
		if(k!=0) {
			if(ld.checkP(user, ps)) {//登录信息检验完成
				HttpSession session=request.getSession();
			    session.setAttribute("user", user);
			    String name=null;
				if(k==1) {
					name=ld.getSname(user);
					name+="同学";
					session.setAttribute("name", name);
					request.getRequestDispatcher("student.jsp").forward(request, response);//跳转学生界面
				}
				else if(k==2) {
					name=ld.getTname(user);
					name+="老师";
					session.setAttribute("name", name);
					if(ld.checkZ(user))request.getRequestDispatcher("zr.jsp").forward(request, response);//跳转老师界面
					else request.getRequestDispatcher("teacher.jsp").forward(request, response);//跳转管理员界面
				}
			
			}
			else out.println("<script> alert(\"密码错误，请重试\");window.location.href='/dbdesign/login/login.html' </script>");
		}
		else out.println("<script> alert(\"账户不存在，请重试\");window.location.href='/dbdesign/login/login.html' </script>");
	}

}
