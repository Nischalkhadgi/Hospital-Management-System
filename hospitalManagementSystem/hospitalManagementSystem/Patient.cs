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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtContact.Clear();
            txtID.Focus();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please add");
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            txtID.Focus();
        }
    }
}