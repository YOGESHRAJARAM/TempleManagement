using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace TempleManagement
{
    
    internal class config
    {
        public MySqlConnection con;
        public config()
        {
            try
            {
                string str = "server=localhost;Database=templemanage;Username=root;Password=9n00vEmt;charset=utf8;";
                con = new MySqlConnection(str);
                //con.Open();
                //MessageBox.Show("connected sucessllfully");
            }
            catch(MySqlException ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadGrid(DataGridView dgrid,string qry)
        {
            try
            {
                DataTable dt = new DataTable();
                MySqlDataAdapter ad = new MySqlDataAdapter(qry,con);
                ad.Fill(dt);
                dgrid.DataSource = dt;


            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
