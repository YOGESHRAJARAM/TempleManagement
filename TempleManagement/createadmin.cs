using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempleManagement
{
    public partial class createadmin : Form
    {
        public createadmin()
        {
            InitializeComponent();
        }
        config o = new config();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textname.Text))
            {
                MessageBox.Show("please enter the Name", "NAME", MessageBoxButtons.OK);
                textname.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textusername.Text))
            {
                MessageBox.Show("please enter the UserName", "UserName", MessageBoxButtons.OK);
                textusername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textpassword.Text))
            {
                MessageBox.Show("please enter the PASSWORD", "Password", MessageBoxButtons.OK);
                textpassword.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textroll.Text))
            {
                MessageBox.Show("please enter the Roll", "Roll", MessageBoxButtons.OK);
                textroll.Focus();
                return;
            }
            try
            {
                string qry ="insert into logindetails (NAME,USERNAME,PASS,ROLL) values('"+textname.Text+ "','"+textusername.Text+"','"+textpassword.Text+"','"+textroll.Text+"');";
                o.con.Open();
                MySqlCommand cmd = new MySqlCommand(qry,o.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("sucessfully added");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally 
            {
                if (o.con.State == ConnectionState.Open)
                {
                    o.con.Close();
                }
                 
            }
            textname.Clear();
            textusername.Clear();
            textpassword.Clear();
            textroll.Clear();
         

        }
    }
}
