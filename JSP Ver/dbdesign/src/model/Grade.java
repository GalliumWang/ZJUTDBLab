package model;
public class Grade {
private String Cname;
private float xf;
private String Tname;
private float grade;
private String time;
public Grade() {}
public String getTime() {
	return time;
}
public void setTime(String time) {
	this.time = time;
}
public String getCname() {
	return Cname;
}
public void setCname(String cname) {
	Cname = cname;
}
public float getXf() {
	return xf;
}
public void setXf(float xf) {
	this.xf = xf;
}
public String getTname() {
	return Tname;
}
public void setTname(String tname) {
	Tname = tname;
}
public float getGrade() {
	return grade;
}
public void setGrade(float grade) {
	this.grade = grade;
}

}
