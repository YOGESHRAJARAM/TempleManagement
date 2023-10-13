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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void spiceficDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void createADMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(createadmin))
                {
                    f.Activate();
                    return;
                }
            }
            createadmin frm = new createadmin();
            frm.MdiParent= this;
            frm.Show();

        }

        private void viewAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form f in Application.OpenForms)
            {
                if(f.GetType()==typeof(AdminDetails))
                {
                    f.Activate();
                    return;
                }
            }
            AdminDetails frm =new AdminDetails();
            frm.MdiParent = this;
            frm.Show();

        }

        private void editAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form f in Application.OpenForms)
            {
                if (f.GetType()==typeof(EditAdmin))
                {
                    f.Activate();
                    return;
                    
                }
            }

            EditAdmin frm = new EditAdmin();
            frm.MdiParent = this;
            frm.Show();
        }

        private void deleteAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
