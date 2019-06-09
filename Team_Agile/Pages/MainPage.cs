using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib;

namespace Team_Agile.Pages
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //this.MainPage_Load(sender, e);
            if (e.Action == TreeViewAction.ByMouse)
            {
                foreach (int key in problems.Keys)
                {           
                    if(e.Node.Text == ProblemList.GetProblem(key).QuestionName)
                    {
                        //Form1 form = new Form1(ProblemList.GetProblem(key).ProblemID);
                        //form.FormBorderStyle = FormBorderStyle.None;
                        //form.Dock = System.Windows.Forms.DockStyle.Fill;
                        //this.panel1.Controls.Clear();
                        //form.TopLevel = false;
                        //panel1.Controls.Add(form);
                        //form.Show();          
                        //break;
                    }                  
                }
                           
            }
        }
        private void MainPage_Load(object sender, EventArgs e)
        {
            treeView1.LabelEdit = true;//可编辑状态。
            //添加一个节点，这个结点是根节点。
            TreeNode node = new TreeNode();
            node.Text = "Php/Mysql三日通";
            treeView1.Nodes.Add(node);
            TreeNode node1 = new TreeNode();
            node1.Text = "第一天";
            node.Nodes.Add(node1);
            foreach (int key in problems.Keys)
            {
                TreeNode minnode = new TreeNode();
                minnode.Text = ProblemList.GetProblem(key).QuestionName;
                node1.Nodes.Add(minnode);
            }
            }


        private void delete(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
            foreach (int key in problems.Keys)
            {
                if (treeView1.SelectedNode.Text == ProblemList.GetProblem(key).QuestionName)
                {
                    ProblemList.Delete(ProblemList.GetProblem(key).ProblemID);
                    ProblemList.Save();
                    break;
                }
            }
            
        }

        private void edit(object sender, EventArgs e)
        {
            treeView1.SelectedNode.BeginEdit();

        }
    }
}
