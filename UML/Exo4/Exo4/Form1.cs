using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void changecoul()
        {
            int rouge = 0;
            if (checkBox1.Checked) rouge = 255;
            int blue = 0;
            if (checkBox2.Checked) blue = 255;
            int vert = 0;
            if (checkBox3.Checked) vert = 255;

            BackColor = Color.FromArgb(rouge, vert, blue);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            changecoul();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            changecoul();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            changecoul();
        }

        private void quiiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aproposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
