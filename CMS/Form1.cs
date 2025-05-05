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

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            var uc = new Dashboard.ucDashbord();
            clsUtil.ShowUserControl(uc, pMain);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            var uc = new Users.Controls.ucManageUsers();
            clsUtil.ShowUserControl(uc, pMain);
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            var uc = new Doctors.Controls.ctrManageDoctors();
            clsUtil.ShowUserControl(uc, pMain);
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            var uc = new Patients.Controls.ctrManagePatiants();
            clsUtil.ShowUserControl(uc, pMain);
        }

        private void btnAppointements_Click(object sender, EventArgs e)
        {
            //var uc = new Appo();
            //clsUtil.ShowUserControl(uc, pMain);
            ////uc.RefreshData();
        }
    }
}
