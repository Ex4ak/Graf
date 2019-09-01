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

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "My Application", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.textBox1.Text = "";
            //this.textBox2.Text = "";
            this.openFileDialog1.ShowDialog();
            //if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            
                StreamWriter write_text;
                FileInfo file = new FileInfo("Place");
                write_text = file.AppendText();
                write_text.WriteLine(textBox1.Text);
                write_text.Close();
               // System.IO.StreamReader sr = new
                   // System.IO.StreamReader(openFileDialog1.FileName);
              
                //MessageBox.Show(sr.ReadToEnd());
                //sr.Close();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
