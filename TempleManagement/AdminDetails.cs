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
    public partial class AdminDetails : Form
    {
        public AdminDetails()
        {
            InitializeComponent();
        }
       
        config o = new config();
        
        private void AdminDetails_Load(object sender, EventArgs e)
        {
            o.LoadGrid(dataGridView1, "SELECT * FROM templemanage.logindetails;");
            


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
