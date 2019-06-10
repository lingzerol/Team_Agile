using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Lib;

namespace Team_Agile.Pages
{
    public partial class Student_Interface : Form
    {
        StructureOfProblem selectedProblem;
        private const Keys CopyKeys = Keys.Control | Keys.C;
        private const Keys PasteKeys = Keys.Control | Keys.V;

        public Student_Interface()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == CopyKeys) || (keyData == PasteKeys))
            {
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
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
            Main_TreeView.ImageList = imageList1;
            node.Text = "Php/Mysql三日通";
            this.Main_TreeView.Nodes.Add(node);
            TreeNode node1 = new TreeNode();
            node1.Text = "第一天";
            node.Nodes.Add(node1);
            foreach (int key in problems.Keys)
            {
                TreeNode minnode = new TreeNode();
                minnode.Text = ProblemList.GetProblem(key).QuestionName;
                if (ProblemList.GetProblem(key).Status == 1)
                {
                    minnode.ImageIndex = 1;
                }
                else if (ProblemList.GetProblem(key).Status == 0)
                {
                    minnode.ImageIndex = 0;
                }
                else
                {
                    minnode.ImageIndex = 2;
                }
                node1.Nodes.Add(minnode);
            }
        }

        private void Main_TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Action == TreeViewAction.ByMouse)
            {
                TreeNode selected = e.Node;
                foreach (int key in problems.Keys)
                {
                    if (this.Main_TreeView.SelectedNode.Text == ProblemList.GetProblem(key).QuestionName)
                    {
                        selectedProblem = ProblemList.GetProblem(key);
                        ShowProblem(ProblemList.GetProblem(key));
                    }
                }

            }
        }

        private void ShowProblem(StructureOfProblem problem)
        {
            this.ProblemDec.Text = problem.QuestionDescription;
            this.StandardAnswer.Text = problem.Problemcode;
            this.StandarOutputrichTextBox.Text = problem.OutputSample;
            this.label_Exercise_Name.Text = problem.QuestionName;
            this.ProblemWebBrowser.DocumentText = problem.QuestionDescription;
            this.InputSamplerichTextBox.Text = problem.InputSample;
            this.OutputSamplerichTextBox.Text = problem.OutputSample;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            foreach (int key in problems.Keys)
            {
                if (this.Main_TreeView.SelectedNode.Text == ProblemList.GetProblem(key).QuestionName)
                {
                // ProblemList.GetProblem(key).QuestionDescription = this.Problem_Description_HTML.Text;
                }
            }
            ProblemList.Save();
        }

        private void btn_Run_Answer_Click(object sender, EventArgs e)
        {
            if (selectedProblem == null)
            {
                MessageBox.Show("当前未选择题目");
                return;
            }
            PHPRunner runner = new PHPRunner();
            //selectedProblem.InputSample = "1 2";
            //selectedProblem.Problemcode = "<?php echo $_GET['a']; echo $_GET['b'];";
            runner.Code = selectedProblem.Problemcode;
            if (selectedProblem.InputSample != "" || selectedProblem.InputSample!=null) {
                string[] parameters = selectedProblem.InputSample.Split(' ');
                for (int i = 0; i < parameters.Length; i++)
                {
                    runner.QueryString += "parameter" + i + "=" + parameters[i] + "&";
                   
                    //runner.Code = runner.Code.Replace(Regex.Match(runner.Code,"\\$_GET\\[\\S*\\]$").Value, "$_GET['parameter"+i+"']");
                }
                MatchCollection mc = Regex.Matches(runner.Code, "\\$_GET\\[\\S*\\]");
                int j = 0;
                foreach(Match m in mc)
                {
                    //MessageBox.Show(m.Value);
                    runner.Code = runner.Code.Replace(m.Value, "$_GET['parameter" + j + "']");
                    j++;
                }
                //runner.Code =  runner.Code.Replace("$_GET['a']", "$_GET['parameter0']");
               // runner.Code = runner.Code.Replace("$_GET['b']", "$_GET['parameter1']");
                runner.QueryString = runner.QueryString.Substring(0, runner.QueryString.Length - 1);
            }
           
            String res = runner.run();
            StandarOutputrichTextBox.Text = res;
            Problem_tabControl.SelectedTab = Standard_Answer_Output_Browse;
        }

        private void btn_Run_Code_Click(object sender, EventArgs e)
        {
            if (selectedProblem == null)
            {
                MessageBox.Show("当前未选择题目");
                return;
            }
            PHPRunner runner = new PHPRunner();
            //selectedProblem.InputSample = "1 2";
            //selectedProblem.Problemcode = "<?php echo $_GET['a']; echo $_GET['b'];";
            if (this.problemcode.Text == "")
            {
                MessageBox.Show("请输入解答代码！");
                return;
            }
            runner.Code = this.problemcode.Text;
            if (selectedProblem.InputSample != "" || selectedProblem.InputSample != null)
            {
                string[] parameters = selectedProblem.InputSample.Split(' ');
                for (int i = 0; i < parameters.Length; i++)
                {
                    runner.QueryString += "parameter" + i + "=" + parameters[i] + "&";

                    //runner.Code = runner.Code.Replace(Regex.Match(runner.Code,"\\$_GET\\[\\S*\\]$").Value, "$_GET['parameter"+i+"']");
                }
                MatchCollection mc = Regex.Matches(runner.Code, "\\$_GET\\[\\S*\\]");
                int j = 0;
                foreach (Match m in mc)
                {
                    //MessageBox.Show(m.Value);
                    runner.Code = runner.Code.Replace(m.Value, "$_GET['parameter" + j + "']");
                    j++;
                }
                //runner.Code =  runner.Code.Replace("$_GET['a']", "$_GET['parameter0']");
                // runner.Code = runner.Code.Replace("$_GET['b']", "$_GET['parameter1']");
                runner.QueryString = runner.QueryString.Substring(0, runner.QueryString.Length - 1);
            }

            String res = runner.run();
            Browser_output.Text = res;
            Answer_tabControl.SelectedTab = Browse_Output;
            if (res == selectedProblem.OutputSample)
            {
                this.Main_TreeView.SelectedNode.ImageIndex = 1;
                selectedProblem.Status = 1;
                MessageBox.Show("Accept");
                ProblemList.UpdateStatus(selectedProblem);
               
            }
            else
            {
                this.Main_TreeView.SelectedNode.ImageIndex = 2;
                selectedProblem.Status = -1;
                MessageBox.Show("WrongAnswer");
                ProblemList.UpdateStatus(selectedProblem);
            }
            this.Browser_output.Text = res;
            this.Main_TreeView.Invalidate();
        }

        private void btn_See_Answer_Click(object sender, EventArgs e)
        {
            if (selectedProblem == null)
            {
                MessageBox.Show("当前未选择题目");
                return;
            }
            this.Problem_tabControl.SelectedIndex = 2;
        }
    }
}
