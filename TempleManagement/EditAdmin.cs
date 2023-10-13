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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TempleManagement
{
    public partial class EditAdmin : Form
    {
        public EditAdmin()
        {
            InitializeComponent();
        }
        config o = new config();
        DataTable dt;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textusername.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textpassword.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textroll.Text= dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void EditAdmin_Load(object sender, EventArgs e)
        {
            string qry = "select*from logindetails;";
            o.LoadGrid(dataGridView1, qry);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                if (String.IsNullOrEmpty(textname.Text))
                {
                    MessageBox.Show("Please Enter FullName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textname.Focus();
                    return;
                }
                if (String.IsNullOrEmpty(textusername.Text))
                {
                    MessageBox.Show("Please Enter FullName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textusername.Focus();
                    return;
                }
                if (String.IsNullOrEmpty(textpassword.Text))
                {
                    MessageBox.Show("Please Enter FullName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textpassword.Focus();
                    return;
                }
                if (String.IsNullOrEmpty(textroll.Text))
                {
                    MessageBox.Show("Please Enter FullName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textroll.Focus();
                    return;
                }
                try
                {
                    string qry = "update logindetails set NAME='" + textname.Text + "',USERNAME='" + textusername.Text + "',PASS='" + textpassword.Text + "',ROLL='" + textroll.Text + "' where ID='" + textBox1.Text + "' ";
                    o.con.Open();
                    MySqlCommand cmd = new MySqlCommand(qry, o.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("sucessfully added");
                    string sqry = "select*from logindetails;";
                    o.LoadGrid(dataGridView1, sqry);
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

            }
            else
            {
                MessageBox.Show("please select the record on leftside dataview");
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textname.Clear();
            textusername.Clear();
            textpassword.Clear();
            textroll.Clear();
        }
    }
}
