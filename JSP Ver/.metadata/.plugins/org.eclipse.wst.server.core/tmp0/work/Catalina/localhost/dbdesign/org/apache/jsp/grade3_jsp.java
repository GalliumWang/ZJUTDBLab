/*
 * Generated by the Jasper component of Apache Tomcat
 * Version: Apache Tomcat/9.0.36
 * Generated at: 2020-07-07 18:41:32 UTC
 * Note: The last modified time of this file was set to
 *       the last modified time of the source file after
 *       generation to assist with modification tracking.
 */
package org.apache.jsp;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.jsp.*;

public final class grade3_jsp extends org.apache.jasper.runtime.HttpJspBase
    implements org.apache.jasper.runtime.JspSourceDependent,
                 org.apache.jasper.runtime.JspSourceImports {

  private static final javax.servlet.jsp.JspFactory _jspxFactory =
          javax.servlet.jsp.JspFactory.getDefaultFactory();

  private static java.util.Map<java.lang.String,java.lang.Long> _jspx_dependants;

  private static final java.util.Set<java.lang.String> _jspx_imports_packages;

  private static final java.util.Set<java.lang.String> _jspx_imports_classes;

  static {
    _jspx_imports_packages = new java.util.HashSet<>();
    _jspx_imports_packages.add("javax.servlet");
    _jspx_imports_packages.add("javax.servlet.http");
    _jspx_imports_packages.add("javax.servlet.jsp");
    _jspx_imports_classes = null;
  }

  private volatile javax.el.ExpressionFactory _el_expressionfactory;
  private volatile org.apache.tomcat.InstanceManager _jsp_instancemanager;

  public java.util.Map<java.lang.String,java.lang.Long> getDependants() {
    return _jspx_dependants;
  }

  public java.util.Set<java.lang.String> getPackageImports() {
    return _jspx_imports_packages;
  }

  public java.util.Set<java.lang.String> getClassImports() {
    return _jspx_imports_classes;
  }

  public javax.el.ExpressionFactory _jsp_getExpressionFactory() {
    if (_el_expressionfactory == null) {
      synchronized (this) {
        if (_el_expressionfactory == null) {
          _el_expressionfactory = _jspxFactory.getJspApplicationContext(getServletConfig().getServletContext()).getExpressionFactory();
        }
      }
    }
    return _el_expressionfactory;
  }

  public org.apache.tomcat.InstanceManager _jsp_getInstanceManager() {
    if (_jsp_instancemanager == null) {
      synchronized (this) {
        if (_jsp_instancemanager == null) {
          _jsp_instancemanager = org.apache.jasper.runtime.InstanceManagerFactory.getInstanceManager(getServletConfig());
        }
      }
    }
    return _jsp_instancemanager;
  }

  public void _jspInit() {
  }

  public void _jspDestroy() {
  }

  public void _jspService(final javax.servlet.http.HttpServletRequest request, final javax.servlet.http.HttpServletResponse response)
      throws java.io.IOException, javax.servlet.ServletException {

    if (!javax.servlet.DispatcherType.ERROR.equals(request.getDispatcherType())) {
      final java.lang.String _jspx_method = request.getMethod();
      if ("OPTIONS".equals(_jspx_method)) {
        response.setHeader("Allow","GET, HEAD, POST, OPTIONS");
        return;
      }
      if (!"GET".equals(_jspx_method) && !"POST".equals(_jspx_method) && !"HEAD".equals(_jspx_method)) {
        response.setHeader("Allow","GET, HEAD, POST, OPTIONS");
        response.sendError(HttpServletResponse.SC_METHOD_NOT_ALLOWED, "JSP 只允许 GET、POST 或 HEAD。Jasper 还允许 OPTIONS");
        return;
      }
    }

    final javax.servlet.jsp.PageContext pageContext;
    javax.servlet.http.HttpSession session = null;
    final javax.servlet.ServletContext application;
    final javax.servlet.ServletConfig config;
    javax.servlet.jsp.JspWriter out = null;
    final java.lang.Object page = this;
    javax.servlet.jsp.JspWriter _jspx_out = null;
    javax.servlet.jsp.PageContext _jspx_page_context = null;


    try {
      response.setContentType("text/html; charset=UTF-8");
      pageContext = _jspxFactory.getPageContext(this, request, response,
      			null, true, 8192, true);
      _jspx_page_context = pageContext;
      application = pageContext.getServletContext();
      config = pageContext.getServletConfig();
      session = pageContext.getSession();
      out = pageContext.getOut();
      _jspx_out = out;

      out.write("\r\n");
      out.write("<!DOCTYPE HTML>\r\n");
      out.write("<html>\r\n");
      out.write("<head>\r\n");
      out.write("<title>欢迎您，老师</title>\r\n");
      out.write("<meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n");
      out.write("<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />\r\n");
      out.write("<meta name=\"keywords\" content=\"\" />\r\n");
      out.write("<script type=\"application/x-javascript\"> addEventListener(\"load\", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>\r\n");
      out.write("\r\n");
      out.write("<!-- Bootstrap Core CSS -->\r\n");
      out.write("<link href=\"css/bootstrap.css\" rel='stylesheet' type='text/css' />\r\n");
      out.write("\r\n");
      out.write("<!-- Custom CSS -->\r\n");
      out.write("<link href=\"css/style.css\" rel='stylesheet' type='text/css' />\r\n");
      out.write("\r\n");
      out.write("<!-- font-awesome icons CSS -->\r\n");
      out.write("<link href=\"css/font-awesome.css\" rel=\"stylesheet\"> \r\n");
      out.write("<!-- //font-awesome icons CSS -->\r\n");
      out.write("\r\n");
      out.write(" <!-- side nav css file -->\r\n");
      out.write(" <link href='css/SidebarNav.min.css' media='all' rel='stylesheet' type='text/css'/>\r\n");
      out.write(" <!-- side nav css file -->\r\n");
      out.write(" \r\n");
      out.write(" <!-- js-->\r\n");
      out.write("<script src=\"js/jquery-1.11.1.min.js\"></script>\r\n");
      out.write("<script src=\"js/modernizr.custom.js\"></script>\r\n");
      out.write("\r\n");
      out.write("<!--webfonts-->\r\n");
      out.write("<link href=\"http://fonts.googleapis.com/css?family=PT+Sans:400,400i,700,700i&amp;subset=cyrillic,cyrillic-ext,latin-ext\" rel=\"stylesheet\">\r\n");
      out.write("<!--//webfonts--> \r\n");
      out.write("\r\n");
      out.write("<!-- Metis Menu -->\r\n");
      out.write("<script src=\"js/metisMenu.min.js\"></script>\r\n");
      out.write("<script src=\"js/custom.js\"></script>\r\n");
      out.write("<link href=\"css/custom.css\" rel=\"stylesheet\">\r\n");
      out.write("<!--//Metis Menu -->\r\n");
      out.write("\r\n");
      out.write("</head> \r\n");
      out.write("<body class=\"cbp-spmenu-push\">\r\n");
      out.write("\t<div class=\"main-content\">\r\n");
      out.write("\t<div class=\"cbp-spmenu cbp-spmenu-vertical cbp-spmenu-left\" id=\"cbp-spmenu-s1\">\r\n");
      out.write("\t\t<!--left-fixed -navigation-->\r\n");
      out.write("\t\t<aside class=\"sidebar-left\">\r\n");
      out.write("      <nav class=\"navbar navbar-inverse\">\r\n");
      out.write("          <div class=\"navbar-header\">\r\n");
      out.write("            <button type=\"button\" class=\"navbar-toggle collapsed\" data-toggle=\"collapse\" data-target=\".collapse\" aria-expanded=\"false\">\r\n");
      out.write("            <span class=\"sr-only\">Toggle navigation</span>\r\n");
      out.write("            <span class=\"icon-bar\"></span>\r\n");
      out.write("            <span class=\"icon-bar\"></span>\r\n");
      out.write("            <span class=\"icon-bar\"></span>\r\n");
      out.write("            </button>\r\n");
      out.write("            <h1><a class=\"navbar-brand\" href=\"index.html\"><span class=\"fa fa-area-chart\"></span> 高校成绩<span class=\"dashboard_text\">管理系统</span></a></h1>\r\n");
      out.write("          </div>\r\n");
      out.write("          <div class=\"collapse navbar-collapse\" id=\"bs-example-navbar-collapse-1\">\r\n");
      out.write("            <ul class=\"sidebar-menu\">\r\n");
      out.write("              <li class=\"header\">导航栏</li>\r\n");
      out.write("              <li class=\"treeview\">\r\n");
      out.write("                <a href=\"#\">\r\n");
      out.write("                <i class=\"fa fa-table\"></i> <span>信息查询</span>\r\n");
      out.write("                <i class=\"fa fa-angle-left pull-right\"></i>\r\n");
      out.write("                </a>\r\n");
      out.write("                <ul class=\"treeview-menu\">\r\n");
      out.write("                  <li><a href=\"zcourse.do\"><i class=\"fa fa-angle-right\"></i> 任课查询</a></li>\r\n");
      out.write("                  <li><a href=\"pz.do\"><i class=\"fa fa-angle-right\"></i> 个人信息查询</a></li>\r\n");
      out.write("                </ul>\r\n");
      out.write("              </li>\r\n");
      out.write("              <li class=\"treeview\">\r\n");
      out.write("                <a href=\"grade3.jsp\">\r\n");
      out.write("                <i class=\"fa fa-edit\"></i> <span>录入成绩</span>\r\n");
      out.write("                <i class=\"fa fa-angle-left pull-right\"></i>\r\n");
      out.write("                </a>\r\n");
      out.write("              </li>\r\n");
      out.write("              <li class=\"treeview\">\r\n");
      out.write("                <a href=\"signup2.jsp\">\r\n");
      out.write("                <i class=\"fa fa-folder\"></i> <span>修改密码</span>\r\n");
      out.write("                <i class=\"fa fa-angle-left pull-right\"></i>\r\n");
      out.write("                </a>\r\n");
      out.write("              </li>\r\n");
      out.write("              <li class=\"treeview\">\r\n");
      out.write("                <a href=\"#\">\r\n");
      out.write("                <i class=\"fa fa-th\"></i> <span>专业分流</span>\r\n");
      out.write("                <i class=\"fa fa-angle-left pull-right\"></i>\r\n");
      out.write("                </a>\r\n");
      out.write("                <ul class=\"treeview-menu\">\r\n");
      out.write("                  <li><a href=\"pf.do?name=1\"><i class=\"fa fa-angle-right\"></i>软件工程</a></li>\r\n");
      out.write("                  <li><a href=\"pf.do>name=2\"><i class=\"fa fa-angle-right\"></i>网络工程</a></li>\r\n");
      out.write("                </ul>\r\n");
      out.write("              </li>\r\n");
      out.write("              <li class=\"treeview\">\r\n");
      out.write("                <a href=\"avg.do\">\r\n");
      out.write("                <i class=\"fa fa-th\"></i> <span>课程均绩</span>\r\n");
      out.write("                <i class=\"fa fa-angle-left pull-right\"></i>\r\n");
      out.write("                </a>\r\n");
      out.write("              </li>\r\n");
      out.write("              <li class=\"treeview\">\r\n");
      out.write("                <a href=\"gradep.do\">\r\n");
      out.write("                <i class=\"fa fa-table\"></i> <span>成绩排名</span>\r\n");
      out.write("                <i class=\"fa fa-angle-left pull-right\"></i>\r\n");
      out.write("                </a>\r\n");
      out.write("              </li>\r\n");
      out.write("              <li class=\"treeview\">\r\n");
      out.write("                <a href=\"signup3.jsp\">\r\n");
      out.write("                <i class=\"fa fa-edit\"></i> <span>开课</span>\r\n");
      out.write("                <i class=\"fa fa-angle-left pull-right\"></i>\r\n");
      out.write("                </a>\r\n");
      out.write("              </li>\r\n");
      out.write("              <li class=\"treeview\">\r\n");
      out.write("                <a href=\"xk.jsp\">\r\n");
      out.write("                <i class=\"fa fa-edit\"></i> <span>选课</span>\r\n");
      out.write("                <i class=\"fa fa-angle-left pull-right\"></i>\r\n");
      out.write("                </a>\r\n");
      out.write("              </li>\r\n");
      out.write("              <li class=\"treeview\">\r\n");
      out.write("                <a href=\"xkr.do\">\r\n");
      out.write("                <i class=\"fa fa-th\"></i> <span>选课结果</span>\r\n");
      out.write("                <i class=\"fa fa-angle-left pull-right\"></i>\r\n");
      out.write("                </a>\r\n");
      out.write("              </li>\r\n");
      out.write("            </ul>\r\n");
      out.write("          </div>\r\n");
      out.write("          <!-- /.navbar-collapse -->\r\n");
      out.write("      </nav>\r\n");
      out.write("    </aside>\r\n");
      out.write("\t</div>\r\n");
      out.write("\t\t<!--left-fixed -navigation-->\r\n");
      out.write("\t\t\r\n");
      out.write("\t\t<!-- header-starts -->\r\n");
      out.write("\t\t<div class=\"sticky-header header-section \">\r\n");
      out.write("\t\t\t<div class=\"header-left\">\r\n");
      out.write("\t\t\t\t\r\n");
      out.write("\t\t\t\t<!--toggle button start-->\r\n");
      out.write("\t\t\t\t<button id=\"showLeftPush\"><i class=\"fa fa-bars\"></i></button>\r\n");
      out.write("\t\t\t\t<!--toggle button end-->\r\n");
      out.write("\t\t\t\t<div class=\"profile_details_left\"><!--notifications of menu start -->\r\n");
      out.write("\t\t\t\t\t<ul class=\"nofitications-dropdown\">\r\n");
      out.write("\t\t\t\t\t\t<li class=\"dropdown head-dpdn\">\r\n");
      out.write("\t\t\t\t\t\t\t<a href=\"#\" class=\"dropdown-toggle\" data-toggle=\"dropdown\" aria-expanded=\"false\"><i class=\"fa fa-envelope\"></i><span class=\"badge\">4</span></a>\r\n");
      out.write("\t\t\t\t\t\t\t<ul class=\"dropdown-menu\">\r\n");
      out.write("\t\t\t\t\t\t\t\t<li>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t<div class=\"notification_header\">\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t<h3>你有4条消息</h3>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t</div>\r\n");
      out.write("\t\t\t\t\t\t\t\t</li>\r\n");
      out.write("\t\t\t\t\t\t\t\t<li><a href=\"#\">\r\n");
      out.write("\t\t\t\t\t\t\t\t   <div class=\"user_img\"><img src=\"images/1.jpg\" alt=\"\"></div>\r\n");
      out.write("\t\t\t\t\t\t\t\t   <div class=\"notification_desc\">\r\n");
      out.write("\t\t\t\t\t\t\t\t\t<p>作业提交提醒</p>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t<p><span>1小时前</span></p>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t</div>\r\n");
      out.write("\t\t\t\t\t\t\t\t   <div class=\"clearfix\"></div>\t\r\n");
      out.write("\t\t\t\t\t\t\t\t</a></li>\r\n");
      out.write("\t\t\t\t\t\t\t\t<li class=\"odd\"><a href=\"#\">\r\n");
      out.write("\t\t\t\t\t\t\t\t\t<div class=\"user_img\"><img src=\"images/4.jpg\" alt=\"\"></div>\r\n");
      out.write("\t\t\t\t\t\t\t\t   <div class=\"notification_desc\">\r\n");
      out.write("\t\t\t\t\t\t\t\t\t<p>作业已成功发送 </p>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t<p><span>1天前</span></p>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t</div>\r\n");
      out.write("\t\t\t\t\t\t\t\t  <div class=\"clearfix\"></div>\t\r\n");
      out.write("\t\t\t\t\t\t\t\t</a></li>\r\n");
      out.write("\t\t\t\t\t\t\t\t<li><a href=\"#\">\r\n");
      out.write("\t\t\t\t\t\t\t\t   <div class=\"user_img\"><img src=\"images/3.jpg\" alt=\"\"></div>\r\n");
      out.write("\t\t\t\t\t\t\t\t   <div class=\"notification_desc\">\r\n");
      out.write("\t\t\t\t\t\t\t\t\t<p>新作业提醒</p>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t<p><span>30分钟前</span></p>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t</div>\r\n");
      out.write("\t\t\t\t\t\t\t\t   <div class=\"clearfix\"></div>\t\r\n");
      out.write("\t\t\t\t\t\t\t\t</a></li>\r\n");
      out.write("\t\t\t\t\t\t\t\t<li>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t<div class=\"notification_bottom\">\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t<a href=\"#\">查看所有消息</a>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t</div> \r\n");
      out.write("\t\t\t\t\t\t\t\t</li>\r\n");
      out.write("\t\t\t\t\t\t\t</ul>\r\n");
      out.write("\t\t\t\t\t\t</li>\r\n");
      out.write("\t\t\t\t\t\t\r\n");
      out.write("\t\t\t\t\t\t<li class=\"dropdown head-dpdn\">\r\n");
      out.write("\t\t\t\t\t\t\t<a href=\"#\" class=\"dropdown-toggle\" data-toggle=\"dropdown\" aria-expanded=\"false\"><i class=\"fa fa-tasks\"></i><span class=\"badge blue1\">8</span></a>\r\n");
      out.write("\t\t\t\t\t\t\t<ul class=\"dropdown-menu\">\r\n");
      out.write("\t\t\t\t\t\t\t\t<li>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t<div class=\"notification_header\">\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t<h3>你有八个任务尚未完成</h3>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t</div>\r\n");
      out.write("\t\t\t\t\t\t\t\t</li>\r\n");
      out.write("\t\t\t\t\t\t\t\t<li><a href=\"#\">\r\n");
      out.write("\t\t\t\t\t\t\t\t\t<div class=\"task-info\">\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t<span class=\"task-desc\">数据完整度</span><span class=\"percentage\">40%</span>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t<div class=\"clearfix\"></div>\t\r\n");
      out.write("\t\t\t\t\t\t\t\t\t</div>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t<div class=\"progress progress-striped active\">\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t<div class=\"bar yellow\" style=\"width:40%;\"></div>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t</div>\r\n");
      out.write("\t\t\t\t\t\t\t\t</a></li>\r\n");
      out.write("\t\t\t\t\t\t\t\t<li><a href=\"#\">\r\n");
      out.write("\t\t\t\t\t\t\t\t\t<div class=\"task-info\">\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t<span class=\"task-desc\">账号绑定</span><span class=\"percentage\">33%</span>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t<div class=\"clearfix\"></div>\t\r\n");
      out.write("\t\t\t\t\t\t\t\t\t</div>\r\n");
      out.write("\t\t\t\t\t\t\t\t   <div class=\"progress progress-striped active\">\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t <div class=\"bar red\" style=\"width: 33%;\"></div>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t</div>\r\n");
      out.write("\t\t\t\t\t\t\t\t</a></li>\r\n");
      out.write("\t\t\t\t\t\t\t\t<li><a href=\"#\">\r\n");
      out.write("\t\t\t\t\t\t\t\t\t<div class=\"task-info\">\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t<span class=\"task-desc\">固定任务</span><span class=\"percentage\">80%</span>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t   <div class=\"clearfix\"></div>\t\r\n");
      out.write("\t\t\t\t\t\t\t\t\t</div>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t<div class=\"progress progress-striped active\">\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t <div class=\"bar  blue\" style=\"width: 80%;\"></div>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t</div>\r\n");
      out.write("\t\t\t\t\t\t\t\t</a></li>\r\n");
      out.write("\t\t\t\t\t\t\t\t<li>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t<div class=\"notification_bottom\">\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t<a href=\"#\">查看所有任务</a>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t</div> \r\n");
      out.write("\t\t\t\t\t\t\t\t</li>\r\n");
      out.write("\t\t\t\t\t\t\t</ul>\r\n");
      out.write("\t\t\t\t\t\t</li>\t\r\n");
      out.write("\t\t\t\t\t</ul>\r\n");
      out.write("\t\t\t\t\t<div class=\"clearfix\"> </div>\r\n");
      out.write("\t\t\t\t</div>\r\n");
      out.write("\t\t\t\t<!--notification menu end -->\r\n");
      out.write("\t\t\t\t<div class=\"clearfix\"> </div>\r\n");
      out.write("\t\t\t</div>\r\n");
      out.write("\t\t\t<div class=\"header-right\">\r\n");
      out.write("\t\t\t\t\r\n");
      out.write("\t\t\t\t\r\n");
      out.write("\t\t\t\t<!--search-box-->\r\n");
      out.write("\t\t\t\t<div class=\"search-box\">\r\n");
      out.write("\t\t\t\t\t<form class=\"input\">\r\n");
      out.write("\t\t\t\t\t\t<input class=\"sb-search-input input__field--madoka\" placeholder=\"Search...\" type=\"search\" id=\"input-31\" />\r\n");
      out.write("\t\t\t\t\t\t<label class=\"input__label\" for=\"input-31\">\r\n");
      out.write("\t\t\t\t\t\t\t<svg class=\"graphic\" width=\"100%\" height=\"100%\" viewBox=\"0 0 404 77\" preserveAspectRatio=\"none\">\r\n");
      out.write("\t\t\t\t\t\t\t\t<path d=\"m0,0l404,0l0,77l-404,0l0,-77z\"/>\r\n");
      out.write("\t\t\t\t\t\t\t</svg>\r\n");
      out.write("\t\t\t\t\t\t</label>\r\n");
      out.write("\t\t\t\t\t</form>\r\n");
      out.write("\t\t\t\t</div><!--//end-search-box-->\r\n");
      out.write("\t\t\t\t\r\n");
      out.write("\t\t\t\t<div class=\"profile_details\">\t\t\r\n");
      out.write("\t\t\t\t\t<ul>\r\n");
      out.write("\t\t\t\t\t\t<li class=\"dropdown profile_details_drop\">\r\n");
      out.write("\t\t\t\t\t\t\t<a href=\"#\" class=\"dropdown-toggle\" data-toggle=\"dropdown\" aria-expanded=\"false\">\r\n");
      out.write("\t\t\t\t\t\t\t\t<div class=\"profile_img\">\t\r\n");
      out.write("\t\t\t\t\t\t\t\t\t<span class=\"prfil-img\"><img src=\"images/tim.jpg\" style=\"width: 50px; height: 50px\" alt=\"\"> </span> \r\n");
      out.write("\t\t\t\t\t\t\t\t\t<div class=\"user-name\">\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t<p>");
      out.write((java.lang.String) org.apache.jasper.runtime.PageContextImpl.proprietaryEvaluate("${sessionScope.name}", java.lang.String.class, (javax.servlet.jsp.PageContext)_jspx_page_context, null));
      out.write("</p>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t<span>主任</span>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t</div>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t<i class=\"fa fa-angle-down lnr\"></i>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t<i class=\"fa fa-angle-up lnr\"></i>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t<div class=\"clearfix\"></div>\t\r\n");
      out.write("\t\t\t\t\t\t\t\t</div>\t\r\n");
      out.write("\t\t\t\t\t\t\t</a>\r\n");
      out.write("\t\t\t\t\t\t\t<ul class=\"dropdown-menu drp-mnu\">\r\n");
      out.write("\t\t\t\t\t\t\t\t<li> <a href=\"signup.jsp\"><i class=\"fa fa-user\"></i> 账户</a> </li>\r\n");
      out.write("\t\t\t\t\t\t\t\t<li> <a href=\"loginout.do\"><i class=\"fa fa-sign-out\"></i>注销</a> </li>\r\n");
      out.write("\t\t\t\t\t\t\t</ul>\r\n");
      out.write("\t\t\t\t\t\t</li>\r\n");
      out.write("\t\t\t\t\t</ul>\r\n");
      out.write("\t\t\t\t</div>\r\n");
      out.write("\t\t\t\t<div class=\"clearfix\"> </div>\t\t\t\t\r\n");
      out.write("\t\t\t</div>\r\n");
      out.write("\t\t\t<div class=\"clearfix\"> </div>\t\r\n");
      out.write("\t\t</div>\r\n");
      out.write("\t\t<!-- //header-ends -->\r\n");
      out.write("\t\t<!-- main content start-->\r\n");
      out.write("\t\t<div id=\"page-wrapper\">\r\n");
      out.write("\t\t\t<div class=\"main-page\">\r\n");
      out.write("\t\t\t\t<div class=\"row\">\r\n");
      out.write("\t\t\t\t\t\t<div class=\"col-md-6 validation-grids widget-shadow\" data-example-id=\"basic-forms\"> \r\n");
      out.write("\t\t\t\t\t\t\t<div class=\"form-title\">\r\n");
      out.write("\t\t\t\t\t\t\t\t<h4>录入成绩</h4>\r\n");
      out.write("\t\t\t\t\t\t\t</div>\r\n");
      out.write("\t\t\t\t\t\t\t<div class=\"form-body\">\r\n");
      out.write("\t\t\t\t\t\t\t\t<form data-toggle=\"validator\" action=\"Grade3.do\" method=\"post\">\r\n");
      out.write("\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n");
      out.write("\t\t\t\t\t\t\t\t\t<span class=\"help-block\">请输入学号</span>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t<input type=\"text\" class=\"form-control\" id=\"inputName\" placeholder=\"学号\" required name=\"sno\">\r\n");
      out.write("\t\t\t\t\t\t\t\t\t</div>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t<div class=\"form-group has-feedback\">\r\n");
      out.write("\t\t\t\t\t\t\t\t\t<span class=\"help-block\">请输入成绩</span>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t<input type=\"text\" class=\"form-control\" id=\"inputEmail\" placeholder=\"成绩\" data-error=\"请输入不小于0的数据\" pattern=\"^^[0-9]+.?[0-9]*$\" required name=\"grade\">\r\n");
      out.write("\t\t\t\t\t\t\t\t\t</div>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n");
      out.write("\t\t\t\t\t\t\t\t\t<span class=\"help-block\">请输入课程号</span>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t  <input type=\"text\"  class=\"form-control\" id=\"inputPassword\" placeholder=\"课程号\" required name=\"cno\">\r\n");
      out.write("\t\t\t\t\t\t\t\t\t</div>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n");
      out.write("\t\t\t\t\t\t\t\t\t\t<div class=\"sub_home\">\r\n");
      out.write("\t\t\t\t\t\t\t<input type=\"submit\" value=\"Submit\">\r\n");
      out.write("\t\t\t\t\t\t<div class=\"clearfix\"> </div>\r\n");
      out.write("\t\t\t\t\t</div>\r\n");
      out.write("\t\t\t\t\t\t\t\t\t</div>\r\n");
      out.write("\t\t\t\t\t\t\t\t</form>\r\n");
      out.write("\t\t\t\t\t\t\t</div>\r\n");
      out.write("\t\t\t\t\t\t</div></div>\r\n");
      out.write("\t\t\t</div>\r\n");
      out.write("\t\t</div>\r\n");
      out.write("\t\t<!--footer-->\r\n");
      out.write("\t\t<div class=\"footer\">\r\n");
      out.write("\t\t   <p>&copy; &nbsp;&nbsp;&nbsp;ZJUT&nbsp;&nbsp;&nbsp;计实1801 &nbsp;&nbsp;&nbsp;王佳&nbsp;&nbsp;&nbsp;</p>\r\n");
      out.write("\t   </div>\r\n");
      out.write("        <!--//footer-->\r\n");
      out.write("\t</div>\r\n");
      out.write("\t\r\n");
      out.write("\t<!-- side nav js -->\r\n");
      out.write("\t<script src='js/SidebarNav.min.js' type='text/javascript'></script>\r\n");
      out.write("\t<script>\r\n");
      out.write("      $('.sidebar-menu').SidebarNav()\r\n");
      out.write("    </script>\r\n");
      out.write("\t<!-- //side nav js -->\r\n");
      out.write("\t\r\n");
      out.write("\t<!-- Classie --><!-- for toggle left push menu script -->\r\n");
      out.write("\t\t<script src=\"js/classie.js\"></script>\r\n");
      out.write("\t\t<script>\r\n");
      out.write("\t\t\tvar menuLeft = document.getElementById( 'cbp-spmenu-s1' ),\r\n");
      out.write("\t\t\t\tshowLeftPush = document.getElementById( 'showLeftPush' ),\r\n");
      out.write("\t\t\t\tbody = document.body;\r\n");
      out.write("\t\t\t\t\r\n");
      out.write("\t\t\tshowLeftPush.onclick = function() {\r\n");
      out.write("\t\t\t\tclassie.toggle( this, 'active' );\r\n");
      out.write("\t\t\t\tclassie.toggle( body, 'cbp-spmenu-push-toright' );\r\n");
      out.write("\t\t\t\tclassie.toggle( menuLeft, 'cbp-spmenu-open' );\r\n");
      out.write("\t\t\t\tdisableOther( 'showLeftPush' );\r\n");
      out.write("\t\t\t};\r\n");
      out.write("\t\t\t\r\n");
      out.write("\t\t\tfunction disableOther( button ) {\r\n");
      out.write("\t\t\t\tif( button !== 'showLeftPush' ) {\r\n");
      out.write("\t\t\t\t\tclassie.toggle( showLeftPush, 'disabled' );\r\n");
      out.write("\t\t\t\t}\r\n");
      out.write("\t\t\t}\r\n");
      out.write("\t\t</script>\r\n");
      out.write("\t<!-- //Classie --><!-- //for toggle left push menu script -->\r\n");
      out.write("\t\r\n");
      out.write("\t<!--scrolling js-->\r\n");
      out.write("\t<script src=\"js/jquery.nicescroll.js\"></script>\r\n");
      out.write("\t<script src=\"js/scripts.js\"></script>\r\n");
      out.write("\t<!--//scrolling js-->\r\n");
      out.write("\t\r\n");
      out.write("\t<!-- Bootstrap Core JavaScript -->\r\n");
      out.write("   <script src=\"js/bootstrap.js\"> </script>\r\n");
      out.write("   \r\n");
      out.write("</body>\r\n");
      out.write("</html>");
    } catch (java.lang.Throwable t) {
      if (!(t instanceof javax.servlet.jsp.SkipPageException)){
        out = _jspx_out;
        if (out != null && out.getBufferSize() != 0)
          try {
            if (response.isCommitted()) {
              out.flush();
            } else {
              out.clearBuffer();
            }
          } catch (java.io.IOException e) {}
        if (_jspx_page_context != null) _jspx_page_context.handlePageException(t);
        else throw new ServletException(t);
      }
    } finally {
      _jspxFactory.releasePageContext(_jspx_page_context);
    }
  }
}
