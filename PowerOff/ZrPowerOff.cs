using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace PowerOff
{
    public partial class ZrPowerOff : Form
    {

        Process theCmd = new Process();

        public ZrPowerOff()
        {
            InitializeComponent();

            theCmd.StartInfo.FileName = "cmd.exe";
            // 无窗口
            theCmd.StartInfo.CreateNoWindow = true;
            // 不启用shell启用进程
            theCmd.StartInfo.UseShellExecute = false;
            // 重定向
            theCmd.StartInfo.RedirectStandardOutput = true;
            theCmd.StartInfo.RedirectStandardError = true;
            theCmd.StartInfo.RedirectStandardInput = true;
        }

        private void powerOff_Click(object sender, EventArgs e)
        {
            decimal h = numHour.Value;
            decimal min = numMin.Value;
            decimal second = numSecond.Value;
            decimal total = h * 60 * 60 + min * 60 + second;
            string order = "shutdown -s -t " + total;

            theCmd.StartInfo.Arguments = "/c " + order;
            theCmd.Start();

            theCmd.StandardOutput.ReadToEnd();
            theCmd.WaitForExit();
            theCmd.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            theCmd.StartInfo.Arguments = "/c " + "shutdown -a";
            theCmd.Start();
            theCmd.StandardOutput.ReadToEnd();
            theCmd.WaitForExit();
            theCmd.Close();
        }
    }
}
