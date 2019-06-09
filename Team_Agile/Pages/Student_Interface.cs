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
    public partial class Student_Interface : Form
    {
        public Student_Interface()
        {
            InitializeComponent();
        }

        private void Answer_Code_Click(object sender, EventArgs e)
        {

        }

        private void ExportStatusBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            if (path.ShowDialog() == DialogResult.OK)
            {
                // MessageBox.Show(path.SelectedPath);
                SerializableDictionary<int, StructureOfProblem> problemsStatus = new SerializableDictionary<int, StructureOfProblem>();
                foreach (int key in problems.Keys)
                {
                    StructureOfProblem problem = new StructureOfProblem();
                    problem.ProblemID = ProblemList.GetProblem(key).ProblemID;
                    if (this.Main_TreeView.SelectedNode.Text == ProblemList.GetProblem(key).QuestionName)
                    {
                        problem.Problemcode = this.problemcode.Text;
                    }
                    problem.QuestionName = ProblemList.GetProblem(key).QuestionName;
                    problem.AcceptsRate = ProblemList.GetProblem(key).AcceptsRate;
                    problemsStatus.Add(problem.ProblemID, problem);
                }
                XmlOperator xmlOperator = new XmlOperator();
                xmlOperator.XMLSerialized(path.SelectedPath + "//ProblemStatus.xml", problemsStatus);
            }
        }

        private void ProAddBtn_Click(object sender, EventArgs e)
        {
            XmlOperator xmlOperator = new XmlOperator();
            OpenFileDialog fileDialog = new OpenFileDialog();
            //fileDialog.Multiselect = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(fileDialog.FileName);
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

        private void Student_Interface_Load(object sender, EventArgs e)
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            foreach (int key in problems.Keys)
            {
                if (this.Main_TreeView.SelectedNode.Text == ProblemList.GetProblem(key).QuestionName)
                {
                    ProblemList.GetProblem(key).QuestionDescription = this.Problem_Description_HTML.Text;
                }
            }
            ProblemList.Save();
        }
    }
}
