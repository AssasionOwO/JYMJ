using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Console.WriteLine("系统出现错误，需要处理！");
            ErrorAbout errorAbout = new ErrorAbout();
            errorAbout.ErrorHanding();

            Console.ReadKey();
        }
    }

    public class Handle1
    {
        public void ErrorHanding()
        {
            Console.WriteLine("出现错误！发送了一条信息给管理员！");
        }
    }

    public class Handle2
    {
        public void ErrorHanding()
        {
            Console.WriteLine("发现错误！警报。。。。。。。。。。。。。。");
        }
    }

    public class Handle3
    {
        public void ErrorHanding()
        {
            Console.WriteLine("发现错误！哔哔哔。。。。。。");
        }
    }

    public class  ErrorAbout
    {
        public void ErrorHanding()
        {
            Handle1 handle1=new Handle1();
            Handle2 handle2=new Handle2();
            Handle3 handle3=new Handle3();

        }
    }
}
