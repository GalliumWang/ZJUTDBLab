package DAO;
import java.sql.*;
import javax.sql.*;
import javax.naming.*;

//��sql server��������

public class BaseDao {
	DataSource dataSource;
	public BaseDao() {
		Context context;
		try {
			context = new InitialContext();
			dataSource=(DataSource)context.lookup("java:comp/env/jdbc/dbdesign");
		} catch (NamingException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	public Connection getConnection() throws SQLException {
		return dataSource.getConnection();
	}
}
