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
@WebServlet("/login.do")//���ܵ�¼�����API
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
		
		PrintWriter out=response.getWriter();//���ڷ��ؽ����alert���
		
		loginDao ld=new loginDao();
		String user=request.getParameter("user");
		String ps=request.getParameter("password");
		int k=0;k=ld.check(user);
		if(k!=0) {
			if(ld.checkP(user, ps)) {//��¼��Ϣ�������
				HttpSession session=request.getSession();
			    session.setAttribute("user", user);
			    String name=null;
				if(k==1) {
					name=ld.getSname(user);
					name+="ͬѧ";
					session.setAttribute("name", name);
					request.getRequestDispatcher("student.jsp").forward(request, response);//��תѧ������
				}
				else if(k==2) {
					name=ld.getTname(user);
					name+="��ʦ";
					session.setAttribute("name", name);
					if(ld.checkZ(user))request.getRequestDispatcher("zr.jsp").forward(request, response);//��ת��ʦ����
					else request.getRequestDispatcher("teacher.jsp").forward(request, response);//��ת����Ա����
				}
			
			}
			else out.println("<script> alert(\"�������������\");window.location.href='/dbdesign/login/login.html' </script>");
		}
		else out.println("<script> alert(\"�˻������ڣ�������\");window.location.href='/dbdesign/login/login.html' </script>");
	}

}
