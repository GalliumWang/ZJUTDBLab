package DAO;
import java.sql.*;
import java.text.SimpleDateFormat;
import javax.sql.*;
import java.util.*;

public class loginDao extends BaseDao{

	//检查用户编号是否存在
	public int check(String no) {
		try {
			String sql="select wangj_Sno04 from wangjiaMIS04.dbo.wangj_Suser04 where wangj_Sno04=?";
			Connection conn = dataSource.getConnection();
			PreparedStatement pstmt=conn.prepareCall(sql);
			pstmt.setString(1, no);
			
			ResultSet rst=pstmt.executeQuery();
			if(rst.next()) {
				rst.close();
				conn.close();
			    return 1;
			}
			sql="select wangj_Tno04 from wangjiaMIS04.dbo.wangj_Tuser04 where wangj_Tno04=?";
			pstmt=conn.prepareCall(sql);
			pstmt.setString(1, no);
			rst=pstmt.executeQuery();
			if(rst.next()) {
				rst.close();
				conn.close();
				return 2;
			}
			rst.close();
			conn.close();
		    return 0;
		}
		catch(SQLException e) {
			e.printStackTrace();
			return 0;
		}
	}
	
	//检查编号对应的密码
	public boolean checkP(String no,String password) {
		try {
			String password1;
			String sql="select * from wangjiaMIS04.dbo.wangj_Suser04 where wangj_Sno04=?";
			Connection conn = dataSource.getConnection();
			PreparedStatement pstmt=conn.prepareCall(sql);
			pstmt.setString(1, no);
			ResultSet rst=pstmt.executeQuery();
			if(rst.next()) {
			password1=rst.getString("wangj_password04");
			if(password1.equals(password)) {
				rst.close();
				conn.close();
				return true;
			}
			else {
				rst.close();
				conn.close();
				return false;
			}
			}
			sql="select * from wangjiaMIS04.dbo.wangj_Tuser04 where wangj_Tno04=?";
			pstmt=conn.prepareCall(sql);
			pstmt.setString(1, no);
			rst=pstmt.executeQuery();
			if(rst.next()){
				password1=rst.getString("wangj_password04");
				if(password1.equals(password)) {
					rst.close();
					conn.close();
					return true;
				}
			}
			rst.close();
			conn.close();
			return false;
		}
		catch(SQLException e) {
			e.printStackTrace();
			return false;
		}
	}
	
	//检查某个教师编号对应的职务是否为主任
	public boolean checkZ(String no) {
		try {
			String zw;
			String sql="select wangj_zw04 from wangjiaMIS04.dbo.wangj_teacher04 where wangj_Tno04=? ";
			Connection conn = dataSource.getConnection();
			PreparedStatement pstmt=conn.prepareCall(sql);
			pstmt.setString(1, no);
			ResultSet rst=pstmt.executeQuery();
			if(rst.next()) {
			zw=rst.getString("wangj_zw04");
			if(zw.equals("主任      ")) {
				rst.close();
				conn.close();
				return true;
			}
			}
			rst.close();
			conn.close();
			return false;
		}
		catch(SQLException e) {
			e.printStackTrace();
			return false;
		}
	}
	
	//获取教师名字
	public String getTname(String no) {
		try {
			String name=null;
			String sql="select wangj_Tname04 from wangjiaMIS04.dbo.wangj_teacher04 where wangj_Tno04=? ";
			Connection conn = dataSource.getConnection();
			PreparedStatement pstmt=conn.prepareCall(sql);
			pstmt.setString(1, no);
			ResultSet rst=pstmt.executeQuery();
			if(rst.next()) {
			name=rst.getString("wangj_Tname04");
			}
			rst.close();
			conn.close();
			return name;
		}
		catch(SQLException e) {
			e.printStackTrace();
			return null;
		}
	}
	
	//获取学生名字
	public String getSname(String no) {
		try {
			String name=null;
			String sql="select wangj_Sname04 from wangjiaMIS04.dbo.wangj_student04 where wangj_Sno04=? ";
			Connection conn = dataSource.getConnection();
			PreparedStatement pstmt=conn.prepareCall(sql);
			pstmt.setString(1, no);
			ResultSet rst=pstmt.executeQuery();
			if(rst.next()) {
			name=rst.getString("wangj_Sname04");
			}
			rst.close();
			conn.close();
			return name;
		}
		catch(SQLException e) {
			e.printStackTrace();
			return null;
		}
	}
}
