// Program.cs
using System;
using System.Windows.Forms;
using System.Threading;

namespace DynamicIsland
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 检查是否已有实例在运行
            if (Form1.IsAlreadyRunning())
            {
                // 激活已存在的实例并通知它显示"已启动"
                Form1.ActivateExistingInstance();

                // 给旧实例一点时间处理消息
                Thread.Sleep(100);

                // 新实例退出
                return;
            }

            Application.Run(new Form1());
        }
    }
}