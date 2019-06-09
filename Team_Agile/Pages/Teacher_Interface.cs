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
            this.Main_TreeView.LabelEdit = true;//可编辑状态。
            //添加一个节点，这个结点是根节点。
            TreeNode node = new TreeNode();
            node.Text = "Php/Mysql三日通";
            this.Main_TreeView.Nodes.Add(node);
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

        private void ProAddBtn_Click(object sender, EventArgs e)
        {
            XmlOperator xmlOperator = new XmlOperator();
            OpenFileDialog fileDialog = new OpenFileDialog();
            //fileDialog.Multiselect = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
               // MessageBox.Show(fileDialog.FileName);
                SerializableDictionary<int, StructureOfProblem> p = xmlOperator.readXML(fileDialog.FileName);
                if (this.Main_TreeView.Nodes.Count == 0 || this.Main_TreeView.SelectedNode == null)
                {
                    //this.Main_TreeView.Nodes.Add(NewProblemName);
                    foreach (int key in p.Keys)
                    {
                        TreeNode minnode = new TreeNode();
                        minnode.Text = ProblemList.GetProblem(key).QuestionName;
                        this.Main_TreeView.Nodes.Add(minnode);
                        ProblemList.Add(ProblemList.GetProblem(key));
                    }
                }
                else
                {
                    //this.Main_TreeView.SelectedNode.Nodes.Add(NewProblemName);
                    foreach (int key in p.Keys)
                    {
                        TreeNode minnode = new TreeNode();
                        minnode.Text = ProblemList.GetProblem(key).QuestionName;
                        this.Main_TreeView.SelectedNode.Nodes.Add(minnode);
                        ProblemList.Add(ProblemList.GetProblem(key));
                    }
                }
            }
        
        }

        private void ProDelBtn_Click(object sender, EventArgs e)
        {
            if (this.Main_TreeView.SelectedNode != null)
            {
                DialogResult dr = MessageBox.Show("确定删除“" + this.Main_TreeView.SelectedNode.Text
                    + "”？", "", MessageBoxButtons.OKCancel);
                if (dr.Equals(DialogResult.OK))
                {
                    this.Main_TreeView.Nodes.Remove(this.Main_TreeView.SelectedNode);
                    foreach (int key in problems.Keys)
                    {
                        if (this.Main_TreeView.SelectedNode.Text == ProblemList.GetProblem(key).QuestionName)
                        {
                            ProblemList.Delete(ProblemList.GetProblem(key).ProblemID);
                            ProblemList.Save();
                            break;
                        }
                    }
                }
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
                        ShowProblem(ProblemList.GetProblem(key));
                    }
                }

            }
        }

        private void ShowProblem(StructureOfProblem problem) {
            this.ProDescTextBox.Text = problem.QuestionDescription;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            foreach (int key in problems.Keys)
            {
                if (this.Main_TreeView.SelectedNode.Text == ProblemList.GetProblem(key).QuestionName)
                {
                    ProblemList.GetProblem(key).QuestionDescription = this.ProDescTextBox.Text;
                   
                }
                if(ProblemList.GetProblem(key).QuestionName=="新练习")
                {
                    ProblemList.GetProblem(key).QuestionName = this.Main_TreeView.SelectedNode.Text;
                    ProblemList.GetProblem(key).QuestionDescription = this.ProDescTextBox.Text;
                }
            }
            ProblemList.Save();
        }

        private void ProExportBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            if (path.ShowDialog() == DialogResult.OK)
            {
                // MessageBox.Show(path.SelectedPath);
                SerializableDictionary<int, StructureOfProblem> problems = ProblemList.GetAll();
                XmlOperator xmlOperator = new XmlOperator();

                xmlOperator.XMLSerialized(path.SelectedPath + "//Problem.xml", problems);
            }
        }

        private void CodeTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Problem_Edit_Click(object sender, EventArgs e)
        {
            this.Main_TreeView.SelectedNode.BeginEdit();

        }

        private void Problem_Add_Click(object sender, EventArgs e)
        {
            if (this.Main_TreeView.Nodes.Count == 0 || this.Main_TreeView.SelectedNode == null)
            {
                this.Main_TreeView.Nodes.Add(NewProblemName);
                StructureOfProblem problem = new StructureOfProblem();
                problem.QuestionName = NewProblemName;
                ProblemList.Add(problem);
            }
            else
            {
                this.Main_TreeView.SelectedNode.Nodes.Add(NewProblemName);
                StructureOfProblem problem = new StructureOfProblem();
                problem.QuestionName = NewProblemName;
                ProblemList.Add(problem);
            }
        }
    }
}
