using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Diagnostics;

namespace LabRab1SAPRKS
{
    public partial class LabRabCAD : Form
    {
        public LabRabCAD()
        {
            InitializeComponent();
            CreateTreeDriveToolStripMenuItem.Enabled = false;
        }


        SqlConnection myConnection = new SqlConnection("server=DESKTOP-60KJVUB\\SQLServer");
        int n=2;
        int node = 0; //Счетчик узлов
        int number = 0;
        List<int> numbers = new List<int> { 0, 1 };

        TreeNode mySelectedNode;

        public string testdir = @"F:\List\";
        private void CreateIfMissing(string path)
        {
            bool folderExist = Directory.Exists(path);
            if (!folderExist)
                Directory.CreateDirectory(path);
        }

        private void PrintRecursive(TreeNode treeNode)
        {
            System.Diagnostics.Debug.WriteLine(treeNode.Text);
            //просматриваем все родительские вершины, создаем отдельный узел на диске
            CreateIfMissing(testdir + treeNode.FullPath); 

            //печать каждого узла tn рекурсивно
            foreach (TreeNode tn in treeNode.Nodes)
            {
                PrintRecursive(tn);
            }
        }

        private void CallRecursive(TreeView treeView)
        {
            TreeNodeCollection nodes = treeView.Nodes;
            foreach (TreeNode n in nodes)
            {
                PrintRecursive(n);
            }
            MessageBox.Show("Done!");
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateNewTree()
        {
            treeView1.Nodes.Clear();

            treeView1.Nodes.Add("1. Исходно-разрешительная документация (ИРД)");
            treeView1.Nodes.Add("2. Инженерные изыскания (ИИ)");
            treeView1.Nodes.Add("3. Проектная документация стадии П (ПД)");
            treeView1.Nodes.Add("4. Проектная документация стадии Р (РД)");
            treeView1.Nodes.Add("5. Коммерческая документация (КД)");

            foreach (int n in numbers)
            {
                int k = n + 1;
                treeView1.Nodes[0].Nodes.Add("1." + k + " Объект " + k);
                treeView1.Nodes[0].Nodes[node].Nodes.Add("1." + k + ".1 Документы на ЗУ");
                treeView1.Nodes[0].Nodes[node].Nodes.Add("1." + k + ".2 Градостроительный план ЗУ");
                treeView1.Nodes[0].Nodes[node].Nodes.Add("1." + k + ".3 Разрешение на строительство");
                treeView1.Nodes[0].Nodes[node].Nodes.Add("1." + k + ".4 Технические условия");
                treeView1.Nodes[0].Nodes[node].Nodes.Add("1." + k + ".5 Проектная декларация");

                treeView1.Nodes[1].Nodes.Add("2." + k + " Объект " + k);
                treeView1.Nodes[1].Nodes[node].Nodes.Add("2." + k + ".1 Инженерно-геодезические изыскания");
                treeView1.Nodes[1].Nodes[node].Nodes.Add("2." + k + ".2 Инженерно-геологические изыскания");
                treeView1.Nodes[1].Nodes[node].Nodes.Add("2." + k + ".3 Инженерно-экологические изыскания");

                treeView1.Nodes[2].Nodes.Add("3." + k + " Объект " + k);
                treeView1.Nodes[2].Nodes[node].Nodes.Add("3." + k + ".1 Пояснительная записка");
                treeView1.Nodes[2].Nodes[node].Nodes.Add("3." + k + ".2 Градостроительный план ЗУ");
                treeView1.Nodes[2].Nodes[node].Nodes.Add("3." + k + ".3 Архитектурные решения");
                treeView1.Nodes[2].Nodes[node].Nodes.Add("3." + k + ".4 Конструктивные решения");

                treeView1.Nodes[3].Nodes.Add("4." + k + " Объект " + k);
                treeView1.Nodes[3].Nodes[node].Nodes.Add("4." + k + ".1 Генеральный план");
                treeView1.Nodes[3].Nodes[node].Nodes.Add("4." + k + ".2 Архитектурно-строительные решения");
                treeView1.Nodes[3].Nodes[node].Nodes.Add("4." + k + ".3 Архитектурные решения");
                treeView1.Nodes[3].Nodes[node].Nodes.Add("4." + k + ".4 Конструкции железобетонные");

                treeView1.Nodes[4].Nodes.Add("5." + k + " Объект " + k);
                treeView1.Nodes[4].Nodes[node].Nodes.Add("5." + k + ".1 Поэтажные планы");
                treeView1.Nodes[4].Nodes[node].Nodes.Add("5." + k + ".2 Прайсы");
                treeView1.Nodes[4].Nodes[node].Nodes.Add("5." + k + ".3 Брошюры");

                node++;
                number++;
            }

            treeView1.ExpandAll(); //разворачивает дерево
            treeView1.HotTracking = true; // подсвечивает текст при наведении мышкой
            CreateTreeDriveToolStripMenuItem.Enabled = true;
            node = 0; // Очищает счетчик узлов
        }

        private void CreateTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewTree();
        }

        private void CreateTreeDriveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
            CallRecursive(treeView1);
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                listView1.Items.Clear();

                foreach (string file in Directory.GetFiles(testdir + treeView1.SelectedNode.FullPath))
                {
                    string fileName = file.Replace((testdir + treeView1.SelectedNode.FullPath + @"\"), String.Empty);
                    ListViewItem lvi = new ListViewItem(fileName);
                    lvi.Name = fileName;
                    string filenameExtension = Path.GetExtension(file.ToLower());

                    switch (filenameExtension)
                    {
                        case ".doc":
                            {
                                lvi.ImageIndex = 0;
                                break;
                            }

                        case ".docx":
                            {
                                lvi.ImageIndex = 0;
                                break;
                            }

                        case ".pdf":
                            {
                                lvi.ImageIndex = 1;
                                break;
                            }

                        default:
                            {
                                lvi.ImageIndex = 2;
                                break;
                            }
                    }

                    listView1.Items.Add(lvi);
                }
            }

            catch (Exception exp)
            {
                MessageBox.Show(exp + " Ошиииииииииибочка");
            }
        }

        private void AddObjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            numbers.Add(n);
            CreateNewTree();
            n++;
        }

        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            mySelectedNode = treeView1.GetNodeAt(e.X, e.Y);
        }

        private void DeleteObjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mySelectedNode.Nodes != null && mySelectedNode.Parent != null)
            {
                treeView1.SelectedNode = mySelectedNode;
                const string message = "Are you sure that you would like to delete this object?";
                const string caption = "Delete Object";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string nodeStr = mySelectedNode.Text;
                    char theLastCharacterOfNodeStr = nodeStr[nodeStr.Length - 1];
                    int bar = theLastCharacterOfNodeStr - '0';
                    numbers.Remove(bar - 1);
                    node = 0;
                    CreateNewTree();
                }
            }
            else
            {
                MessageBox.Show("Only objects can be deleted!");
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listView1.HotTracking = true;
            ListViewItem myFile = listView1.GetItemAt(e.X, e.Y);


            string fullPath = testdir + treeView1.SelectedNode.FullPath + @"\" + myFile.Name; 
            System.Diagnostics.Process.Start(fullPath);
        }

        private void DatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Connect();
            frm.Show();
            this.Hide();
        }
    }
}
