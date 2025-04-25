using CMS.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            //var uc = new Persons.Controls.ucma();
            //clsUtil.ShowUserControl(uc, pMain);
            //uc.RefreshData();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            var uc = new Doctors.Controls.ctrManageDoctors();
            clsUtil.ShowUserControl(uc, pMain);
            //uc.RefreshData();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var uc = new Patients.Controls.ctrManagePatiants();
            clsUtil.ShowUserControl(uc, pMain);
            //uc.RefreshData();
        }
    }
}
