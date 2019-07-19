using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospitalManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Patient cf = new Patient();
            cf.MdiParent = this;
            cf.Show();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            Doctor cf = new Doctor();
            cf.MdiParent = this;
            cf.Show();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            Services ser = new Services();
            ser.MdiParent = this;
            ser.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
