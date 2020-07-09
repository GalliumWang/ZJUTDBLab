using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace 高校成绩管理系统
{
    public class serverName
    {
        public static string serverString = "";//GALLIUM - WANG\\GALLIUMMSQL
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();//美化按钮图形
            Application.SetCompatibleTextRenderingDefault(false);//字体渲染设置
            Application.Run(new 启动界面());
        }
    }
}
