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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            txtID.Focus();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtContact.Clear();
            txtID.Focus();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtID_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
