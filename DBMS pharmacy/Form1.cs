using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_pharmacy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnSignln_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text=="аптекарь" && txtPassword.Text =="0000")
            {
                Administration am = new Administration();
                am.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
