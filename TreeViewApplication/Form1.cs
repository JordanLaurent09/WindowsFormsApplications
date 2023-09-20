using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode rootNode = new TreeNode(textBox1.Text);
            treeView2.Nodes.Add(rootNode);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TreeNode rootNode = treeView2.SelectedNode;

            TreeNode internalNode = new TreeNode(textBox1.Text);
            rootNode.Nodes.Add(internalNode);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TreeNode rootNode = treeView2.SelectedNode;

            treeView2.Nodes.Remove(rootNode);
        }
    }
}
