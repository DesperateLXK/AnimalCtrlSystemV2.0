using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HZH_Controls;
using HZH_Controls.Controls;
using HZH_Controls.Forms;

namespace AnimalCtrlSystem
{
    public partial class MainForm : FrmWithTitle
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //定义一个新的RfSerial类
        RfSerialCtrl Rfserial = new RfSerialCtrl();

        private void MainForm_Load(object sender, EventArgs e)
        {
            ContorlerInit();
            SerialFuncInit();
        }
        
        public void SerialFuncInit()
        {
            RfSerialCtrlPanel.Visible = false;
        }


        private void MainFormTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //panControl.Controls.Clear();
            string strName = e.Node.Text.Trim();
            switch (strName)
            {
                case "串口控制":
                    WelcomGroupBox.Visible = false;
                    RfSerialCtrlPanel.Visible = true;
                    break;
                case "USB控制":
                    WelcomGroupBox.Visible = false;
                    FrmDialog.ShowDialog(this, "USB控制", "测试", true);
                    break;
            }
        }

        //将GROUPBOX边线隐藏
        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox gBox = (GroupBox)sender;
            e.Graphics.Clear(gBox.BackColor);
            e.Graphics.DrawString(gBox.Text, gBox.Font, Brushes.Transparent, 10, 1);
            var vSize = e.Graphics.MeasureString(gBox.Text, gBox.Font);
            e.Graphics.DrawLine(Pens.Transparent, 1, vSize.Height / 2, 8, vSize.Height / 2);  //画笔颜色设置为透明
            e.Graphics.DrawLine(Pens.Transparent, vSize.Width + 8, vSize.Height / 2, gBox.Width - 2, vSize.Height / 2);
            e.Graphics.DrawLine(Pens.Transparent, 1, vSize.Height / 2, 1, gBox.Height - 2);
            e.Graphics.DrawLine(Pens.Transparent, 1, gBox.Height - 2, gBox.Width - 2, gBox.Height - 2);
            e.Graphics.DrawLine(Pens.Transparent, gBox.Width - 2, vSize.Height / 2, gBox.Width - 2, gBox.Height - 2);
        }
        private void MainFormLabelGBox_Paint(object sender, PaintEventArgs e)
        {
            GroupBox gBox = (GroupBox)sender;
            e.Graphics.Clear(gBox.BackColor);
            e.Graphics.DrawString(gBox.Text, gBox.Font, Brushes.Transparent, 10, 1);
            var vSize = e.Graphics.MeasureString(gBox.Text, gBox.Font);
            e.Graphics.DrawLine(Pens.Transparent, 1, vSize.Height / 2, 8, vSize.Height / 2);  //画笔颜色设置为透明
            e.Graphics.DrawLine(Pens.Transparent, vSize.Width + 8, vSize.Height / 2, gBox.Width - 2, vSize.Height / 2);
            e.Graphics.DrawLine(Pens.Transparent, 1, vSize.Height / 2, 1, gBox.Height - 2);
            e.Graphics.DrawLine(Pens.Transparent, 1, gBox.Height - 2, gBox.Width - 2, gBox.Height - 2);
            e.Graphics.DrawLine(Pens.Transparent, gBox.Width - 2, vSize.Height / 2, gBox.Width - 2, gBox.Height - 2);
        }

        private void AccessGBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox gBox = (GroupBox)sender;
            e.Graphics.Clear(gBox.BackColor);
            e.Graphics.DrawString(gBox.Text, gBox.Font, Brushes.Transparent, 10, 1);
            var vSize = e.Graphics.MeasureString(gBox.Text, gBox.Font);
            e.Graphics.DrawLine(Pens.Transparent, 1, vSize.Height / 2, 8, vSize.Height / 2);  //画笔颜色设置为透明
            e.Graphics.DrawLine(Pens.Transparent, vSize.Width + 8, vSize.Height / 2, gBox.Width - 2, vSize.Height / 2);
            e.Graphics.DrawLine(Pens.Transparent, 1, vSize.Height / 2, 1, gBox.Height - 2);
            e.Graphics.DrawLine(Pens.Transparent, 1, gBox.Height - 2, gBox.Width - 2, gBox.Height - 2);
            e.Graphics.DrawLine(Pens.Transparent, gBox.Width - 2, vSize.Height / 2, gBox.Width - 2, gBox.Height - 2);
        }
        //展开和折叠的时候都显示欢迎界面
        private void MainFormTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            WelcomGroupBox.Visible = true;
            RfSerialCtrlPanel.Visible = false;
        }

        private void MainFormTreeView_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            WelcomGroupBox.Visible = true;
            RfSerialCtrlPanel.Visible = false;
        }


        private void AccessSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (AccessSwitch1.Checked == true)
            {
                label10.ForeColor = Color.FromArgb(255, 77, 59);
                label10.Text = "开启";
            }
            else
            {
                label10.ForeColor = Color.FromArgb(112, 112, 112);
                label10.Text = "关闭";
            }
        }
    }
}
