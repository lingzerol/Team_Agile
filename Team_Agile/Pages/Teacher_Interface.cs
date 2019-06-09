using Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Agile.Pages
{
    public partial class Teacher_Interface : Form
    {
        private const String NewProblemName = "新练习";

        public Teacher_Interface()
        {
            InitializeComponent();
        }

        private void Teacher_Interface_Load(object sender, EventArgs e)
        {
            this.Main_TreeView.LabelEdit = true;  
        }

        private void ProAddBtn_Click(object sender, EventArgs e)
        {
            if (this.Main_TreeView.Nodes.Count == 0|| this.Main_TreeView.SelectedNode==null)
            {
                this.Main_TreeView.Nodes.Add(NewProblemName);
            }
            else{
                this.Main_TreeView.SelectedNode.Nodes.Add(NewProblemName);
            }
        
        }

        private void ProDelBtn_Click(object sender, EventArgs e)
        {
            if (this.Main_TreeView.SelectedNode != null)
            {
                DialogResult dr = MessageBox.Show("确定删除“" + this.Main_TreeView.SelectedNode.Text
                    + "”？", "", MessageBoxButtons.OKCancel);
                if (dr.Equals(DialogResult.OK))
                    this.Main_TreeView.Nodes.Remove(this.Main_TreeView.SelectedNode);
            }
        }

        private void Main_TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Action == TreeViewAction.ByMouse) {
                TreeNode selected = e.Node;
                foreach (int key in problems.Keys)
                {
                    if (this.Main_TreeView.SelectedNode.Text == ProblemList.GetProblem(key).QuestionName)
                    {
                        ShowProblem();
                    }
                }

            }
        }

        private void ShowProblem() {
        }
       
    }
}
