package controller;

import java.io.IOException;
import java.io.PrintWriter;
import java.util.ArrayList;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import DAO.teacherDao;
import model.avgc;

@WebServlet("/gradep.do")
public class gradep extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public gradep() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
    
    private void sort(ArrayList<avgc> az) {
    	for(int i=0;i<az.size()-1;i++) {
    		for(int j=i+1;j<az.size();j++) {
    			if(az.get(i).getGrade()<az.get(j).getGrade()) {
    				float t=az.get(j).getGrade();
    				String tm=az.get(j).getCno();
    				az.get(j).setCno(az.get(i).getCno());
    				az.get(j).setGrade(az.get(i).getGrade());
    				az.get(i).setCno(tm);
    				az.get(i).setGrade(t);
    			}
    		}
    	}
    }
    
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		request.setCharacterEncoding("UTF-8");
		response.setCharacterEncoding("UTF-8");
		response.setContentType("text/html;charset=utf-8");
		PrintWriter out=response.getWriter();
		teacherDao td=new teacherDao();
		HttpSession session=request.getSession();
		session.setAttribute("pm", td.getzf());
		request.getRequestDispatcher("pm.jsp").forward(request, response);
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request, response);
	}

}
