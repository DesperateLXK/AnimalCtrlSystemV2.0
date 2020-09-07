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
    class ControlerInit
    {
    }

    public partial class MainForm : FrmWithTitle
    {
        public void ContorlerInit()
        {
            TreeViewInit();
        }

        public void TreeViewInit()
        {
            ControlHelper.FreezeControl(this, true);
            TreeNode tnPatternChoose = new TreeNode("      射频控制模式选择");
            tnPatternChoose.Nodes.Add("串口控制");
            tnPatternChoose.Nodes.Add("USB控制");
            this.MainFormTreeView.Nodes.Add(tnPatternChoose);
            TreeNode tnAboutUs = new TreeNode("      关于我们");
            this.MainFormTreeView.Nodes.Add(tnAboutUs);
        }
    }




}
