using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1_061
{
    public partial class pr4_3 : Form
    {
        public pr4_3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int cnt = treeView1.Nodes.Count;
            MessageBox.Show(cnt.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Nodes.Add(textBox1.Text);
        }
    }
}
