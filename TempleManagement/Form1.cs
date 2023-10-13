using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TempleManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Are You Sure To Close","EXIT",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation)==DialogResult.OK)
            {
                Application.Exit();
            }
        }
        config o = new config();
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textUsername.Text))
            {
                MessageBox.Show("please enter username","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                textUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textPassword.Text))
            {
                MessageBox.Show("please enter Password", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textPassword.Focus();
                return;
            }
            string qry = "select*from logindetails where USERNAME='" + textUsername.Text + "'AND PASS='" + textPassword.Text + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(qry,o.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("welcome");
                Home hfrm = new Home();
                this.Hide();
                hfrm.Show();

            }
            else
            {
                MessageBox.Show("invalid password");
            }
        }
    }
}
