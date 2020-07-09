package DAO;
import model.*;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.*;
public class studentDao  extends BaseDao{
        public ArrayList<Grade> getGrade(String no){
        	String sql="select wangj_Cname04,wangj_Ccredit04,wangj_Tname04,wangj_grade04,wangj_xq04 \r\n" + 
        			"from wangjiaMIS04.dbo.wangj_course04,wangjiaMIS04.dbo.wangj_teacher04,wangjiaMIS04.dbo.wangj_Grade04 \r\n" + 
        			"where wangjiaMIS04.dbo.wangj_Grade04.wangj_Sno04=? and wangjiaMIS04.dbo.wangj_Grade04.wangj_Cno04=wangjiaMIS04.dbo.wangj_course04.wangj_Cno04 and wangjiaMIS04.dbo.wangj_Grade04.wangj_Tno04=wangjiaMIS04.dbo.wangj_teacher04.wangj_Tno04";
        	Connection conn;
        	ArrayList<Grade> g=new ArrayList<Grade>();
			try {
				conn = dataSource.getConnection();
				PreparedStatement pstmt=conn.prepareCall(sql);
			    pstmt.setString(1, no);
			    ResultSet rst=pstmt.executeQuery();
			    while(rst.next()) {
			    	Grade a=new Grade();
			    	a.setCname(rst.getString("wangj_Cname04"));
			    	a.setXf(rst.getFloat("wangj_Ccredit04"));
			    	a.setTname(rst.getString("wangj_Tname04"));
			    	a.setGrade(rst.getFloat("wangj_grade04"));
			    	a.setTime(rst.getString("wangj_xq04"));
			    	g.add(a);
			    }
			    conn.close();rst.close();
			    return g;
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
				return null;
			}
        }
        public stud getP(String no) {
        	String sql="select * from wangjiaMIS04.dbo.wangj_student04 where wangj_Sno04=?";
        	try {
        		stud s=new stud();
				Connection conn=dataSource.getConnection();
				PreparedStatement pstmt=conn.prepareCall(sql);
			    pstmt.setString(1, no);
			    ResultSet rst=pstmt.executeQuery();
			    if(rst.next()) {
			    	s.setSno(rst.getString("wangj_Sno04"));
			    	s.setSname(rst.getString("wangj_Sname04"));
			    	s.setCredit(rst.getFloat("wangj_Scredit04"));
			    	s.setSex(rst.getString("wangj_Ssex04"));
			    	s.setAge(rst.getInt("wangj_Sage04"));
			    	s.setArea(rst.getString("wangj_area04"));
			    }
			    conn.close();rst.close();
			    return s;
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();return null;
			}
        }
        public String getC(String no) {
        	String Class=null;
        	String sql="select wangj_no04 from wangjiaMIS04.dbo.wangj_fb04 where wangj_Sno04=?";
        	try {
				Connection conn=dataSource.getConnection();
				PreparedStatement pstmt=conn.prepareCall(sql);
				pstmt.setString(1, no);ResultSet rst=pstmt.executeQuery();
				if(rst.next()) {
					Class=rst.getString("wangj_no04");
				}
				return Class;
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();return null;
			}
        }
        public ArrayList<course> getCc(String no) {
        	String sql="select wangj_Cname04,wangj_Ccredit04,wangj_Tname04,wangj_xq04 from wangjiaMIS04.dbo.wangj_xk04,wangjiaMIS04.dbo.wangj_course04,wangjiaMIS04.dbo.wangj_teacher04 where wangj_no04=? and wangjiaMIS04.dbo.wangj_xk04.wangj_Cno04=wangjiaMIS04.dbo.wangj_course04.wangj_Cno04 and wangjiaMIS04.dbo.wangj_xk04.wangj_Tno04=wangjiaMIS04.dbo.wangj_teacher04.wangj_Tno04";
        	ArrayList<course> c=new ArrayList<course>();
        	try {
				Connection conn=dataSource.getConnection();
				PreparedStatement pstmt=conn.prepareCall(sql);
				pstmt.setString(1, no);ResultSet rst=pstmt.executeQuery();
				while(rst.next()) {
					course co=new course();
					co.setCname(rst.getString("wangj_Cname04"));
					co.setCredit(rst.getString("wangj_Ccredit04"));
					co.setTname(rst.getString("wangj_Tname04"));
					co.setTime(rst.getString("wangj_xq04"));
					c.add(co);
				}
				conn.close();
				rst.close();
				return c;
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();return null;
			}
        }
        public boolean xiugai(String no,String ps) {
        	try {
				Connection conn=dataSource.getConnection();
				CallableStatement cstmt = conn.prepareCall("{call wangjiaMIS04.dbo.xiugai(?,?)}");
				cstmt.setString(1,no);
				cstmt.setString(2, ps);
				cstmt.executeUpdate();
				return true;
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();return false;
			}
        }
}
