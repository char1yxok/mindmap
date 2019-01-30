using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace mindmap_MMtest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void AddButtonClicked(object sender, EventArgs e)
        {
            //get data in the textbox
            if(this.InputBox.Text != "")
            {
                string inputvalue = this.InputBox.Text;
                
                //add node
                if (treeView1.SelectedNode == null)
                {
                    TreeNode rootnode = new TreeNode(inputvalue);
                    treeView1.Nodes.Add(rootnode);
                }
                else
                {
                    TreeNode childnode = new TreeNode(inputvalue);
                    treeView1.SelectedNode.Nodes.Add(childnode);
                }

                treeView1.ExpandAll();
            }
            else
            {
                MessageBox.Show("Textbox is null.");
            }
        }

        private void RemoveButtonClicked(object sender, EventArgs e)
        {
            if(treeView1.SelectedNode == null)
            {
                MessageBox.Show("Please select node.");
            }
            else
            {
                treeView1.SelectedNode.Remove();
                treeView1.SelectedNode = null;
            }
        }

        //reject space key press in the textbox
        private void InputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)32) || e.KeyChar.Equals((char)12288))
            {
                e.Handled = true;
            }
        }

        private void treeView1_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode = null;
        }
    }
}
