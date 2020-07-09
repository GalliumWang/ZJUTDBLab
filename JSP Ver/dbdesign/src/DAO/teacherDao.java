package DAO;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

import model.*;

public class teacherDao extends BaseDao{
	public ArrayList<tcourse> getC(String no) {
    	String sql="select wangj_no04,wangj_Cname04,wangj_Ccredit04,wangj_xq04 from wangjiaMIS04.dbo.wangj_xk04,wangjiaMIS04.dbo.wangj_course04,wangjiaMIS04.dbo.wangj_teacher04 where wangjiaMIS04.dbo.wangj_xk04.wangj_Tno04=? and wangjiaMIS04.dbo.wangj_xk04.wangj_Cno04=wangjiaMIS04.dbo.wangj_course04.wangj_Cno04 and wangjiaMIS04.dbo.wangj_xk04.wangj_Tno04=wangjiaMIS04.dbo.wangj_teacher04.wangj_Tno04";
    	ArrayList<tcourse> c=new ArrayList<tcourse>();
    	try {
			Connection conn=dataSource.getConnection();
			PreparedStatement pstmt=conn.prepareCall(sql);
			pstmt.setString(1, no);ResultSet rst=pstmt.executeQuery();
			while(rst.next()) {
				tcourse co=new tcourse();
				co.setCname(rst.getString("wangj_Cname04"));
				co.setCredit(rst.getString("wangj_Ccredit04"));
				co.setNo(rst.getString("wangj_no04"));
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
	public teacher getP(String no) {
    	String sql="select * from wangjiaMIS04.dbo.wangj_teacher04 where wangj_Tno04=?";
    	try {
    		teacher s=new teacher();
			Connection conn=dataSource.getConnection();
			PreparedStatement pstmt=conn.prepareCall(sql);
		    pstmt.setString(1, no);
		    ResultSet rst=pstmt.executeQuery();
		    if(rst.next()) {
		    	s.setTno(rst.getString("wangj_Tno04"));
		    	s.setTname(rst.getString("wangj_Tname04"));
		    	s.setTel(rst.getString("wangj_tel04"));
		    	s.setSex(rst.getString("wangj_Tsex04"));
		    	s.setAge(rst.getInt("wangj_Tage04"));
		    	s.setZc(rst.getString("wangj_zc04"));
		    	s.setZw(rst.getString("wangj_zw04"));
		    }
		    conn.close();rst.close();
		    return s;
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();return null;
		}
    }
	public boolean xiugai(String no,String ps) {
		String sql="update wangjiaMIS04.dbo.wangj_Tuser04 set wangj_password04=? where wangj_Tno04=?";
				try {
					Connection conn=dataSource.getConnection();
					PreparedStatement pstmt=conn.prepareCall(sql);
					pstmt.setString(1, ps);
					pstmt.setString(2, no);
					pstmt.executeUpdate();
					conn.close();
					return true;
				} catch (SQLException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();return false;
				}
	}
	public boolean insertgrade(String sno,String cno,String tno,float grade,float xf) {
		String sql="insert into wangjiaMIS04.dbo.wangj_Grade04 values(?,?,?,?)";
		try {
			Connection conn=dataSource.getConnection();
			PreparedStatement pstmt=conn.prepareCall(sql);
			pstmt.setString(1,sno);
			pstmt.setString(2, cno);
			pstmt.setString(3, tno);
			pstmt.setFloat(4, grade);
			pstmt.executeUpdate();
			CallableStatement cstmt = conn.prepareCall("{call wangjiaMIS04.dbo.updatexf(?,'cno','tno',?,?)}");
			cstmt.setString(1, sno);
			cstmt.setFloat(2,xf);
			cstmt.setFloat(3, grade);
			cstmt.executeUpdate();
			conn.close();
			return true;
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();return false;
		}
	}
	public float getxf(String cno) {
		String sql="select wangj_Ccredit04 from wangjiaMIS04.dbo.wangj_course04 where wangj_Cno04=?";
		try {
			float a=0;
			Connection conn=dataSource.getConnection();
			PreparedStatement pstmt=conn.prepareCall(sql);
			pstmt.setString(1, cno);
			ResultSet rst=pstmt.executeQuery();
			if(rst.next()) {
				a+=rst.getFloat("wangj_Ccredit04");
				conn.close();rst.close();
				return a;
			}
			conn.close();rst.close();
			return 0;
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();return 0;
		}
	}
	public ArrayList<zy> getPrf(String name){
		String sql="select* from wangjiaMIS04.dbo.wangj_rgview04 where wangj_Pname04=?";
		String sq="select* from wangjiaMIS04.dbo.wangj_wgview04 where wangj_Pname04=?";
		ArrayList<zy> az=new ArrayList<zy>();
		try {
			PreparedStatement pstmt;
			Connection conn=dataSource.getConnection();
			if(name.equals("�ƿ�            "))
			 pstmt=conn.prepareCall(sq);
			else  pstmt=conn.prepareCall(sql);
			pstmt.setString(1,name);
			ResultSet rst=pstmt.executeQuery();
			while(rst.next()) {
				zy z=new zy();
				z.setNo(rst.getString("wangj_no04"));
				z.setSno(rst.getString("wangj_Sno04"));
				z.setPname(name);
				az.add(z);
			}
			conn.close();rst.close();
			return az;
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();return null;
		}
	}
	public ArrayList<avgc> getavg(){
		String sql="select* from wangjiaMIS04.dbo.cf";
		ArrayList<avgc> az=new ArrayList<avgc>();
		try {
			Connection conn=dataSource.getConnection();
			PreparedStatement pstmt=conn.prepareCall(sql);
			ResultSet rst=pstmt.executeQuery();
			while(rst.next()) {
				avgc a=new avgc();
				a.setCno(rst.getString("ID"));
				a.setGrade(rst.getFloat("sumary"));
				az.add(a);
			}
			conn.close();rst.close();
			return az;
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();return null;
		}
	}
	public ArrayList<model.zy> getzf(){
		String sql="select* from wangjiaMIS04.dbo.zf";
		ArrayList<model.zy> az=new ArrayList<model.zy>();
		try {
			Connection conn=dataSource.getConnection();
			PreparedStatement pstmt=conn.prepareCall(sql);
			ResultSet rst=pstmt.executeQuery();
			while(rst.next()) {
				zy a=new zy();
				a.setSno(rst.getString("wangj_Sno04"));
				a.setNo(rst.getString("wangj_Cno04"));
				a.setPname(rst.getString("rank"));
				az.add(a);
			}
			conn.close();rst.close();
			return az;
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();return null;
		}
	}
	
	
	public boolean incourse(cours c) {
		String sql="insert into wangjiaMIS04.dbo.wangj_course04 values(?,?,?,?,?,?)";
		try {
			Connection conn=dataSource.getConnection();
			PreparedStatement pstmt=conn.prepareCall(sql);
			pstmt.setString(1, c.getCno());
			pstmt.setString(2, c.getCname());
			pstmt.setFloat(3,c.getCredit());
			pstmt.setFloat(4, c.getTime());
			pstmt.setString(5, c.getXq());
			pstmt.setInt(6, c.getType());
			pstmt.executeUpdate();
			conn.close();
			return true;
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();return false;
		}
	}
	public boolean xcourse(String no,String cno,String  tno) {
		String sql="insert into wangjiaMIS04.dbo.wangj_xk04 values(?,?,?)";
		try {
			Connection conn=dataSource.getConnection();
			PreparedStatement pstmt=conn.prepareCall(sql);
			pstmt.setString(1, no);
			pstmt.setString(2, cno);
			pstmt.setString(3,tno);
			pstmt.executeUpdate();
			conn.close();
			return true;
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();return false;
		}
	}
	public ArrayList<xkr> getRs(){
		String sql="select* from wangjiaMIS04.dbo.wangj_xkview04";
		ArrayList<xkr> ak=new ArrayList<xkr>();
		try {
			Connection conn=dataSource.getConnection();
			PreparedStatement pstmt=conn.prepareCall(sql);
			ResultSet rst=pstmt.executeQuery();
			while(rst.next()) {
				xkr x=new xkr();
				x.setCname(rst.getString("wangj_Cname04"));
				x.setNo(rst.getString("wangj_no04"));
				x.setSname(rst.getString("wangj_Sname04"));
				x.setSno(rst.getString("wangj_Sno04"));
				x.setTname(rst.getString("wangj_Tname04"));
				ak.add(x);
			}
			conn.close();rst.close();
			return ak;
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();return null;
		}
	}
}

